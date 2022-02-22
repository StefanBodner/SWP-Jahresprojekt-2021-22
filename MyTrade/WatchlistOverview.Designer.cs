
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_watchlist));
            this.btn_data = new System.Windows.Forms.Button();
            this.tb_ticker = new System.Windows.Forms.TextBox();
            this.btn_showData = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ms_showWatchlist = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_showInvestments = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_decimal = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_sortSymbol = new System.Windows.Forms.Button();
            this.btn_sortChange = new System.Windows.Forms.Button();
            this.btn_sortPrice = new System.Windows.Forms.Button();
            this.btn_sortExchange = new System.Windows.Forms.Button();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_listOutput = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelExtra = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.changeChartTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candlestickChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_data
            // 
            this.btn_data.Location = new System.Drawing.Point(485, 30);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(107, 23);
            this.btn_data.TabIndex = 0;
            this.btn_data.Text = "Update Data";
            this.btn_data.UseVisualStyleBackColor = true;
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            // 
            // tb_ticker
            // 
            this.tb_ticker.Location = new System.Drawing.Point(12, 32);
            this.tb_ticker.Name = "tb_ticker";
            this.tb_ticker.Size = new System.Drawing.Size(467, 20);
            this.tb_ticker.TabIndex = 4;
            this.tb_ticker.Text = "AAPL,TSLA,MSFT,GOOGL,FB,IMO1.HM,AMZN,^GDAXI,BTC-USD,MRNA,BNTX,NFLX,NESM";
            // 
            // btn_showData
            // 
            this.btn_showData.Location = new System.Drawing.Point(1268, 32);
            this.btn_showData.Name = "btn_showData";
            this.btn_showData.Size = new System.Drawing.Size(75, 23);
            this.btn_showData.TabIndex = 7;
            this.btn_showData.Text = "Show Data";
            this.btn_showData.UseVisualStyleBackColor = true;
            this.btn_showData.Click += new System.EventHandler(this.btn_showData_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_showWatchlist,
            this.ms_showInvestments,
            this.profileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1349, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ms_showWatchlist
            // 
            this.ms_showWatchlist.Name = "ms_showWatchlist";
            this.ms_showWatchlist.Size = new System.Drawing.Size(68, 20);
            this.ms_showWatchlist.Text = "Watchlist";
            // 
            // ms_showInvestments
            // 
            this.ms_showInvestments.Name = "ms_showInvestments";
            this.ms_showInvestments.Size = new System.Drawing.Size(89, 20);
            this.ms_showInvestments.Text = "Investements";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_decimal,
            this.changeColorToolStripMenuItem,
            this.changeChartTypeToolStripMenuItem,
            this.developerModeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // ms_decimal
            // 
            this.ms_decimal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decimalPlaceToolStripMenuItem,
            this.decimalPlacesToolStripMenuItem1,
            this.decimalPlacesToolStripMenuItem2,
            this.decimalPlacesToolStripMenuItem3});
            this.ms_decimal.Name = "ms_decimal";
            this.ms_decimal.Size = new System.Drawing.Size(161, 22);
            this.ms_decimal.Text = "Rounding";
            // 
            // decimalPlaceToolStripMenuItem
            // 
            this.decimalPlaceToolStripMenuItem.Name = "decimalPlaceToolStripMenuItem";
            this.decimalPlaceToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.decimalPlaceToolStripMenuItem.Text = "1 decimal place";
            this.decimalPlaceToolStripMenuItem.Click += new System.EventHandler(this.decimalPlaceToolStripMenuItem_Click);
            // 
            // decimalPlacesToolStripMenuItem1
            // 
            this.decimalPlacesToolStripMenuItem1.Name = "decimalPlacesToolStripMenuItem1";
            this.decimalPlacesToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.decimalPlacesToolStripMenuItem1.Text = "2 decimal places";
            this.decimalPlacesToolStripMenuItem1.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem1_Click);
            // 
            // decimalPlacesToolStripMenuItem2
            // 
            this.decimalPlacesToolStripMenuItem2.Name = "decimalPlacesToolStripMenuItem2";
            this.decimalPlacesToolStripMenuItem2.Size = new System.Drawing.Size(161, 22);
            this.decimalPlacesToolStripMenuItem2.Text = "3 decimal places";
            this.decimalPlacesToolStripMenuItem2.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem2_Click);
            // 
            // decimalPlacesToolStripMenuItem3
            // 
            this.decimalPlacesToolStripMenuItem3.Name = "decimalPlacesToolStripMenuItem3";
            this.decimalPlacesToolStripMenuItem3.Size = new System.Drawing.Size(161, 22);
            this.decimalPlacesToolStripMenuItem3.Text = "4 decimal places";
            this.decimalPlacesToolStripMenuItem3.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem3_Click);
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueWhiteToolStripMenuItem,
            this.grayWhiteToolStripMenuItem});
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeColorToolStripMenuItem.Text = "Theme";
            // 
            // blueWhiteToolStripMenuItem
            // 
            this.blueWhiteToolStripMenuItem.Name = "blueWhiteToolStripMenuItem";
            this.blueWhiteToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.blueWhiteToolStripMenuItem.Text = "Blue-White";
            this.blueWhiteToolStripMenuItem.Click += new System.EventHandler(this.blueWhiteToolStripMenuItem_Click);
            // 
            // grayWhiteToolStripMenuItem
            // 
            this.grayWhiteToolStripMenuItem.Name = "grayWhiteToolStripMenuItem";
            this.grayWhiteToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.grayWhiteToolStripMenuItem.Text = "Gray-White";
            this.grayWhiteToolStripMenuItem.Click += new System.EventHandler(this.grayWhiteToolStripMenuItem_Click);
            // 
            // developerModeToolStripMenuItem
            // 
            this.developerModeToolStripMenuItem.Name = "developerModeToolStripMenuItem";
            this.developerModeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.developerModeToolStripMenuItem.Text = "Developer mode";
            this.developerModeToolStripMenuItem.Click += new System.EventHandler(this.developerModeToolStripMenuItem_Click);
            // 
            // btn_sortSymbol
            // 
            this.btn_sortSymbol.Location = new System.Drawing.Point(12, 61);
            this.btn_sortSymbol.Name = "btn_sortSymbol";
            this.btn_sortSymbol.Size = new System.Drawing.Size(75, 23);
            this.btn_sortSymbol.TabIndex = 11;
            this.btn_sortSymbol.Text = "Symbol ";
            this.btn_sortSymbol.UseVisualStyleBackColor = true;
            this.btn_sortSymbol.Click += new System.EventHandler(this.btn_sortSymbol_Click);
            // 
            // btn_sortChange
            // 
            this.btn_sortChange.Location = new System.Drawing.Point(630, 61);
            this.btn_sortChange.Name = "btn_sortChange";
            this.btn_sortChange.Size = new System.Drawing.Size(75, 23);
            this.btn_sortChange.TabIndex = 14;
            this.btn_sortChange.Text = "Change ";
            this.btn_sortChange.UseVisualStyleBackColor = true;
            this.btn_sortChange.Click += new System.EventHandler(this.btn_sortChange_Click);
            // 
            // btn_sortPrice
            // 
            this.btn_sortPrice.Location = new System.Drawing.Point(830, 61);
            this.btn_sortPrice.Name = "btn_sortPrice";
            this.btn_sortPrice.Size = new System.Drawing.Size(75, 23);
            this.btn_sortPrice.TabIndex = 15;
            this.btn_sortPrice.Text = "Price ";
            this.btn_sortPrice.UseVisualStyleBackColor = true;
            this.btn_sortPrice.Click += new System.EventHandler(this.btn_sortPrice_Click);
            // 
            // btn_sortExchange
            // 
            this.btn_sortExchange.Location = new System.Drawing.Point(1015, 61);
            this.btn_sortExchange.Name = "btn_sortExchange";
            this.btn_sortExchange.Size = new System.Drawing.Size(75, 23);
            this.btn_sortExchange.TabIndex = 16;
            this.btn_sortExchange.Text = "Exchange ";
            this.btn_sortExchange.UseVisualStyleBackColor = true;
            this.btn_sortExchange.Click += new System.EventHandler(this.btn_sortExchange_Click);
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(1349, 27);
            this.tb_data.Multiline = true;
            this.tb_data.Name = "tb_data";
            this.tb_data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_data.Size = new System.Drawing.Size(426, 454);
            this.tb_data.TabIndex = 2;
            this.tb_data.Text = resources.GetString("tb_data.Text");
            this.tb_data.Visible = false;
            // 
            // tb_listOutput
            // 
            this.tb_listOutput.Location = new System.Drawing.Point(1349, 487);
            this.tb_listOutput.Multiline = true;
            this.tb_listOutput.Name = "tb_listOutput";
            this.tb_listOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_listOutput.Size = new System.Drawing.Size(426, 374);
            this.tb_listOutput.TabIndex = 5;
            this.tb_listOutput.Visible = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.Location = new System.Drawing.Point(12, 104);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1331, 745);
            this.panelMain.TabIndex = 102;
            // 
            // panelExtra
            // 
            this.panelExtra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelExtra.Location = new System.Drawing.Point(12, 495);
            this.panelExtra.Name = "panelExtra";
            this.panelExtra.Size = new System.Drawing.Size(1331, 354);
            this.panelExtra.TabIndex = 103;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(12, 487);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1331, 2);
            this.pictureBox2.TabIndex = 104;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(12, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1331, 2);
            this.pictureBox3.TabIndex = 105;
            this.pictureBox3.TabStop = false;
            // 
            // changeChartTypeToolStripMenuItem
            // 
            this.changeChartTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineChartToolStripMenuItem,
            this.candlestickChartToolStripMenuItem});
            this.changeChartTypeToolStripMenuItem.Name = "changeChartTypeToolStripMenuItem";
            this.changeChartTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeChartTypeToolStripMenuItem.Text = "Chart Type";
            // 
            // lineChartToolStripMenuItem
            // 
            this.lineChartToolStripMenuItem.Name = "lineChartToolStripMenuItem";
            this.lineChartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lineChartToolStripMenuItem.Text = "Line Chart";
            // 
            // candlestickChartToolStripMenuItem
            // 
            this.candlestickChartToolStripMenuItem.Name = "candlestickChartToolStripMenuItem";
            this.candlestickChartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.candlestickChartToolStripMenuItem.Text = "Candlestick Chart";
            // 
            // frm_watchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 861);
            this.Controls.Add(this.tb_listOutput);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.panelExtra);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tb_ticker);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btn_sortExchange);
            this.Controls.Add(this.btn_sortPrice);
            this.Controls.Add(this.btn_sortChange);
            this.Controls.Add(this.btn_sortSymbol);
            this.Controls.Add(this.btn_showData);
            this.Controls.Add(this.btn_data);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_watchlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyTrade";
            this.Load += new System.EventHandler(this.WatchlistOverview_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_data;
        private System.Windows.Forms.TextBox tb_ticker;
        private System.Windows.Forms.Button btn_showData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ms_showWatchlist;
        private System.Windows.Forms.ToolStripMenuItem ms_showInvestments;
        private System.Windows.Forms.ToolStripMenuItem ms_decimal;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.Button btn_sortSymbol;
        private System.Windows.Forms.Button btn_sortChange;
        private System.Windows.Forms.Button btn_sortPrice;
        private System.Windows.Forms.Button btn_sortExchange;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_listOutput;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem decimalPlaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem developerModeToolStripMenuItem;
        private System.Windows.Forms.Panel panelExtra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueWhiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayWhiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeChartTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candlestickChartToolStripMenuItem;
    }
}