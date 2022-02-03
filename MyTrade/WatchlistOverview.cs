using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MyTrade
{
    public partial class frm_watchlist : Form
    {
        #region Variables
        Root qr = new Root();
        static List<Result> li = new List<Result>();
        static List<Button> libtn = new List<Button>();
        string webData;

        byte sortSymbol;
        byte sortChange;
        byte sortPrice;
        byte sortExchange;

        string decimalsFormat = "{0:0.00}";
        bool devMode = false;
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
        }

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

                var temp = await webResponse.Content.ReadAsStringAsync();

                webData = temp.ToString();
                tb_data.Text = webData;
                


                //show data in textbox
                //tb_data.Text = webData;
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
            var i = getStockData();
        }

        private static Root Deserialze(string path)
        {
            //convert Json into Object
            return JsonConvert.DeserializeObject<Root>(path);
        }

        private void btn_showData_Click(object sender, EventArgs e)
        {
            visualizeData();
        }

        private void visualizeData()
        {
            tb_listOutput.Text = "";

            //just temporary - debug purposes only
            webData = tb_data.Text;

            qr = Deserialze(webData);

            li = qr.quoteResponse.result;

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
            li = li.OrderBy(s => s.symbol).ToList();
            createWatchlistOverview();
        }

        static void btn_ClickMoreInfo(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Text);

            //show 2nd panel with further information
        }

        private  void createWatchlistOverview()
        {
            panel.Controls.Clear();
            panel.Refresh();

            for (int i = 0; i < li.Count; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Label l = new Label();

                    switch (j)
                    {
                        case 0:
                            l.Text = li[i].symbol;
                            break;
                        case 1:
                            if (li[i].longName == null)
                            {
                                l.Text = li[i].shortName;
                            }
                            else
                            {
                                l.Text = li[i].longName;
                            }

                            l.Left = 200;
                            break;
                        case 2:
                            
                            //double changePercent = Math.Round(li[i].regularMarketChangePercent, 2);
                            double changePercent = li[i].regularMarketChangePercent;
                            if (changePercent > 0)
                            {
                                l.Text = " " + String.Format(decimalsFormat, changePercent) + " %";
                                l.ForeColor = Color.Green;
                            }
                            else
                            {
                                l.Text = String.Format(decimalsFormat, changePercent) + " %";
                                l.ForeColor = Color.Red;
                            }

                            l.Left = 500;
                            break;
                        case 3:
                            l.Text = String.Format(decimalsFormat, li[i].regularMarketPrice) + " " + li[i].currency;
                            l.Left = 700;
                            break;
                        case 4:
                            l.Text = li[i].exchange;
                            l.Left = 900;
                            break;
                        case 5:
                            Button b = new Button();
                            b.Text = li[i].symbol;
                            b.Name = "btn_" + i;
                            b.Left = 1000;
                            b.Top = i * 50;
                            b.AutoSize = true;
                            b.Font = new Font("Arial", 15, FontStyle.Bold);
                            
                            panel.Controls.Add(b);
                            b.Click += btn_ClickMoreInfo;
                            break;
                    }

                    l.Top = i * 50;
                    l.AutoSize = true;
                    l.Font = new Font("Arial", 15, FontStyle.Bold);
                    panel.Controls.Add(l);
                }
            }
        }

        #region sort Data
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

            sortChange =0;
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

        private void decimalPlaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimalsFormat = "{0:0.0}";
            createWatchlistOverview();
        }

        private void decimalPlacesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            decimalsFormat = "{0:0.00}";
            createWatchlistOverview();
        }

        private void decimalPlacesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            decimalsFormat = "{0:0.000}";
            createWatchlistOverview();
        }

        private void decimalPlacesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            decimalsFormat = "{0:0.0000}";
            createWatchlistOverview();
        }

        private void developerModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (devMode)
            {
                tb_data.Visible = false;
                tb_listOutput.Visible = false;
                devMode = false;
            }
            else
            {
                tb_data.Visible = true;
                tb_listOutput.Visible = true;
                tb_data.BringToFront();
                tb_listOutput.BringToFront();
                devMode = true;
            }
        }
    }
}

