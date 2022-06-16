namespace MyTrade
{
    partial class frm_register
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
            this.tb_repeatPWD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.cb_show = new System.Windows.Forms.CheckBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.tb_prename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_repeatPWD
            // 
            this.tb_repeatPWD.Location = new System.Drawing.Point(13, 486);
            this.tb_repeatPWD.Name = "tb_repeatPWD";
            this.tb_repeatPWD.Size = new System.Drawing.Size(189, 20);
            this.tb_repeatPWD.TabIndex = 19;
            this.tb_repeatPWD.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Repeat Password:";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(13, 545);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(188, 23);
            this.btn_register.TabIndex = 17;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // cb_show
            // 
            this.cb_show.AutoSize = true;
            this.cb_show.Location = new System.Drawing.Point(14, 512);
            this.cb_show.Name = "cb_show";
            this.cb_show.Size = new System.Drawing.Size(99, 17);
            this.cb_show.TabIndex = 15;
            this.cb_show.Text = "show password";
            this.cb_show.UseVisualStyleBackColor = true;
            this.cb_show.CheckedChanged += new System.EventHandler(this.cb_show_CheckedChanged);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(12, 433);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(189, 20);
            this.tb_password.TabIndex = 14;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(10, 416);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 13;
            this.lbl_password.Text = "Password:";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(11, 387);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(190, 20);
            this.tb_username.TabIndex = 12;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(9, 371);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(58, 13);
            this.lbl_username.TabIndex = 11;
            this.lbl_username.Text = "Username:";
            // 
            // tb_prename
            // 
            this.tb_prename.Location = new System.Drawing.Point(10, 241);
            this.tb_prename.Name = "tb_prename";
            this.tb_prename.Size = new System.Drawing.Size(190, 20);
            this.tb_prename.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Prename:";
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(11, 289);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(190, 20);
            this.tb_surname.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Surname:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(11, 337);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(190, 20);
            this.tb_email.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Email:";
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.White;
            this.pb_logo.Image = global::MyTrade.Properties.Resources.MyTradeLogo1;
            this.pb_logo.Location = new System.Drawing.Point(12, 12);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(189, 199);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_logo.TabIndex = 10;
            this.pb_logo.TabStop = false;
            // 
            // frm_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 580);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_prename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_repeatPWD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.cb_show);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.pb_logo);
            this.Name = "frm_register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_repeatPWD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.CheckBox cb_show;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.TextBox tb_prename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label4;
    }
}