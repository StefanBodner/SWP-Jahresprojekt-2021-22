
namespace MyTrade
{
    partial class frm_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_username = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.cb_show = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.btn_register = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(37, 240);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(58, 13);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username:";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(39, 256);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(190, 20);
            this.tb_username.TabIndex = 2;
            this.tb_username.Text = "admin";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(40, 302);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(189, 20);
            this.tb_password.TabIndex = 4;
            this.tb_password.Text = "admin";
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(38, 285);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password:";
            // 
            // cb_show
            // 
            this.cb_show.AutoSize = true;
            this.cb_show.Location = new System.Drawing.Point(41, 328);
            this.cb_show.Name = "cb_show";
            this.cb_show.Size = new System.Drawing.Size(99, 17);
            this.cb_show.TabIndex = 5;
            this.cb_show.Text = "show password";
            this.cb_show.UseVisualStyleBackColor = true;
            this.cb_show.CheckedChanged += new System.EventHandler(this.cb_show_CheckedChanged);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(39, 367);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(91, 23);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.White;
            this.pb_logo.Image = global::MyTrade.Properties.Resources.MyTradeLogo1;
            this.pb_logo.Location = new System.Drawing.Point(40, 24);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(189, 199);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(138, 367);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(91, 23);
            this.btn_register.TabIndex = 7;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(271, 426);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.cb_show);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.pb_logo);
            this.Name = "frm_login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.CheckBox cb_show;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_register;
    }
}