
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
            this.label3 = new System.Windows.Forms.Label();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Insert Ticker:";
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(12, 157);
            this.tb_data.Multiline = true;
            this.tb_data.Name = "tb_data";
            this.tb_data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
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
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(940, 157);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_output.Size = new System.Drawing.Size(337, 560);
            this.tb_output.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1202, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Split Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Button button1;
    }
}

