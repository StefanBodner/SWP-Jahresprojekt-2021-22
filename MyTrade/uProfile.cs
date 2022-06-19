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
    public partial class frm_profile : Form
    {
        public frm_profile()
        {
            InitializeComponent();
        }

        bool EmptyTextBoxes()
        {
            //Check if there are any empty boxes
            foreach (Control tb in this.Controls)
            {
                if (tb is TextBox)
                {
                    if (tb.Text.Equals(""))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        bool IsValidEmail(string email)
        {
            //Check if email has a correct format
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (EmptyTextBoxes())
            {
                MessageBox.Show("Please leave no boxes empty!");
            }
            else
            {
                if (IsValidEmail(tb_email.Text))
                {
                    if (tb_password.Text.Equals(tb_repeatPWD.Text))
                    {
                        SQLInteraction.uUpdateUser(tb_surname.Text, tb_prename.Text, tb_email.Text, tb_username.Text, tb_password.Text);

                        MessageBox.Show("Successfully Updated Profile!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please enter the same Password!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid E-Mail!");
                }
            }
        }

        private void frm_profile_Load(object sender, EventArgs e)
        {
            tb_prename.Text = SQLInteraction.CMDExecuteScalar("SELECT prename FROM myTrade_Login WHERE UID = '" + SQLInteraction.GetUID() + "';");
            tb_surname.Text = SQLInteraction.CMDExecuteScalar("SELECT surname FROM myTrade_Login WHERE UID = '" + SQLInteraction.GetUID() + "';");
            tb_email.Text = SQLInteraction.CMDExecuteScalar("SELECT email FROM myTrade_Login WHERE UID = '" + SQLInteraction.GetUID() + "';");
            tb_username.Text =  SQLInteraction.CMDExecuteScalar("SELECT user FROM myTrade_Login WHERE UID = '" + SQLInteraction.GetUID() + "';");
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
