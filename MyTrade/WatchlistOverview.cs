﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json;

namespace MyTrade
{
    public partial class frm_watchlist : Form
    {
        #region Variables
        static List<ResultStockQuote> liSQ = new List<ResultStockQuote>();
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
        
        Color elementColor = Color.White;
        Color themeColorA = Color.LightSteelBlue;
        Color themeColorB = Color.White;
        #endregion

        public frm_watchlist()
        {
            InitializeComponent();
        }

        private void WatchlistOverview_Load(object sender, EventArgs e)
        {
            libtn.Add(btn_sortSymbol);
            libtn.Add(btn_sortChange);
            libtn.Add(btn_sortPrice);
            libtn.Add(btn_sortExchange);

            visualizeData();
            panelMain.BringToFront();

            panelMain.HorizontalScroll.Maximum = 0;
            panelMain.AutoScroll = false;
            panelMain.VerticalScroll.Visible = false;
            panelMain.AutoScroll = true;
        }

        #region Recieve StockQuote Data (Web Request + Deserialization)
        public async Task<int> getStockQuoteData()
        {
            //source: https://www.yahoofinanceapi.com/dashboard

            try
            {
                //send request (enter ticker symbol in textbox)
                var httpClient = new HttpClient();
                var webRequest = new HttpRequestMessage(new HttpMethod("GET"), "https://yfapi.net/v6/finance/quote?region=DE&lang=DE&symbols=" + tb_ticker.Text);

                webRequest.Headers.TryAddWithoutValidation("accept", "application/json");
                webRequest.Headers.TryAddWithoutValidation("X-API-KEY", "WinGU8zX1G5jdbAl0dNhu3i7ipf2hmMfgP1ST4zg");
                //niYF94oEjJ7G6Ifo09pco3l57iO5tR070JE9SRY3
                //2nd API-Key if necessary

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

        private void btn_data_Click(object sender, EventArgs e)
        {
            //start Task
            _ = getStockQuoteData();
        }

        private static RootStockQuote DeserialzeStockQuote(string path)
        {
            //convert Json into Object
            return JsonConvert.DeserializeObject<RootStockQuote>(path);
        }

        #endregion

        #region Developer Info (in Textboxes)
        private void btn_showData_Click(object sender, EventArgs e)
        {
            visualizeData();
        }

        private void visualizeData()
        {
            //just temporary -debug purposes only
            tb_listOutput.Text = "";
            webDataStockQuote = tb_data.Text;

            //output list entries
            foreach (var v in liSQ)
            {
                foreach (var propertyInfo in v.GetType().GetProperties())
                {
                    tb_listOutput.Text += propertyInfo.Name + ", " + propertyInfo.GetValue(v, null) + Environment.NewLine;
                }
                tb_listOutput.Text += Environment.NewLine;
                tb_listOutput.Text += Environment.NewLine;
            }

            liSQ = DeserialzeStockQuote(webDataStockQuote).quoteResponse.result;
            liSQ = liSQ.OrderBy(s => s.symbol).ToList();

            createWatchlistOverview();
        }
        #endregion

        #region Text + Chart Creation (Extra Info)
        private string getStockName(int i)
        {
            if (liSQ[i].longName == null)
            {
                return liSQ[i].shortName;
            }
            else
            {
                return liSQ[i].longName;
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

            #region Chart
            Chart c = new Chart();
            Series series = new Series();
            series.Points.DataBindXY(new[] { 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009 }, new[] { 900, 100, 800, 1000, 400, 500, 300, 800, 600, 750 });
            series.ChartType = SeriesChartType.Line;

            c.Width = 681;
            c.Height = 354;
            c.Left = 650;
            c.Top = 0;
            c.Series.Clear();
            c.Series.Add(series);
            
            //c.Series.RemoveAt(0);
            //chart.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;//x axis
            //c.ChartAreas[0].Axes[0].Minimum = 2000;
            //c.ChartAreas[0].Axes[0].Maximum = 2009;
            //c.ChartAreas[0].Axes[1].Minimum = 50;
            //c.ChartAreas[0].Axes[1].Maximum = 1000;
            //c.Legends[0].Enabled = false;
            //c.Invalidate();

            panelExtra.Controls.Add(c);
            #endregion
        }

        private void moreInfoCreateChart()
        {
            //Define Chart Bounds
            Chart c = new Chart();
            c.Left = 650;
            c.Top = 0;
            c.Width = 681;
            c.Height = 354;

            //Define Chart Area
            ChartArea chartArea = new ChartArea();
            chartArea.Axes[0].MajorGrid.Enabled = false;
            chartArea.Axes[0].Minimum = 2000;
            chartArea.Axes[0].Maximum = 2009;
            chartArea.Axes[1].Minimum = 50;
            chartArea.Axes[1].Maximum = 1000;

            c.ChartAreas.Add(chartArea);

            //Define Series
            Series series = new Series("");
            series.ChartType = SeriesChartType.Line;
            series.Points.DataBindXY(new[] { 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009 }, new[] { 900, 100, 800, 1000, 400, 500, 300, 800, 600, 750 });

            c.Series.Add(series);

            //c.Legends[0].Enabled = false;
            panelExtra.Controls.Add(c);
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
                panelMain.Height = 745;
                lastClickedBtn = "";
            }
            else
            {
                panelMain.Height = 377;
                Button btn = sender as Button;
                int i = Int32.Parse(name);

                //show 2nd panel with further information

                panelExtra.Controls.Clear();

                moreInfoCreateLabel(getStockName(i) + " (" + liSQ[i].symbol + ")", 10, 10, 14, Color.Black);
                moreInfoCreateLabel(String.Format(decimalsFormat, liSQ[i].regularMarketPrice) + " " + liSQ[i].currency, 10, 40, 20, Color.Black);
                moreInfoCreateLabel(setLabelStringPosOrNeg(liSQ[i].regularMarketChange) + " (" + String.Format(decimalsFormat, liSQ[i].regularMarketChangePercent) + " %)", 10, 70, 11, setLabelColorPosOrNeg(liSQ[i].regularMarketChangePercent));

                moreInfoCreateLabel("Open", 10, 110, 11, Color.Black);
                moreInfoCreateLabel(String.Format(decimalsFormat, liSQ[i].regularMarketOpen) + " " + liSQ[i].currency, 100, 110, 11, Color.Black);

                moreInfoCreateLabel("High", 10, 140, 11, Color.Black);
                moreInfoCreateLabel(String.Format(decimalsFormat, liSQ[i].regularMarketDayHigh) + " " + liSQ[i].currency, 100, 140, 11, Color.Black);

                moreInfoCreateLabel("Low", 10, 170, 11, Color.Black);
                moreInfoCreateLabel(String.Format(decimalsFormat, liSQ[i].regularMarketDayLow) + " " + liSQ[i].currency, 100, 170, 11, Color.Black);

                moreInfoCreateChart();
                lastClickedBtn = name;
            }
        }
        #endregion

        #region Create Overview Table (Main)
        private void createWatchlistOverview()
        {
            panelMain.Controls.Clear();
            panelMain.Refresh();

            for (int i = 0; i < liSQ.Count; i++)
            {
                setBackColor(i);

                for (int j = 0; j < 6; j++)
                {
                    overviewLabelsCreation(i, j);
                }

                overviewPictureBoxCreation(i);
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

        private void overviewPictureBoxCreation(int i)
        {
            //Create PictureBox for each line as "background"
            PictureBox pb = new PictureBox();
            pb.Name = i.ToString();
            pb.Top = i * 50;
            pb.Height = 50;
            pb.Click += btn_ClickMoreInfo;
            pb.BackColor = elementColor;
            pb.Width = panelMain.Width;
            panelMain.Controls.Add(pb);
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
                    l.Text = liSQ[i].symbol;
                    break;
                case 1:
                    l.Text = getStockName(i);
                    l.Left = 200;
                    break;
                case 2:
                    l.Text = setLabelStringPosOrNeg(liSQ[i].regularMarketChangePercent) + " %";
                    l.ForeColor = setLabelColorPosOrNeg(liSQ[i].regularMarketChangePercent);
                    l.TextAlign = ContentAlignment.MiddleRight;
                    l.AutoSize = false;
                    l.Width = 100;
                    l.Left = 600;
                    break;
                case 3:
                    l.Text = String.Format(decimalsFormat, liSQ[i].regularMarketPrice) + " " + liSQ[i].currency;
                    l.TextAlign = ContentAlignment.MiddleRight;
                    l.AutoSize = false;
                    l.Width = 150;
                    l.Left = 750;
                    break;
                case 4:
                    l.Text = liSQ[i].fullExchangeName;
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
                    liSQ = liSQ.OrderBy(s => s.symbol).ToList();
                    btn_sortSymbol.Text += "↓";
                    sortSymbol = 1;

                    break;
                case 1:
                    //Pfeil nach oben
                    liSQ = liSQ.OrderByDescending(s => s.symbol).ToList();
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

            createWatchlistOverview();
        }

        private void btn_sortChange_Click(object sender, EventArgs e)
        {
            sortDataButtonLayout();

            switch (sortChange)
            {
                case 0:
                    //Pfeil nach unten
                    liSQ = liSQ.OrderByDescending(s => s.regularMarketChangePercent).ToList();
                    btn_sortChange.Text += "↓";
                    sortChange = 1;

                    break;
                case 1:
                    //Pfeil nach oben
                    liSQ = liSQ.OrderBy(s => s.regularMarketChangePercent).ToList();
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

            createWatchlistOverview();
        }

        private void btn_sortPrice_Click(object sender, EventArgs e)
        {
            sortDataButtonLayout();

            switch (sortPrice)
            {
                case 0:
                    //Pfeil nach unten
                    liSQ = liSQ.OrderByDescending(s => s.regularMarketPrice).ToList();
                    btn_sortPrice.Text += "↓";
                    sortPrice = 1;

                    break;
                case 1:
                    //Pfeil nach oben
                    liSQ = liSQ.OrderBy(s => s.regularMarketPrice).ToList();
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

            createWatchlistOverview();
        }

        private void btn_sortExchange_Click(object sender, EventArgs e)
        {
            sortDataButtonLayout();

            switch (sortExchange)
            {
                case 0:
                    //Pfeil nach unten
                    liSQ = liSQ.OrderBy(s => s.exchange).ToList();
                    btn_sortExchange.Text += "↓";
                    sortExchange = 1;

                    break;
                case 1:
                    //Pfeil nach oben
                    liSQ = liSQ.OrderByDescending(s => s.exchange).ToList();
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

            createWatchlistOverview();
        }

        #endregion

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
                tb_listOutput.Visible = false;
                devMode = false;
                frm_watchlist.ActiveForm.Width = 1365;
                frm_watchlist.ActiveForm.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                tb_data.Visible = true;
                tb_listOutput.Visible = true;
                tb_data.BringToFront();
                tb_listOutput.BringToFront();
                devMode = true;
                frm_watchlist.ActiveForm.Width = 1791;
                frm_watchlist.ActiveForm.StartPosition = FormStartPosition.CenterScreen;
            }
        }
        #endregion

        #region Set Colors (in Menu-Strip)
        private void blueWhiteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            themeColorA = Color.LightSteelBlue;
            themeColorB = Color.White;
            createWatchlistOverview();
        }
        private void grayWhiteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            themeColorA = Color.LightGray;
            themeColorB = Color.White;
            createWatchlistOverview();
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


        #endregion

        #region Recieve Chart Data (Web Request + Deserialization)
        private void button1_Click(object sender, EventArgs e)
        {
            _ = getChartData();
        }

        public async Task<int> getChartData()
        {
            try
            {
                var httpClient = new HttpClient();
                var webRequest = new HttpRequestMessage(new HttpMethod("GET"), "https://yfapi.net/v8/finance/chart/AAPL?comparisons=MSFT%2CFB%2C&range=6mo&region=US&interval=1d&lang=en");

                webRequest.Headers.TryAddWithoutValidation("accept", "application/json");
                webRequest.Headers.TryAddWithoutValidation("X-API-KEY", "WinGU8zX1G5jdbAl0dNhu3i7ipf2hmMfgP1ST4zg");
                //niYF94oEjJ7G6Ifo09pco3l57iO5tR070JE9SRY3
                //2nd API-Key if necessary (Stefans Key)

                var webResponse = await httpClient.SendAsync(webRequest);
                webResponse.EnsureSuccessStatusCode();

                webDataChart = await webResponse.Content.ReadAsStringAsync();
                liC = DeserialzeChart(webDataChart).chart.result;
                Geheimnis();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return 1;
        }

        private static RootChart DeserialzeChart(string path)
        {
            //convert Json into Object
            return JsonConvert.DeserializeObject<RootChart>(path);
        }

        private static void Geheimnis()
        {
            MessageBox.Show(liC[0].comparisons[0].symbol);
            MessageBox.Show(liC[0].comparisons[1].symbol);
        }
        #endregion

    }
}
