
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_getdata = new System.Windows.Forms.Button();
            this.ch_line = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            chartArea1.Name = "ChartArea1";
            this.ch_line.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch_line.Legends.Add(legend1);
            this.ch_line.Location = new System.Drawing.Point(13, 75);
            this.ch_line.Name = "ch_line";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ch_line.Series.Add(series1);
            this.ch_line.Size = new System.Drawing.Size(759, 333);
            this.ch_line.TabIndex = 1;
            this.ch_line.Text = "chart1";
            this.ch_line.Click += new System.EventHandler(this.ch_line_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.ch_line);
            this.Controls.Add(this.btn_getdata);
            this.Name = "frm_main";
            this.Text = "MyTrade";
            this.Load += new System.EventHandler(this.frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ch_line)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_getdata;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_line;
    }
}

