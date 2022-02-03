
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
            this.btn_sortSymbol = new System.Windows.Forms.Button();
            this.btn_sortChange = new System.Windows.Forms.Button();
            this.btn_sortPrice = new System.Windows.Forms.Button();
            this.btn_sortExchange = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_listOutput = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.developerModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btn_showData.Location = new System.Drawing.Point(1337, 32);
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
            this.menuStrip1.Size = new System.Drawing.Size(1424, 24);
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
            this.ms_decimal.Size = new System.Drawing.Size(180, 22);
            this.ms_decimal.Text = "Rounding";
            // 
            // decimalPlaceToolStripMenuItem
            // 
            this.decimalPlaceToolStripMenuItem.Name = "decimalPlaceToolStripMenuItem";
            this.decimalPlaceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.decimalPlaceToolStripMenuItem.Text = "1 decimal place";
            this.decimalPlaceToolStripMenuItem.Click += new System.EventHandler(this.decimalPlaceToolStripMenuItem_Click);
            // 
            // decimalPlacesToolStripMenuItem1
            // 
            this.decimalPlacesToolStripMenuItem1.Name = "decimalPlacesToolStripMenuItem1";
            this.decimalPlacesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.decimalPlacesToolStripMenuItem1.Text = "2 decimal places";
            this.decimalPlacesToolStripMenuItem1.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem1_Click);
            // 
            // decimalPlacesToolStripMenuItem2
            // 
            this.decimalPlacesToolStripMenuItem2.Name = "decimalPlacesToolStripMenuItem2";
            this.decimalPlacesToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.decimalPlacesToolStripMenuItem2.Text = "3 decimal places";
            this.decimalPlacesToolStripMenuItem2.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem2_Click);
            // 
            // decimalPlacesToolStripMenuItem3
            // 
            this.decimalPlacesToolStripMenuItem3.Name = "decimalPlacesToolStripMenuItem3";
            this.decimalPlacesToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.decimalPlacesToolStripMenuItem3.Text = "4 decimal places";
            this.decimalPlacesToolStripMenuItem3.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem3_Click);
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
            this.btn_sortChange.Location = new System.Drawing.Point(517, 61);
            this.btn_sortChange.Name = "btn_sortChange";
            this.btn_sortChange.Size = new System.Drawing.Size(75, 23);
            this.btn_sortChange.TabIndex = 14;
            this.btn_sortChange.Text = "Change ";
            this.btn_sortChange.UseVisualStyleBackColor = true;
            this.btn_sortChange.Click += new System.EventHandler(this.btn_sortChange_Click);
            // 
            // btn_sortPrice
            // 
            this.btn_sortPrice.Location = new System.Drawing.Point(711, 61);
            this.btn_sortPrice.Name = "btn_sortPrice";
            this.btn_sortPrice.Size = new System.Drawing.Size(75, 23);
            this.btn_sortPrice.TabIndex = 15;
            this.btn_sortPrice.Text = "Price ";
            this.btn_sortPrice.UseVisualStyleBackColor = true;
            this.btn_sortPrice.Click += new System.EventHandler(this.btn_sortPrice_Click);
            // 
            // btn_sortExchange
            // 
            this.btn_sortExchange.Location = new System.Drawing.Point(913, 61);
            this.btn_sortExchange.Name = "btn_sortExchange";
            this.btn_sortExchange.Size = new System.Drawing.Size(75, 23);
            this.btn_sortExchange.TabIndex = 16;
            this.btn_sortExchange.Text = "Exchange ";
            this.btn_sortExchange.UseVisualStyleBackColor = true;
            this.btn_sortExchange.Click += new System.EventHandler(this.btn_sortExchange_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(12, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1400, 2);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(12, 725);
            this.tb_data.Multiline = true;
            this.tb_data.Name = "tb_data";
            this.tb_data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_data.Size = new System.Drawing.Size(693, 111);
            this.tb_data.TabIndex = 2;
            this.tb_data.Text = resources.GetString("tb_data.Text");
            this.tb_data.Visible = false;
            // 
            // tb_listOutput
            // 
            this.tb_listOutput.Location = new System.Drawing.Point(708, 725);
            this.tb_listOutput.Multiline = true;
            this.tb_listOutput.Name = "tb_listOutput";
            this.tb_listOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_listOutput.Size = new System.Drawing.Size(701, 111);
            this.tb_listOutput.TabIndex = 5;
            this.tb_listOutput.Visible = false;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(12, 98);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1400, 603);
            this.panel.TabIndex = 102;
            // 
            // developerModeToolStripMenuItem
            // 
            this.developerModeToolStripMenuItem.Name = "developerModeToolStripMenuItem";
            this.developerModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.developerModeToolStripMenuItem.Text = "Developer mode";
            this.developerModeToolStripMenuItem.Click += new System.EventHandler(this.developerModeToolStripMenuItem_Click);
            // 
            // frm_watchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.tb_listOutput);
            this.Controls.Add(this.tb_ticker);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_listOutput;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripMenuItem decimalPlaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem developerModeToolStripMenuItem;
    }
}