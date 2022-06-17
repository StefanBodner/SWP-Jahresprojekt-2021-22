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
        public frm_addStocks()
        {
            InitializeComponent();
        }

        private void AddNewStocks_Load(object sender, EventArgs e)
        {
            tb_addSearch.Clear();
            cb_language.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_language.SelectedIndex = 0;
        }

        private async Task getSearchData() // https://yfapi.net/v6/finance/autocomplete?region=us&lang=es&query=AMAZON
        {
            if(tb_addSearch.Text != "")
            {
                lb_searchResult.Items.Clear();
                string webRequestString = "https://yfapi.net/v6/finance/autocomplete?region=US&lang=" + cb_language.SelectedItem + "&query=" + tb_addSearch.Text;

                var httpClient = new HttpClient();
                var webRequest = new HttpRequestMessage(new HttpMethod("GET"), webRequestString);

                webRequest.Headers.TryAddWithoutValidation("accept", "application/json");
                webRequest.Headers.TryAddWithoutValidation("X-API-KEY", StoreVariables.apiKey);

                var webResponse = await httpClient.SendAsync(webRequest);
                webResponse.EnsureSuccessStatusCode();

                string webDataSearch = await webResponse.Content.ReadAsStringAsync();

                for (int i = 0; i < DeserialzeSearch(webDataSearch).ResultSet.Result.Count; i++)
                {
                    liS.Add(DeserialzeSearch(webDataSearch).ResultSet.Result[i]);
                }

                foreach (ResultSearch s in liS)
                {
                    lb_searchResult.Items.Add(s.symbol + " - " + s.name + " (" + s.exchDisp + ")");
                }
            }
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

        private void btn_addSymbol_Click(object sender, EventArgs e)
        {
            if (lb_searchResult.SelectedIndex == 0)
            {
                StoreVariables.tickerWL.Add(liS[lb_searchResult.SelectedIndex].symbol);
                SQLInteraction.CMDExecuteNonQuery("INSERT INTO myTrade_UserWL VALUES ('" + SQLInteraction.GetUID() + "', '" + liS[lb_searchResult.SelectedIndex].symbol + "')");
                tb_addSearch.Clear();
                lb_searchResult.Items.Clear();
                lb_searchResult.Text = "";
                liS.Clear(); 
            }
        }
    }
}
