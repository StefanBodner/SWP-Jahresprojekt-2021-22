using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTrade
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

            //Connect to Server
            SQLInteraction.SetConnectionString("server=web.hak-kitz.eu;database=stefan.bodner_mytrade;UID=stefan.bodner;password='MyDatabase020';");

            //Create Database
            //SQLInteraction.CMDExecuteNonQuery("CREATE DATABASE IF NOT EXISTS 'stefan.bodner_MyTrade';");
            //MessageBox.Show("Database created!");

            //Create Login Table
            SQLInteraction.CMDExecuteNonQuery("CREATE TABLE IF NOT EXISTS myTrade_Login(UID int NOT NULL Primary Key AUTO_INCREMENT, surname varchar(50) NOT NULL, prename varchar(50) NOT NULL, email varchar(80) NOT NULL, user varchar(80) NOT NULL, pwd varchar(70) NOT NULL);");

            //Create User Watchlist
            SQLInteraction.CMDExecuteNonQuery("CREATE TABLE IF NOT EXISTS myTrade_UserWL(WLID int NOT NULL PRIMARY KEY AUTO_INCREMENT, UID int NOT NULL, ticker varchar(50) NOT NULL);");

            //Create User Investments
            SQLInteraction.CMDExecuteNonQuery("CREATE TABLE IF NOT EXISTS myTrade_UserIV(IVID int NOT NULL PRIMARY KEY AUTO_INCREMENT, UID int NOT NULL, ticker varchar(50) NOT NULL, amount double NOT NULL, avgPrice double NOT NULL, fees double NOT NULL);");

            //Create default User
            if (!SQLInteraction.UsernameExists("user"))
            {
                SQLInteraction.uCreateNewUser("User", "Test", "user.test@gmail.com", "user", "Test1!");
            }
        }
        


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (SQLInteraction.uLogin(tb_username.Text, tb_password.Text))
            {
                SQLInteraction.SetUID(SQLInteraction.CMDExecuteScalarInt("SELECT UID FROM myTrade_Login WHERE user = '" + tb_username.Text + "';"));

                StoreVariables.tickerWL = SQLInteraction.uGetTickerWL();
                
                SQLInteraction.FillIVList();

                frm_watchlist frm_Watchlist = new frm_watchlist();
                this.Hide();
                frm_Watchlist.ShowDialog();
                this.Show();
            }

        }

        private void cb_show_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_show.Checked)
            {
                tb_password.UseSystemPasswordChar = false;
            }
            else
            {
                tb_password.UseSystemPasswordChar = true;
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            frm_register frm_Register = new frm_register();
            this.Hide();
            frm_Register.ShowDialog();
            this.Show();
        }
    }
}
