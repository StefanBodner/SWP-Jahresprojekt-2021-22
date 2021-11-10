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
using YahooFinanceApi;
using YahooFinanceClient;


namespace MyTrade
{
    public partial class frm_main : Form
    {
        #region Variables
        string ticker = "";
        
        #endregion

        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            var i = getStockData();
        }

        public async Task<int> getStockData()
        {
            //https://www.yahoofinanceapi.com/dashboard


            try
            {
                var httpClient = new HttpClient();
                var webRequest = new HttpRequestMessage(new HttpMethod("GET"), "https://yfapi.net/v6/finance/quote?region=DE&lang=DE&symbols=" + tb_ticker.Text + ",TSLA");

                webRequest.Headers.TryAddWithoutValidation("accept", "application/json");
                webRequest.Headers.TryAddWithoutValidation("X-API-KEY", "WinGU8zX1G5jdbAl0dNhu3i7ipf2hmMfgP1ST4zg");

                var webResponse = await httpClient.SendAsync(webRequest);

                webResponse.EnsureSuccessStatusCode();

                var webData = await webResponse.Content.ReadAsStringAsync();
                tb_data.Text = webData;
            }
            catch (Exception e)
            {
                tb_data.Text += "Failed to get symbol: " + "AAPL";
            }
            return 1;
        }
    }
}
