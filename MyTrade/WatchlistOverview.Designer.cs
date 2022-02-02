
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
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_ticker = new System.Windows.Forms.TextBox();
            this.tb_listOutput = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.btn_showData = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ms_showWatchlist = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_showInvestments = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ms_addDecimal = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_removeDecimal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_data
            // 
            this.btn_data.Location = new System.Drawing.Point(12, 32);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(107, 23);
            this.btn_data.TabIndex = 0;
            this.btn_data.Text = "Update Data";
            this.btn_data.UseVisualStyleBackColor = true;
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(12, 61);
            this.tb_data.Multiline = true;
            this.tb_data.Name = "tb_data";
            this.tb_data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_data.Size = new System.Drawing.Size(693, 138);
            this.tb_data.TabIndex = 2;
            this.tb_data.Text = resources.GetString("tb_data.Text");
            // 
            // tb_ticker
            // 
            this.tb_ticker.Location = new System.Drawing.Point(125, 35);
            this.tb_ticker.Name = "tb_ticker";
            this.tb_ticker.Size = new System.Drawing.Size(212, 20);
            this.tb_ticker.TabIndex = 4;
            this.tb_ticker.Text = "AAPL,TSLA,MSFT";
            // 
            // tb_listOutput
            // 
            this.tb_listOutput.Location = new System.Drawing.Point(711, 61);
            this.tb_listOutput.Multiline = true;
            this.tb_listOutput.Name = "tb_listOutput";
            this.tb_listOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_listOutput.Size = new System.Drawing.Size(701, 138);
            this.tb_listOutput.TabIndex = 5;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(12, 205);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1400, 644);
            this.panel.TabIndex = 6;
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
            this.toolStripSeparator2,
            this.ms_addDecimal,
            this.ms_removeDecimal,
            this.toolStripSeparator1});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(160, 6);
            // 
            // ms_addDecimal
            // 
            this.ms_addDecimal.Name = "ms_addDecimal";
            this.ms_addDecimal.Size = new System.Drawing.Size(163, 22);
            this.ms_addDecimal.Text = "Add Decimal";
            // 
            // ms_removeDecimal
            // 
            this.ms_removeDecimal.Name = "ms_removeDecimal";
            this.ms_removeDecimal.Size = new System.Drawing.Size(163, 22);
            this.ms_removeDecimal.Text = "Remove Decimal";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(711, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sort Data ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_watchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_showData);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tb_listOutput);
            this.Controls.Add(this.tb_ticker);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.btn_data);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_watchlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WatchlistOverview";
            this.Load += new System.EventHandler(this.WatchlistOverview_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_data;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_ticker;
        private System.Windows.Forms.TextBox tb_listOutput;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_showData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ms_showWatchlist;
        private System.Windows.Forms.ToolStripMenuItem ms_showInvestments;
        private System.Windows.Forms.ToolStripMenuItem ms_addDecimal;
        private System.Windows.Forms.ToolStripMenuItem ms_removeDecimal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}