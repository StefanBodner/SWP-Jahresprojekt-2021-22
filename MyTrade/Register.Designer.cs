﻿
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
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_prename = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_prename = new System.Windows.Forms.TextBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.btn_register = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(112, 278);
            this.tb_username.Multiline = true;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(139, 26);
            this.tb_username.TabIndex = 2;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(25, 310);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(74, 20);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_prename
            // 
            this.lbl_prename.AutoSize = true;
            this.lbl_prename.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prename.Location = new System.Drawing.Point(25, 247);
            this.lbl_prename.Name = "lbl_prename";
            this.lbl_prename.Size = new System.Drawing.Size(66, 20);
            this.lbl_prename.TabIndex = 3;
            this.lbl_prename.Text = "Prename:";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(112, 341);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(139, 26);
            this.tb_password.TabIndex = 4;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surname.Location = new System.Drawing.Point(25, 278);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(67, 20);
            this.lbl_surname.TabIndex = 5;
            this.lbl_surname.Text = "Surname:";
            // 
            // tb_surname
            // 
            this.tb_surname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_surname.Location = new System.Drawing.Point(112, 310);
            this.tb_surname.Multiline = true;
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(139, 25);
            this.tb_surname.TabIndex = 3;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(24, 341);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(72, 20);
            this.lbl_password.TabIndex = 7;
            this.lbl_password.Text = "Password:";
            // 
            // tb_prename
            // 
            this.tb_prename.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_prename.Location = new System.Drawing.Point(112, 247);
            this.tb_prename.Multiline = true;
            this.tb_prename.Name = "tb_prename";
            this.tb_prename.Size = new System.Drawing.Size(139, 25);
            this.tb_prename.TabIndex = 1;
            // 
            // pb_logo
            // 
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_logo.Image = global::MyTrade.Properties.Resources.MyTradeLogo1;
            this.pb_logo.Location = new System.Drawing.Point(38, 12);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(200, 202);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_logo.TabIndex = 8;
            this.pb_logo.TabStop = false;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(25, 384);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(226, 30);
            this.btn_register.TabIndex = 5;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // frm_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(271, 426);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.tb_prename);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.lbl_prename);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.tb_username);
            this.Name = "frm_register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.frm_register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_prename;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_prename;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button btn_register;
    }
}