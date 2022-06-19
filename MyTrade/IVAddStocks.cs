using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MyTrade
{
    public partial class frm_IvAddStocks : Form
    {
        static List<ResultSearch> liS = new List<ResultSearch>();

        public frm_IvAddStocks()
        {
            InitializeComponent();
        }

        private void frm_IvAddStocks_Load(object sender, EventArgs e)
        {
            lb_searchResult.Items.Clear();
            liS.Clear();
            tb_addSearch.Clear();
            cb_language.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_language.SelectedIndex = 0;
        }

        private async Task getSearchData() // https://yfapi.net/v6/finance/autocomplete?region=us&lang=es&query=AMAZON
        {
            if (tb_addSearch.Text != "")
            {
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
        private static RootSearch DeserialzeSearch(string path)
        {
            //convert Json into Object
            return JsonConvert.DeserializeObject<RootSearch>(path);
        }

        private void btn_addSearch_Click(object sender, EventArgs e)
        {
            _ = getSearchData();
            lb_searchResult.Items.Clear();
            liS.Clear();
        }

        private void btn_selectSymbol_Click(object sender, EventArgs e)
        {
            if (lb_searchResult.SelectedIndex >= 0)
            {
                this.Height = 552;
                tb_selectedStock.Text = liS[lb_searchResult.SelectedIndex].symbol;
            }
        }

        private void btn_addStock_Click(object sender, EventArgs e)
        {
            if(tb_selectedStock.Text.Equals("") && tb_amount.Text.Equals("") && tb_avgPrice.Text.Equals(""))
            {
                MessageBox.Show("Please enter values!");
                return;
            }

            double valueAmount;
            if (!double.TryParse(tb_amount.Text.Replace('.', ','), NumberStyles.Any, CultureInfo.CurrentCulture, out valueAmount) || valueAmount < 0)
            {
                MessageBox.Show("Please enter a valid amount! (e.g. 10,60)");
                return;
            }

            double valueAvgPrice;
            if (!double.TryParse(tb_avgPrice.Text.Replace('.', ','), NumberStyles.Any, CultureInfo.CurrentCulture, out valueAvgPrice) || valueAvgPrice < 0)
            {
                MessageBox.Show("Please enter a valid price! (e.g. 10,50)");
                return;
            }

            double valueFees;
            if (!double.TryParse(tb_fees.Text.Replace('.', ','), NumberStyles.Any, CultureInfo.CurrentCulture, out valueFees) || valueFees < 0)
            {
                if (tb_fees.Text.Equals(""))
                {
                    valueFees = 0;
                }
                else
                {
                    MessageBox.Show("Please enter valid fees! (e.g. 10,30)");
                    return;
                }
            }
            if(!SQLInteraction.CMDExecuteScalar("SELECT ticker FROM myTrade_UserIV WHERE ticker = '" + tb_selectedStock.Text + "';").Equals(""))
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Update your Information?", tb_selectedStock.Text + " is already in your Portfolio!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SQLInteraction.CMDExecuteNonQuery("UPDATE myTrade_UserIV SET amount='" + valueAmount.ToString().Replace(',', '.') + "',avgPrice='" + valueAvgPrice.ToString().Replace(',', '.') + "',fees='" + valueFees.ToString().Replace(',', '.') + "' WHERE UID = '"+SQLInteraction.GetUID()+"' AND ticker = '"+ tb_selectedStock.Text + "';");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                SQLInteraction.CMDExecuteNonQuery("INSERT INTO myTrade_UserIV(UID, ticker, amount, avgPrice, fees) VALUES ('" + SQLInteraction.GetUID() + "','" + tb_selectedStock.Text + "','" + valueAmount.ToString().Replace(',', '.') + "','" + valueAvgPrice.ToString().Replace(',', '.') + "','" + valueFees.ToString().Replace(',', '.') + "');");
            }
            SQLInteraction.FillIVList();
            this.Close();
        }
    }
}
