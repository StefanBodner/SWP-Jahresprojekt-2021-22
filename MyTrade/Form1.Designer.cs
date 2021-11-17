
namespace MyTrade
{
    partial class frm_main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.btn_data = new System.Windows.Forms.Button();
            this.tb_ticker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_bid = new System.Windows.Forms.TextBox();
            this.tb_ask = new System.Windows.Forms.TextBox();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_data
            // 
            this.btn_data.Location = new System.Drawing.Point(12, 106);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(75, 23);
            this.btn_data.TabIndex = 0;
            this.btn_data.Text = "Get Data";
            this.btn_data.UseVisualStyleBackColor = true;
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            // 
            // tb_ticker
            // 
            this.tb_ticker.Location = new System.Drawing.Point(12, 80);
            this.tb_ticker.Name = "tb_ticker";
            this.tb_ticker.Size = new System.Drawing.Size(209, 20);
            this.tb_ticker.TabIndex = 1;
            this.tb_ticker.Text = "AAPL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ask:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Insert Ticker:";
            // 
            // tb_bid
            // 
            this.tb_bid.Location = new System.Drawing.Point(717, 80);
            this.tb_bid.Name = "tb_bid";
            this.tb_bid.Size = new System.Drawing.Size(209, 20);
            this.tb_bid.TabIndex = 5;
            // 
            // tb_ask
            // 
            this.tb_ask.Location = new System.Drawing.Point(717, 107);
            this.tb_ask.Name = "tb_ask";
            this.tb_ask.Size = new System.Drawing.Size(209, 20);
            this.tb_ask.TabIndex = 6;
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(12, 157);
            this.tb_data.Multiline = true;
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(914, 560);
            this.tb_data.TabIndex = 7;
            this.tb_data.Text = resources.GetString("tb_data.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Maximum 100 Calls!";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 729);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.tb_ask);
            this.Controls.Add(this.tb_bid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ticker);
            this.Controls.Add(this.btn_data);
            this.Name = "frm_main";
            this.Text = "MyTrade";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_data;
        private System.Windows.Forms.TextBox tb_ticker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_bid;
        private System.Windows.Forms.TextBox tb_ask;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.Label label4;
    }
}

