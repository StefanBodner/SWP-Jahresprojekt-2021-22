
namespace MyTrade
{
    partial class frm_watchlist
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
            this.btn_data = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.tb_ticker = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_data
            // 
            this.btn_data.Location = new System.Drawing.Point(12, 12);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(75, 23);
            this.btn_data.TabIndex = 0;
            this.btn_data.Text = "Load Data";
            this.btn_data.UseVisualStyleBackColor = true;
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(805, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Split Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(12, 41);
            this.tb_data.Multiline = true;
            this.tb_data.Name = "tb_data";
            this.tb_data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_data.Size = new System.Drawing.Size(693, 554);
            this.tb_data.TabIndex = 2;
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(805, 41);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_output.Size = new System.Drawing.Size(374, 554);
            this.tb_output.TabIndex = 3;
            // 
            // tb_ticker
            // 
            this.tb_ticker.Location = new System.Drawing.Point(93, 15);
            this.tb_ticker.Name = "tb_ticker";
            this.tb_ticker.Size = new System.Drawing.Size(100, 20);
            this.tb_ticker.TabIndex = 4;
            // 
            // frm_watchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 607);
            this.Controls.Add(this.tb_ticker);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_data);
            this.Name = "frm_watchlist";
            this.Text = "WatchlistOverview";
            this.Load += new System.EventHandler(this.WatchlistOverview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_data;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.TextBox tb_ticker;
    }
}