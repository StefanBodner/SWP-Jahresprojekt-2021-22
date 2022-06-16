﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json;

namespace MyTrade
{
    public partial class frm_watchlist : Form
    {
        #region Variables
        static List<ResultStockQuote> liSQWatch = new List<ResultStockQuote>();
        static List<ResultStockQuote> liSQInvest = new List<ResultStockQuote>();
        static List<ResultChart> liC = new List<ResultChart>();
        static List<Button> libtn = new List<Button>();
        string webDataStockQuote = "";
        string webDataChart = "";

        byte sortSymbol;
        byte sortChange;
        byte sortPrice;
        byte sortExchange;

        string decimalsFormat = "{0:#,##0.00}";
        bool devMode = false;
        string lastClickedBtn = "";

        int currentMenuStripItem = 0;
        Color elementColor = Color.White;
        Color themeColorA = Color.LightSteelBlue;
        Color themeColorB = Color.White;

        string range = "6mo";
        string interval = "1d";

        int panelHeightExtended = 773;
        int panelHeightCropped = 404;

        static JsonSerializerSettings settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore
        };
        #endregion

        #region Initial Configurations
        public frm_watchlist()
        {
            InitializeComponent();
        }

        private async void WatchlistOverview_Load(object sender, EventArgs e)
        {
            libtn.Add(btn_sortSymbol);
            libtn.Add(btn_sortChange);
            libtn.Add(btn_sortPrice);
            libtn.Add(btn_sortExchange);
            

            panelMain.HorizontalScroll.Maximum = 0;
            panelMain.AutoScroll = false;
            panelMain.VerticalScroll.Visible = false;
            panelMain.AutoScroll = true;

            panelInvest.HorizontalScroll.Maximum = 0;
            panelInvest.AutoScroll = false;
            panelInvest.VerticalScroll.Visible = false;
            panelInvest.AutoScroll = true;
            panelInvest.Hide();
            panelInvest.BringToFront();

            tb_ticker.Text = StoreVariables.GetTickerList();
            this.Width = 1365;

            menuStrip1.Items[currentMenuStripItem].BackColor = themeColorB;
            menuStrip1.BackColor = themeColorA;

            _ = await getStockQuoteData();
            visualizeDataWL();
            panelMain.BringToFront();
        }
        #endregion

