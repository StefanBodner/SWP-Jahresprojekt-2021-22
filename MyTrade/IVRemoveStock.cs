using System;
using System.Windows.Forms;

namespace MyTrade
{
    public partial class frm_IvRemoveStock : Form
    {
        public frm_IvRemoveStock()
        {
            InitializeComponent();
        }

        private void btn_removeStock_Click(object sender, EventArgs e)
        {
            if (lb_stocks.SelectedIndex != -1)
            {
                SQLInteraction.CMDExecuteNonQuery("DELETE FROM myTrade_UserIV WHERE ticker ='" + StoreVariables.tickerIV[lb_stocks.SelectedIndex].ticker + "';");

                StoreVariables.tickerIV.RemoveAt(lb_stocks.SelectedIndex);
                lb_stocks.Items.Clear();

                for (int i = 0; i < StoreVariables.tickerIV.Count; i++)
                {
                    lb_stocks.Items.Add(StoreVariables.tickerIV[i].ticker);
                }

                if (lb_stocks.Items.Count != 0)
                {
                    lb_stocks.SelectedIndex = 0;
                }

                lb_stocks.Refresh();
            }
        }

        private void IVRemoveStock_Load(object sender, EventArgs e)
        {
            lb_stocks.Items.Clear();

            for(int i = 0; i<StoreVariables.tickerIV.Count; i++)
            {
                lb_stocks.Items.Add(StoreVariables.tickerIV[i].ticker);
            }
        }
    }
}
