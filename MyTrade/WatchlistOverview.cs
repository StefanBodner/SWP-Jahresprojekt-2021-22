using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MyTrade
{
    public partial class frm_watchlist : Form
    {
        #region Variables
        Root qr = new Root();
        List<Result> li = new List<Result>();
        string webData;
        #endregion

        public frm_watchlist()
        {
            InitializeComponent();
        }

        private void WatchlistOverview_Load(object sender, EventArgs e)
        {
            //so far empty
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

                //show data in textbox
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
            var i = getStockData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_listOutput.Clear();

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
        }

        private static Root Deserialze(string path)
        {
            //convert Json into Object
            return JsonConvert.DeserializeObject<Root>(path);
        }
    }
}

