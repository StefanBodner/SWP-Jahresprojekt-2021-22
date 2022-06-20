﻿using System;
using System.Windows.Forms;

namespace MyTrade
{
    public partial class frm_removeStock : Form
    {
        public frm_removeStock()
        {
            InitializeComponent();
        }

        private void frm_removeStock_Load(object sender, EventArgs e)
        {
            lb_stocks.Items.Clear();

            foreach(string s in StoreVariables.tickerWL)
            {
                lb_stocks.Items.Add(s);
            }
        }

        private void btn_removeStock_Click(object sender, EventArgs e)
        {
            if(lb_stocks.SelectedIndex != -1)
            {
                SQLInteraction.CMDExecuteNonQuery("DELETE FROM myTrade_UserWL WHERE ticker ='" + StoreVariables.tickerWL[lb_stocks.SelectedIndex] + "';");

                StoreVariables.tickerWL.RemoveAt(lb_stocks.SelectedIndex);
                lb_stocks.Items.Clear();

                foreach (string s in StoreVariables.tickerWL)
                {
                    lb_stocks.Items.Add(s);
                }

                if(lb_stocks.Items.Count != 0)
                {
                    lb_stocks.SelectedIndex = 0;
                }
                
                lb_stocks.Refresh();
            }
        }
    }
}