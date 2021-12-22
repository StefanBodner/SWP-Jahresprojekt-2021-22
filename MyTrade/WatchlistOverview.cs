﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MyTrade
{
    public partial class frm_watchlist : Form
    {
        #region Variables
        List<StockQuote> li = new List<StockQuote>();
        #endregion

        public frm_watchlist()
        {
            InitializeComponent();
        }

        private void WatchlistOverview_Load(object sender, EventArgs e)
        {

        }

        public async Task<int> getStockData()
        {
            //https://www.yahoofinanceapi.com/dashboard


            try
            {
                var httpClient = new HttpClient();
                //var webRequest = new HttpRequestMessage(new HttpMethod("GET"), "https://yfapi.net/v6/finance/quote?region=DE&lang=DE&symbols=" + tb_ticker.Text + ",TSLA");
                var webRequest = new HttpRequestMessage(new HttpMethod("GET"), "https://yfapi.net/v6/finance/quote?region=DE&lang=DE&symbols=" + tb_ticker.Text);

                webRequest.Headers.TryAddWithoutValidation("accept", "application/json");
                webRequest.Headers.TryAddWithoutValidation("X-API-KEY", "WinGU8zX1G5jdbAl0dNhu3i7ipf2hmMfgP1ST4zg");
                //niYF94oEjJ7G6Ifo09pco3l57iO5tR070JE9SRY3

                var webResponse = await httpClient.SendAsync(webRequest);

                webResponse.EnsureSuccessStatusCode();

                var webData = await webResponse.Content.ReadAsStringAsync();

                string[] splittedWebData = webData.Split(',');

                tb_data.Clear();

                foreach (string s in splittedWebData)
                {
                    tb_data.Text += s + Environment.NewLine;
                }

                //tb_data.Text = webData;
            }
            catch (Exception e)
            {
                tb_data.Text += "Failed to get symbol: " + "AAPL";
            }
            return 1;
        }


        private void btn_data_Click(object sender, EventArgs e)
        {
            var i = getStockData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_output.Clear();

            string tempStr = tb_data.Text;

            tempStr = tempStr.Replace(",\"", ";");
            tempStr = tempStr.Replace("\"", "");
            tempStr = tempStr.Replace("[", "");
            tempStr = tempStr.Replace("]", "");
            tempStr = tempStr.Replace("},", "");
            tempStr = tempStr.Replace("{", "");
            tempStr = tempStr.Replace("}", "");
            string[] tempArr = tempStr.Split(new[] { ';', '{', ':' }, StringSplitOptions.RemoveEmptyEntries);

            for (var s = 2; s < tempArr.Length; s++)
            {
                tb_output.Text += tempArr[s].ToString() + Environment.NewLine;
            }

            StockQuote st = new StockQuote();

            li.Add(new StockQuote());
        }
    }
}