        //API + JSON String
        #region Recieve StockQuote Data (Web Request + Deserialization)
        public async Task<int> getStockQuoteData()
        {
            //source: https://www.yahoofinanceapi.com/dashboard

            try
            {
                //send request (enter ticker symbol in textbox)
                var httpClient = new HttpClient();
                var webRequest = new HttpRequestMessage(new HttpMethod("GET"), "https://yfapi.net/v6/finance/quote?region=DE&lang=DE&symbols=" + StoreVariables.GetTickerList());

                tb_ticker.Text = StoreVariables.GetTickerList();

                webRequest.Headers.TryAddWithoutValidation("accept", "application/json");
                webRequest.Headers.TryAddWithoutValidation("X-API-KEY", StoreVariables.apiKey);

                var webResponse = await httpClient.SendAsync(webRequest);
                webResponse.EnsureSuccessStatusCode();

                webDataStockQuote = await webResponse.Content.ReadAsStringAsync();
                tb_data.Text = webDataStockQuote;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return 1;
        }

        private static RootStockQuote DeserialzeStockQuote(string path)
        {
            //convert Json into Object
            return JsonConvert.DeserializeObject<RootStockQuote>(path);
        }

        #endregion

        #region Recieve Chart Data (Web Request + Deserialization)
        public async Task<int> getChartData(int i)
        {
            try
            {
                string webRequestString = "https://yfapi.net/v8/finance/chart/" + liSQWatch[i].symbol + "?range=" + range + "&region=DE&interval=" + interval + "&lang=en";

                var httpClient = new HttpClient();
                var webRequest = new HttpRequestMessage(new HttpMethod("GET"), webRequestString); //https://yfapi.net/v8/finance/chart/AAPL?comparisons=MSFT%2CFB%2C&range=6mo&region=US&interval=1d&lang=en

                webRequest.Headers.TryAddWithoutValidation("accept", "application/json");
                webRequest.Headers.TryAddWithoutValidation("X-API-KEY", StoreVariables.apiKey); 

                var webResponse = await httpClient.SendAsync(webRequest);
                webResponse.EnsureSuccessStatusCode();

                webDataChart = await webResponse.Content.ReadAsStringAsync();
                liC.Add(DeserialzeChart(webDataChart).chart.result[0]);

                //Prevent values like 0 in List
                for(int x = 0; x < liC.Count; x++)
                {
                    for(int y = 0; y < liC[x].indicators.quote[0].close.Count; y++)
                    {
                        if (liC[x].indicators.quote[0].close[y] == 0 && y != 0)
                        {
                            liC[x].indicators.quote[0].close[y] = liC[x].indicators.quote[0].close[y - 1];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return 1;
        }

        private static RootChart DeserialzeChart(string path)
        {
            path = path.Replace("null", "0");

            //convert Json into Object
            return JsonConvert.DeserializeObject<RootChart>(path, settings);
        }
        #endregion

        //Visualize Data
        #region Create Overview Table (Main)
        private void createWatchlistOverview()
        {
            for (int i = 0; i < liSQWatch.Count; i++)
            {
                setBackColor(i);

                for (int j = 0; j < 6; j++)
                {
                    overviewLabelsCreation(i, j);
                }

                overviewPictureBoxCreation(i, panelMain);
            }
        }

        private void setBackColor(int i)
        {
            //Set two different background colors
            if (i % 2 == 0)
            {
                elementColor = themeColorA;
            }
            else
            {
                elementColor = themeColorB;
            }
        }

        private void overviewPictureBoxCreation(int i, Panel p)
        {
            //Create PictureBox for each line as "background"
            PictureBox pb = new PictureBox();
            pb.Name = i.ToString();
            pb.Top = i * 50;
            pb.Height = 50;
            pb.Click += btn_ClickMoreInfo;
            pb.BackColor = elementColor;
            pb.Width = p.Width;
            p.Controls.Add(pb);
        }

        private void overviewLabelsCreation(int i, int j)
        {
            //Create Labels for Overview
            Label l = new Label();
            l.AutoSize = true;
            l.Top = i * 50 + 15;
            l.Font = new Font("Arial", 11, FontStyle.Bold);
            l.BackColor = elementColor;

            switch (j)
            {
                case 0:
                    l.Text = liSQWatch[i].symbol;
                    break;
                case 1:
                    l.Text = getStockName(i);
                    l.Left = 200;
                    break;
                case 2:
                    l.Text = setLabelStringPosOrNeg(liSQWatch[i].regularMarketChangePercent) + " %";
                    l.ForeColor = setLabelColorPosOrNeg(liSQWatch[i].regularMarketChangePercent);
                    l.TextAlign = ContentAlignment.MiddleRight;
                    l.AutoSize = false;
                    l.Width = 100;
                    l.Left = 600;
                    break;
                case 3:
                    l.Text = String.Format(decimalsFormat, liSQWatch[i].regularMarketPrice) + " " + liSQWatch[i].currency;
                    l.TextAlign = ContentAlignment.MiddleRight;
                    l.AutoSize = false;
                    l.Width = 150;
                    l.Left = 750;
                    break;
                case 4:
                    l.Text = liSQWatch[i].fullExchangeName;
                    l.Left = 1000;
                    break;
                case 5:
                    overviewButtonCreation(i);
                    break;
            }
            panelMain.Controls.Add(l);
        }

        private void overviewButtonCreation(int i)
        {
            Button b = new Button();
            b.Name = i.ToString();
            b.Text = "Show more";
            b.Left = 1200;
            b.Width = 100;
            b.Top = i * 50 + 15;
            b.Height = 22;
            b.FlatStyle = FlatStyle.System;
            b.FlatAppearance.BorderSize = 2;
            b.AutoSize = false;
            b.TextAlign = ContentAlignment.MiddleCenter;
            b.Font = new Font("Arial", 8, FontStyle.Bold);
            b.Click += btn_ClickMoreInfo;
            b.BackColor = elementColor;
            panelMain.Controls.Add(b);
        }

        private void visualizeDataWL()
        {
            panelMain.Controls.Clear();
            panelMain.Refresh();

            if (DeserialzeStockQuote(webDataStockQuote).quoteResponse != null)
            {
                liSQWatch = DeserialzeStockQuote(webDataStockQuote).quoteResponse.result;

                liSQWatch = liSQWatch.OrderBy(s => s.symbol).ToList();

                createWatchlistOverview();

                //Change Size of Panel
                panelMain.Height = panelHeightExtended;
                lastClickedBtn = "";
            }
            
        }
        #endregion

        #region Text + Chart Creation (Extra Info)
        private string getStockName(int i)
        {
            if (liSQWatch[i].longName == null)
            {
                return liSQWatch[i].shortName;
            }
            else
            {
                return liSQWatch[i].longName;
            }

        }

        private void moreInfoCreateLabel(string s, int x, int y, int fontSize, Color color)
        {
            Label l = new Label();
            l.AutoSize = true;
            l.Text = s;
            l.TextAlign = ContentAlignment.MiddleLeft;
            l.Left = x;
            l.Top = y;
            l.Font = new Font("Arial", fontSize, FontStyle.Bold);
            l.ForeColor = color;
            l.BringToFront();
            panelExtra.Controls.Add(l);
        }

        private void btn_ClickMoreInfo(object sender, EventArgs e)
        {
            string name = "";
            if (sender is Button)
            {
                name = ((Button)sender).Name;
            }
            else if (sender is PictureBox)
            {
                name = ((PictureBox)sender).Name;
            }

            if (lastClickedBtn.Equals(name))
            {
                //Change Size of Panel
                panelMain.Height = panelHeightExtended;
                lastClickedBtn = "";
            }
            else
            {
                panelMain.Height = panelHeightCropped;
                Button btn = sender as Button;
                int i = Int32.Parse(name);

                //show 2nd panel with further information

                panelExtra.Controls.Clear();

                moreInfoCreateLabel(getStockName(i) + " (" + liSQWatch[i].symbol + ")", 10, 10, 14, Color.Black);
                moreInfoCreateLabel(String.Format(decimalsFormat, liSQWatch[i].regularMarketPrice) + " " + liSQWatch[i].currency, 10, 40, 20, Color.Black);
                moreInfoCreateLabel(setLabelStringPosOrNeg(liSQWatch[i].regularMarketChange) + " (" + String.Format(decimalsFormat, liSQWatch[i].regularMarketChangePercent) + " %)", 10, 70, 11, setLabelColorPosOrNeg(liSQWatch[i].regularMarketChangePercent));

                moreInfoCreateLabel("Open", 10, 110, 11, Color.Black);
                moreInfoCreateLabel(String.Format(decimalsFormat, liSQWatch[i].regularMarketOpen), 100, 110, 11, Color.Black);

                moreInfoCreateLabel("High", 10, 140, 11, Color.Black);
                moreInfoCreateLabel(String.Format(decimalsFormat, liSQWatch[i].regularMarketDayHigh), 100, 140, 11, Color.Black);

                moreInfoCreateLabel("Low", 10, 170, 11, Color.Black);
                moreInfoCreateLabel(String.Format(decimalsFormat, liSQWatch[i].regularMarketDayLow), 100, 170, 11, Color.Black);

                moreInfoCreateLabel("MarketCap", 10, 230, 11, Color.Black);
                moreInfoCreateLabel(formatHugeNumbers(liSQWatch[i].marketCap), 100, 230, 11, Color.Black);

                moreInfoCreateLabel("P/E", 10, 260, 11, Color.Black);
                moreInfoCreateLabel(String.Format(decimalsFormat, liSQWatch[i].trailingPE), 100, 260, 11, Color.Black);

                moreInfoCreateLabel("Yield", 10, 290, 11, Color.Black);
                moreInfoCreateLabel(String.Format(decimalsFormat, liSQWatch[i].trailingAnnualDividendRate) + " (" + String.Format(decimalsFormat, liSQWatch[i].trailingAnnualDividendYield * 100) + "%)", 100, 290, 11, Color.Black);

                moreInfoCreateChart(i);
                lastClickedBtn = name;
            }
        }

        private async void moreInfoCreateChart(int i)
        {
            int chartListIndex = -1;

            while (chartListIndex == -1)
            {
                for (int x = 0; x < liC.Count; x++)
                { 

                    if (liC[x].meta.symbol.Equals(liSQWatch[i].symbol))
                    {
                        chartListIndex = x;
                        goto chartCreation; //break out of loop & skip new list entry
                    }
                }
                //Create new List Entry if Symbol doesn't exist
                Task t = getChartData(i);
                await t;
            }

        chartCreation:
            Chart c = new Chart();
            Series series = new Series();
            ChartArea chartArea = new ChartArea();
            
            //Convert Timestamp to dateTime
            List<DateTime> dateTime = new List<DateTime>();
            foreach (int o in liC[chartListIndex].timestamp)
            {
                dateTime.Add(DateTimeOffset.FromUnixTimeSeconds(o).DateTime);
            }

            series.Points.DataBindXY(dateTime, liC[chartListIndex].indicators.quote[0].close);

            chartArea.AxisY.LabelStyle.Format = decimalsFormat + " " + liSQWatch[chartListIndex].currency;

            series.ChartType = SeriesChartType.Line;

            c.Width = 681;
            c.Height = 354;
            c.Left = 650;
            c.Top = 0;
            c.Series.Clear();
            c.Series.Add(series);
            c.ChartAreas.Clear();
            c.ChartAreas.Add(chartArea);
            c.ChartAreas[0].Axes[0].MajorGrid.Enabled = false; //x axis
            c.ChartAreas[0].AxisY.Maximum = liC[chartListIndex].indicators.quote[0].high.Max();
            c.ChartAreas[0].AxisY.Minimum = liC[chartListIndex].indicators.quote[0].low.Min();
            panelExtra.Controls.Add(c);
        }
        #endregion

        #region Sort Data 
        private void sortDataButtonLayout()
        {
            foreach (Button b in libtn)
            {
                b.Text = b.Text.Replace("↑", "");
                b.Text = b.Text.Replace("↓", "");
            }
        }

        private void btn_sortSymbol_Click(object sender, EventArgs e)
        {
            sortDataButtonLayout();

            switch (sortSymbol)
            {
                case 0:
                    //Pfeil nach unten
                    liSQWatch = liSQWatch.OrderBy(s => s.symbol).ToList();
                    btn_sortSymbol.Text += "↓";
                    sortSymbol = 1;

                    break;
                case 1:
                    //Pfeil nach oben
                    liSQWatch = liSQWatch.OrderByDescending(s => s.symbol).ToList();
                    btn_sortSymbol.Text += "↑";
                    sortSymbol = 0;
                    break;
                case 2:
                    //ohne Pfeil
                    btn_sortSymbol.Text = btn_sortSymbol.Text.Replace("↑", "");
                    sortSymbol = 0;
                    break;
            }

            sortChange = 0;
            sortPrice = 0;
            sortExchange = 0;

            visualizeDataWL();
        }

        private void btn_sortChange_Click(object sender, EventArgs e)
        {
            sortDataButtonLayout();

            switch (sortChange)
            {
                case 0:
                    //Pfeil nach unten
                    liSQWatch = liSQWatch.OrderByDescending(s => s.regularMarketChangePercent).ToList();
                    btn_sortChange.Text += "↓";
                    sortChange = 1;

                    break;
                case 1:
                    //Pfeil nach oben
                    liSQWatch = liSQWatch.OrderBy(s => s.regularMarketChangePercent).ToList();
                    btn_sortChange.Text += "↑";
                    sortChange = 0;
                    break;
                case 2:
                    //ohne Pfeil
                    btn_sortChange.Text = btn_sortChange.Text.Replace("↑", "");
                    sortChange = 0;
                    break;
            }

            sortSymbol = 0;
            sortPrice = 0;
            sortExchange = 0;

            visualizeDataWL();
        }

        private void btn_sortPrice_Click(object sender, EventArgs e)
        {
            sortDataButtonLayout();

            switch (sortPrice)
            {
                case 0:
                    //Pfeil nach unten
                    liSQWatch = liSQWatch.OrderByDescending(s => s.regularMarketPrice).ToList();
                    btn_sortPrice.Text += "↓";
                    sortPrice = 1;

                    break;
                case 1:
                    //Pfeil nach oben
                    liSQWatch = liSQWatch.OrderBy(s => s.regularMarketPrice).ToList();
                    btn_sortPrice.Text += "↑";
                    sortPrice = 0;
                    break;
                case 2:
                    //ohne Pfeil
                    btn_sortPrice.Text = btn_sortPrice.Text.Replace("↑", "");
                    sortPrice = 0;
                    break;
            }
            sortSymbol = 0;
            sortChange = 0;
            sortExchange = 0;

            visualizeDataWL(); 
        }

        private void btn_sortExchange_Click(object sender, EventArgs e)
        {
            sortDataButtonLayout();

            switch (sortExchange)
            {
                case 0:
                    //Pfeil nach unten
                    liSQWatch = liSQWatch.OrderBy(s => s.exchange).ToList();
                    btn_sortExchange.Text += "↓";
                    sortExchange = 1;

                    break;
                case 1:
                    //Pfeil nach oben
                    liSQWatch = liSQWatch.OrderByDescending(s => s.exchange).ToList();
                    btn_sortExchange.Text += "↑";
                    sortExchange = 0;
                    break;
                case 2:
                    //ohne Pfeil
                    btn_sortExchange.Text = btn_sortExchange.Text.Replace("↑", "");
                    sortExchange = 0;
                    break;
            }
            sortSymbol = 0;
            sortChange = 0;
            sortPrice = 0;

            visualizeDataWL();
        }

        #endregion

        //Menu-Strip (Settings)
        #region Set Decimals (in Menu-Strip)
        private void decimalPlaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimalsFormat = "{0:#,##0.0}";
            createWatchlistOverview();
        }

        private void decimalPlacesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            decimalsFormat = "{0:#,##0.00}";
            createWatchlistOverview();
        }

        private void decimalPlacesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            decimalsFormat = "{0:#,##0.000}";
            createWatchlistOverview();
        }

        private void decimalPlacesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            decimalsFormat = "{0:#,##0.0000}";
            createWatchlistOverview();
        }
        #endregion

        #region Set Developer Mode (in Menu-Strip)
        private void developerModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (devMode)
            {
                tb_data.Visible = false;
                devMode = false;
                frm_watchlist.ActiveForm.Width = 1365;
            }
            else
            {
                tb_data.Visible = true;
                devMode = true;
                frm_watchlist.ActiveForm.Width = 1791;
            }
        }

