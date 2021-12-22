using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MyTrade
{
    public partial class frm_chart : Form
    {
        public frm_chart()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

            
            var series = new Series("Kurswert");
            var series2 = new Series("Kurswert - 100");

            // Frist parameter is X-Axis and Second is Collection of Y- Axis
            series.ChartType = SeriesChartType.Line;
            series.Points.DataBindXY(new[] { 2000, 2001, 2002, 2003, 2004 }, new[] { 900, 100, 800, 1000, 400 });
            ch_line.Series.Add(series);

            series2.ChartType = SeriesChartType.Line;
            series2.Points.DataBindXY(new[] { 2000, 2001, 2002, 2003, 2004 }, new[] { 800, 600, 700, 800, 600 });
            ch_line.Series.Add(series2);
            ch_line.Series.RemoveAt(0);

            ch_line.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;//x axis

            ch_line.ChartAreas[0].Axes[0].Minimum = 2000;
            ch_line.ChartAreas[0].Axes[0].Maximum = 2004;
            ch_line.ChartAreas[0].Axes[1].Minimum = 50;
            ch_line.ChartAreas[0].Axes[1].Maximum = 1000;

            ch_line.ChartAreas[0].Axes[1].Title = "value";
            ch_line.ChartAreas[0].Axes[0].Title = "years";

        }

        private void btn_getdata_Click(object sender, EventArgs e)
        {
            frm_login ch = new frm_login();
            this.Hide();
            ch.ShowDialog();
            this.Show();
        }

        private void ch_line_Click(object sender, EventArgs e)
        {

        }
      
    }
}
