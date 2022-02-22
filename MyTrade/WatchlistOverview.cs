using System;
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
        Root qr = new Root();
        static List<Result> li = new List<Result>();
        static List<Button> libtn = new List<Button>();
        string webData = "";

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

        #region Recieve Stock Data (Web Request + Deserialization)
        public async Task<int> getStockData()
        {
            //source:
            //https://www.yahoofinanceapi.com/dashboard

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

                webData = await webResponse.Content.ReadAsStringAsync();

                tb_data.Text = webData;
                
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
            _ = getStockData();
        }

        private static Root Deserialze(string path)
        {
            //convert Json into Object
            return JsonConvert.DeserializeObject<Root>(path);
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
            webData = tb_data.Text;

            //output list entries
            foreach (var v in li)
            {
                foreach (var propertyInfo in v.GetType().GetProperties())
                {
                    tb_listOutput.Text += propertyInfo.Name + ", " + propertyInfo.GetValue(v, null) + Environment.NewLine;
                }
                tb_listOutput.Text += Environment.NewLine;
                tb_listOutput.Text += Environment.NewLine;
            }

            li = Deserialze(webData).quoteResponse.result;
            li = li.OrderBy(s => s.symbol).ToList();

            createWatchlistOverview();
        }
        #endregion

        #region Text + Chart Creation (Extra Info)
        private string getStockName(int i)
        {
            if (li[i].longName == null)
            {
                return li[i].shortName;
            }
            else
            {
                return li[i].longName;
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

                moreInfoCreateLabel(getStockName(i) + " (" + li[i].symbol + ")", 10, 10, 14, Color.Black);
                moreInfoCreateLabel(String.Format(decimalsFormat, li[i].regularMarketPrice) + " " + li[i].currency, 10, 40, 20, Color.Black);
                moreInfoCreateLabel(setLabelStringPosOrNeg(li[i].regularMarketChange) + " (" + String.Format(decimalsFormat, li[i].regularMarketChangePercent) + " %)", 10, 70, 11, setLabelColorPosOrNeg(li[i].regularMarketChangePercent));

                moreInfoCreateLabel("Open", 10, 110, 11, Color.Black);
                moreInfoCreateLabel(String.Format(decimalsFormat, li[i].regularMarketOpen) + " " + li[i].currency, 100, 110, 11, Color.Black);

                moreInfoCreateLabel("High", 10, 140, 11, Color.Black);
                moreInfoCreateLabel(String.Format(decimalsFormat, li[i].regularMarketDayHigh) + " " + li[i].currency, 100, 140, 11, Color.Black);

                moreInfoCreateLabel("Low", 10, 170, 11, Color.Black);
                moreInfoCreateLabel(String.Format(decimalsFormat, li[i].regularMarketDayLow) + " " + li[i].currency, 100, 170, 11, Color.Black);

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

            for (int i = 0; i < li.Count; i++)
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
                    l.Text = li[i].symbol;
                    break;
                case 1:
                    l.Text = getStockName(i);
                    l.Left = 200;
                    break;
                case 2:
                    l.Text = setLabelStringPosOrNeg(li[i].regularMarketChangePercent) + " %";
                    l.ForeColor = setLabelColorPosOrNeg(li[i].regularMarketChangePercent);
                    l.TextAlign = ContentAlignment.MiddleRight;
                    l.AutoSize = false;
                    l.Width = 100;
                    l.Left = 600;
                    break;
                case 3:
                    l.Text = String.Format(decimalsFormat, li[i].regularMarketPrice) + " " + li[i].currency;
                    l.TextAlign = ContentAlignment.MiddleRight;
                    l.AutoSize = false;
                    l.Width = 150;
                    l.Left = 750;
                    break;
                case 4:
                    l.Text = li[i].fullExchangeName;
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
                    li = li.OrderBy(s => s.symbol).ToList();
                    btn_sortSymbol.Text += "↓";
                    sortSymbol = 1;

                    break;
                case 1:
                    //Pfeil nach oben
                    li = li.OrderByDescending(s => s.symbol).ToList();
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
                    li = li.OrderByDescending(s => s.regularMarketChangePercent).ToList();
                    btn_sortChange.Text += "↓";
                    sortChange = 1;

                    break;
                case 1:
                    //Pfeil nach oben
                    li = li.OrderBy(s => s.regularMarketChangePercent).ToList();
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
                    li = li.OrderByDescending(s => s.regularMarketPrice).ToList();
                    btn_sortPrice.Text += "↓";
                    sortPrice = 1;

                    break;
                case 1:
                    //Pfeil nach oben
                    li = li.OrderBy(s => s.regularMarketPrice).ToList();
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
                    li = li.OrderBy(s => s.exchange).ToList();
                    btn_sortExchange.Text += "↓";
                    sortExchange = 1;

                    break;
                case 1:
                    //Pfeil nach oben
                    li = li.OrderByDescending(s => s.exchange).ToList();
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
        private void blueWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themeColorA = Color.LightSteelBlue;
            themeColorB = Color.White;
            createWatchlistOverview();
        }

        private void grayWhiteToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}