        private void btn_showData_Click(object sender, EventArgs e)
        {
            visualizeDataWL();
        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            //start Task
            _ = getStockQuoteData();
        }

        private void sendNewHTTPRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ = getStockQuoteData();
        }
        #endregion

        #region Set Colors (in Menu-Strip)
        private void blueWhiteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            themeColorA = Color.LightSteelBlue;
            themeColorB = Color.White;

            changeMenuStripColor(0);

            createWatchlistOverview();
        }
        private void grayWhiteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            themeColorA = Color.LightGray;
            themeColorB = Color.White;

            changeMenuStripColor(0);

            createWatchlistOverview();
        }

        private void changeMenuStripColor(int i)
        {
            for(int x = 0; x < menuStrip1.Items.Count - 1; x++)
            {
                if(x == i)
                {
                    menuStrip1.Items[i].BackColor = themeColorB;
                    menuStrip1.BackColor = themeColorA;
                }
                else
                {
                    menuStrip1.Items[x].BackColor = themeColorA;
                }
            }
        }
        #endregion

        #region Format Positive Or Negative Numbers/Texts
        private Color setLabelColorPosOrNeg(double num)
        {
            Color c;

            if (num >= 0)
            {
                c = Color.Green;
            }
            else
            {
                c = Color.Red;
            }

            return c;
        }

        private string setLabelStringPosOrNeg(double num)
        {
            string s;

            if (num > 0)
            {
                s = " " + String.Format(decimalsFormat, num);

            }
            else
            {
                s = String.Format(decimalsFormat, num);
            }

            return s;
        }

        private string formatHugeNumbers(double num)
        {
            int i = 0;
            string[] arr = { "", "K", "M", "B", "T"};
            while (num >= 1000)
            {
                num = num / 1000;
                i++;
            }
            return String.Format(decimalsFormat, num) + arr[i];
        }

        #endregion

        #region Set Range (in Menu-Strip) SHOULDN'T BE AS FREELY CHOOSABLE 
        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liC.Clear();
            range = "1d";
        }

        private void dToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            liC.Clear();
            range = "5d";
        }

        private void moToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liC.Clear();
            range = "1mo";
        }

        private void moToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            liC.Clear();
            range = "3mo";
        }

        private void moToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            liC.Clear();
            range = "6mo";
        }

        private void yToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liC.Clear();
            range = "1y";
        }

        private void yToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            liC.Clear();
            range = "5y";
        }

        private void yToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            liC.Clear();
            range = "10y";
        }

        private void ytdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liC.Clear();
            range = "ytd";
        }

        private void maxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liC.Clear();
            range = "max";
        }
        #endregion  

        #region Set Interval (in Menu-Strip)
        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liC.Clear();
            interval = "1m";
        }

        private void mToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            liC.Clear();
            interval = "5m";
        }

        private void mToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            liC.Clear();
            interval = "15m";
        }

        private void dToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            liC.Clear();
            interval = "1d";
        }

        private void wkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liC.Clear();
            interval = "1wk";
        }

        private void moToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            liC.Clear();
            interval = "1mo";
        }
        #endregion

        #region Add/Remove Stocks (in Menu-Strip)
        private async void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_addStocks faS = new frm_addStocks();
            faS.ShowDialog();

            Task t = getStockQuoteData();
            await t;
            visualizeDataWL();
        }
        private async void removeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_removeStock frS = new frm_removeStock();
            frS.ShowDialog();

            Task t = getStockQuoteData();
            await t;

            visualizeDataWL();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeMenuStripColor(2);

            frm_profile profile = new frm_profile();
            profile.ShowDialog();
        }
        #endregion


        //Investment Tab (not finished!!!!)
        #region Investment Tab
        private void createInvestmentOverview()
        {
            panelInvest.Controls.Clear();
            panelInvest.Refresh();

            for (int i = 0; i < liSQInvest.Count; i++)
            {
                setBackColor(i);

                for (int j = 0; j < 6; j++)
                {
                    investLabelsCreation(i, j);
                }

                overviewPictureBoxCreation(i, panelInvest);
            }
        }

        private void visualizeDataIV()
        {
            liSQInvest = DeserialzeStockQuote(webDataStockQuote).quoteResponse.result;

            liSQInvest = liSQInvest.OrderBy(s => s.symbol).ToList();

            createInvestmentOverview();

            //Change Size of Panel
            panelInvest.Height = panelHeightExtended;
            lastClickedBtn = "";
        }

        private void investLabelsCreation(int i, int j)
        {
            //Create Labels for Overview
            Label l = new Label();
            l.AutoSize = true;
            l.Top = i * 50 + 15;
            l.Font = new Font("Arial", 11, FontStyle.Bold);
            l.BackColor = elementColor;

            switch (j)
            {
                case 0:
                    l.Text = liSQInvest[i].symbol;
                    break;
                case 1:
                    l.Text = getStockName(i);
                    l.Left = 150;
                    break;
                case 2:
                    l.Text = setLabelStringPosOrNeg(liSQInvest[i].regularMarketChangePercent) + " %";
                    l.ForeColor = setLabelColorPosOrNeg(liSQInvest[i].regularMarketChangePercent);
                    l.TextAlign = ContentAlignment.MiddleRight;
                    l.AutoSize = false;
                    l.Width = 100;
                    l.Left = 600;
                    break;
                case 3:
                    l.Text = String.Format(decimalsFormat, liSQInvest[i].regularMarketPrice) + " " + liSQInvest[i].currency;
                    l.TextAlign = ContentAlignment.MiddleRight;
                    l.AutoSize = false;
                    l.Width = 150;
                    l.Left = 750;
                    break;
                case 4:
                    l.Text = liSQInvest[i].fullExchangeName;
                    l.Left = 1000;
                    break;
                case 5:
                    overviewButtonCreation(i);
                    break;
            }
            panelInvest.Controls.Add(l);
        }



        private void ms_showInvestments_Click(object sender, EventArgs e)
        {
            panelInvest.Show();
            panelInvest.BringToFront();
            changeMenuStripColor(1);
            createInvestmentOverview();
        }

        private void ms_showWatchlist_Click(object sender, EventArgs e)
        {
            changeMenuStripColor(0);
            panelInvest.Hide();
        }

        private async void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task t = getStockQuoteData();
            await t;
            visualizeDataIV();
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
