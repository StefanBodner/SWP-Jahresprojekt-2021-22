using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTrade
{
    public partial class frm_register : Form
    {
        public frm_register()
        {
            InitializeComponent();
        }

        private void frm_register_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (!isValid())
            {

            }
            else if (isValid())
            {
                if(tb_password.Text != tb_checkpassword.Text)
                {
                    MessageBox.Show("Please enter password twice!");
                }
                else
                {
                    if(SQLInteraction.CMDExecuteScalar("SELECT [user] FROM mytrade_UserData WHERE [user] = '"+ tb_username.Text + "';").ToString().Equals(tb_username.Text))
                    {
                        MessageBox.Show("Username already exists!");
                    }
                    else
                    {
                        SQLInteraction.uCreateNewUser(tb_password.Text, tb_surname.Text, tb_username.Text, tb_password.Text, "0", "");
                        MessageBox.Show("Successfully registered!");
                        this.Close();
                    }
                    
                }
            }


        }
        private bool isValid()
        {
            bool temp;
            if (tb_username.Text == string.Empty || tb_password.Text == string.Empty || tb_surname.Text == string.Empty || tb_prename.Text == string.Empty || tb_checkpassword.Text == string.Empty)
            {
                MessageBox.Show("Please fill every Textbox!");
                temp = false;
            }
            else
            {
                temp = true;
            }
            return temp;
        }

        private void cb_show_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_show.Checked)
            {
                tb_password.UseSystemPasswordChar = false;
                tb_checkpassword.UseSystemPasswordChar = false;
            }
            else
            {
                tb_password.UseSystemPasswordChar = true;
                tb_checkpassword.UseSystemPasswordChar = true;
            }
        }
    }
}
