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
            if (isValid() == true)
            {

            }
            else if (isValid() == false)
            {
                SQLInteraction.uCreateNewUser(tb_password.Text, tb_surname.Text, tb_username.Text, tb_password.Text, "1", "");
            }

            MessageBox.Show("Successfully registered!");

            this.Close();

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
    }
}
