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
            SQLInteraction.SetConnectionString("server = (localdb)\\MSSQLLocalDB; Integrated Security = sspi;");

            if (SQLInteraction.CMDExecuteScalarInt("SELECT COUNT(*) FROM master.dbo.sysdatabases where name = 'MyTrade';") == 0)
            {
                SQLInteraction.CMDExecuteNonQuery("CREATE DATABASE MyTrade");

                SQLInteraction.SetConnectionString("server = (localdb)\\MSSQLLocalDB; database = MyTrade; Integrated Security = sspi;");

                SQLInteraction.CMDExecuteNonQuery("CREATE TABLE mytrade_UserData(UID int IDENTITY(1, 1), [surname] varchar(50) NOT NULL, [prename] varchar(50) NOT NULL, [user] varchar(80) NOT NULL, [pwd] varchar(70) NOT NULL, [hasAdmin] bit NOT NULL, [ticker] varchar(250) NOT NULL, PRIMARY KEY(UID)); ");

            }

            SQLInteraction.SetConnectionString("server = (localdb)\\MSSQLLocalDB; database = MyTrade; Integrated Security = sspi;");


            if (!SQLInteraction.CMDExecuteScalar("SELECT [user] FROM mytrade_UserData WHERE [user] = 'admin';").ToString().Equals("admin"))
            {
                //Create Admin User
                SQLInteraction.uCreateNewUser("admin", "admin", "admin", "admin", "1", "AAPL");
                //SQLInteraction.CMDExecuteNonQuery("INSERT INTO swp3_Login VALUES ('admin', '"+ BCrypt.HashPassword("admin", BCrypt.GenerateSalt()) + "', 1)");

                //Create More Users to fill Database
                SQLInteraction.uCreateNewUser("noadmin", "noadmin", "noadmin", "noadmin", "0", "AAPL");

            }
            else
            {
                SQLInteraction.CMDExecuteNonQuery("UPDATE mytrade_UserData SET hasAdmin = 1 WHERE [user] = 'admin';");
            }
        }
        


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private bool isValid()
        {
            if (tb_username.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Textbox (username) is empty!!!!!!!\r\rEnter valid username.");
                return false;
            }

            else if (tb_password.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Textbox (password) is empty!!!!!!!\r\rEnter valid password.");
                return false;
            }

            return true;
        }

        

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (SQLInteraction.uLogin(tb_username.Text, tb_password.Text))
            {
                SQLInteraction.SetuUsernameLogin(tb_username.Text);

                SQLInteraction.SetuEditID(SQLInteraction.CMDExecuteScalarInt("SELECT [UID] FROM mytrade_UserData WHERE [user] = '" + tb_username.Text + "';"));
                SQLInteraction.SetAddUser(false);

                if (SQLInteraction.CMDExecuteScalarBool("SELECT [hasAdmin] FROM mytrade_UserData WHERE [uid] = " + SQLInteraction.GetuEditID() + ";"))
                {
                    frm_chart ch = new frm_chart();
                    this.Hide();
                    ch.ShowDialog();
                    this.Show();
                }
                else
                {
                    frm_chart ov = new frm_chart();
                    this.Hide();
                    ov.ShowDialog();
                    this.Show();
                }
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
    }
}
