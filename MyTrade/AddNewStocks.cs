using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTrade
{
    public partial class frm_addStocks : Form
    {
        static List<ResultSearch> liS = new List<ResultSearch>();
        string webDataSearch;
        public frm_addStocks()
        {
            InitializeComponent();
        }

        private void AddNewStocks_Load(object sender, EventArgs e)
        {


            tb_addSearch.Clear();
            tb_addSymbol.Clear();
        }

        private void btn_addSymbol_Click(object sender, EventArgs e)
        {
            storeVariables.stockName = tb_addSymbol.Text;
            tb_addSearch.Clear();
            tb_addSymbol.Clear();
        }

        private async Task getSearchData() //https://yfapi.net/v6/finance/autocomplete?region=US&lang=en&query=apple
        {
            cb_searchResult.Items.Clear();
            string webRequestString = "https://yfapi.net/v6/finance/autocomplete?region=US&lang=en&query=" + tb_addSearch.Text;

            var httpClient = new HttpClient();
            var webRequest = new HttpRequestMessage(new HttpMethod("GET"), webRequestString);

            webRequest.Headers.TryAddWithoutValidation("accept", "application/json");
            webRequest.Headers.TryAddWithoutValidation("X-API-KEY", storeVariables.apiKey);

            var webResponse = await httpClient.SendAsync(webRequest);
            webResponse.EnsureSuccessStatusCode();

            webDataSearch = await webResponse.Content.ReadAsStringAsync();
            
            for (int i = 0; i < DeserialzeSearch(webDataSearch).ResultSet.Result.Count; i++)
            {
                liS.Add(DeserialzeSearch(webDataSearch).ResultSet.Result[i]);
            }

            foreach(ResultSearch s in liS)
            {
                cb_searchResult.Items.Add(s.name);
            }
            liS.Clear();
        }

        private void btn_addSearch_Click(object sender, EventArgs e)
        {
            _ = getSearchData();
        }

        private static RootSearch DeserialzeSearch(string path)
        {
            //convert Json into Object
            return JsonConvert.DeserializeObject<RootSearch>(path);
        }
    }
}
