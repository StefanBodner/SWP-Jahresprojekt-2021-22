
namespace MyTrade
{
    partial class frm_chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_getdata = new System.Windows.Forms.Button();
            this.ch_line = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ch_line)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_getdata
            // 
            this.btn_getdata.Location = new System.Drawing.Point(662, 414);
            this.btn_getdata.Name = "btn_getdata";
            this.btn_getdata.Size = new System.Drawing.Size(110, 24);
            this.btn_getdata.TabIndex = 0;
            this.btn_getdata.Text = "GetData";
            this.btn_getdata.UseVisualStyleBackColor = true;
            this.btn_getdata.Click += new System.EventHandler(this.btn_getdata_Click);
            // 
            // ch_line
            // 
            chartArea2.Name = "ChartArea1";
            this.ch_line.ChartAreas.Add(chartArea2);
            this.ch_line.Location = new System.Drawing.Point(13, 75);
            this.ch_line.Name = "ch_line";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.ch_line.Series.Add(series2);
            this.ch_line.Size = new System.Drawing.Size(759, 333);
            this.ch_line.TabIndex = 1;
            this.ch_line.Text = "chart1";
            this.ch_line.Click += new System.EventHandler(this.ch_line_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Logged in as:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(568, 13);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "Username";
            // 
            // frm_chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ch_line);
            this.Controls.Add(this.btn_getdata);
            this.Name = "frm_chart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyTrade";
            this.Load += new System.EventHandler(this.frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ch_line)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_getdata;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_line;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_username;
    }
}

