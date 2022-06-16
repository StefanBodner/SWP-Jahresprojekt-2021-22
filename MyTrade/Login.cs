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
            SQLInteraction.SetConnectionString("server = (localdb)\\MSSQLLocalDB; Integrated Security = sspi;");

            if (SQLInteraction.CMDExecuteScalarInt("SELECT COUNT(*) FROM master.dbo.sysdatabases where name = 'MyTrade';") == 0)
            {
                
                //Create Database
                SQLInteraction.CMDExecuteNonQuery("CREATE DATABASE MyTrade");
                
                //Connect to Server & Database
                SQLInteraction.SetConnectionString("server = (localdb)\\MSSQLLocalDB; database = MyTrade; Integrated Security = sspi;");
                
                //Create Login Table
                SQLInteraction.CMDExecuteNonQuery("CREATE TABLE myTrade_Login(UID int IDENTITY(1, 1), [surname] varchar(50) NOT NULL, [prename] varchar(50) NOT NULL, [email] varchar(80) NOT NULL, [user] varchar(80) NOT NULL, [pwd] varchar(70) NOT NULL, PRIMARY KEY(UID));");
                
                //Create User Data
                SQLInteraction.CMDExecuteNonQuery("CREATE TABLE myTrade_UserWL(WLID int IDENTITY(1, 1), [UID] int NOT NULL, [ticker] varchar(50) NOT NULL, PRIMARY KEY(WLID));");

                //Create default User
                SQLInteraction.uCreateNewUser("User", "Test", "user.test@gmail.com", "user", "Test1!");
            }

            //Connect to Server & Database
            SQLInteraction.SetConnectionString("server = (localdb)\\MSSQLLocalDB; database = MyTrade; Integrated Security = sspi;");
        }
        


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (SQLInteraction.uLogin(tb_username.Text, tb_password.Text))
            {
                SQLInteraction.SetUID(SQLInteraction.CMDExecuteScalarInt("SELECT [UID] FROM myTrade_Login WHERE [user] = '" + tb_username.Text + "';"));

                StoreVariables.tickerWL = SQLInteraction.uGetTickerWL();

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
