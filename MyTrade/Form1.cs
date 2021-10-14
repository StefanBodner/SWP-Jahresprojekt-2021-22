using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YahooFinanceApi;

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

        private async void btn_data_Click(object sender, EventArgs e)
        {
            ticker = tb_ticker.Text;

            var yahooFinanceClient = new YahooFinance.YahooFinance();
            var stock = yahooFinanceClient.RetrieveStock("AAPL");

            tb_ask.Text = stock.PricingData.Ask.ToString();

            //--------------------------- TWO DIFFERENT METHODS ------------------------------

            //var history = await Yahoo.GetHistoricalAsync("AAPL", new DateTime(2021, 1, 1), new DateTime(2021, 5, 3), Period.Daily);

            //foreach (var candle in history)
            //{
            //    tb_ask.Text = candle.Close.ToString();
            //}
        }
    }
}
