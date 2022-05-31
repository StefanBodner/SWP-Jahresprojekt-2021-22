
namespace MyTrade
{
    partial class frm_addStocks
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
            this.tb_addSymbol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_addSearch = new System.Windows.Forms.TextBox();
            this.btn_addSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_addSymbol = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_searchResult = new System.Windows.Forms.ListBox();
            this.cb_language = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_addSymbol
            // 
            this.tb_addSymbol.Location = new System.Drawing.Point(12, 29);
            this.tb_addSymbol.Multiline = true;
            this.tb_addSymbol.Name = "tb_addSymbol";
            this.tb_addSymbol.Size = new System.Drawing.Size(463, 20);
            this.tb_addSymbol.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Save Calls (Enter Ticker manually)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add new stock to Watchlist (Search for Symbol)";
            // 
            // tb_addSearch
            // 
            this.tb_addSearch.Location = new System.Drawing.Point(12, 134);
            this.tb_addSearch.Multiline = true;
            this.tb_addSearch.Name = "tb_addSearch";
            this.tb_addSearch.Size = new System.Drawing.Size(260, 20);
            this.tb_addSearch.TabIndex = 2;
            // 
            // btn_addSearch
            // 
            this.btn_addSearch.Location = new System.Drawing.Point(12, 160);
            this.btn_addSearch.Name = "btn_addSearch";
            this.btn_addSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_addSearch.TabIndex = 4;
            this.btn_addSearch.Text = "Search";
            this.btn_addSearch.UseVisualStyleBackColor = true;
            this.btn_addSearch.Click += new System.EventHandler(this.btn_addSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result";
            // 
            // btn_addSymbol
            // 
            this.btn_addSymbol.Location = new System.Drawing.Point(12, 328);
            this.btn_addSymbol.Name = "btn_addSymbol";
            this.btn_addSymbol.Size = new System.Drawing.Size(75, 23);
            this.btn_addSymbol.TabIndex = 9;
            this.btn_addSymbol.Text = "Add Stock";
            this.btn_addSymbol.UseVisualStyleBackColor = true;
            this.btn_addSymbol.Click += new System.EventHandler(this.btn_addSymbol_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Stock";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(12, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 5);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lb_searchResult
            // 
            this.lb_searchResult.FormattingEnabled = true;
            this.lb_searchResult.Location = new System.Drawing.Point(12, 207);
            this.lb_searchResult.Name = "lb_searchResult";
            this.lb_searchResult.Size = new System.Drawing.Size(463, 95);
            this.lb_searchResult.TabIndex = 12;
            // 
            // cb_language
            // 
            this.cb_language.FormattingEnabled = true;
            this.cb_language.Items.AddRange(new object[] {
            "en",
            "fr",
            "de",
            "it",
            "es",
            "zh"});
            this.cb_language.Location = new System.Drawing.Point(332, 134);
            this.cb_language.Name = "cb_language";
            this.cb_language.Size = new System.Drawing.Size(121, 21);
            this.cb_language.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Region";
            // 
            // frm_addStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 363);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_language);
            this.Controls.Add(this.lb_searchResult);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_addSymbol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_addSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_addSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_addSymbol);
            this.Name = "frm_addStocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewStocks";
            this.Load += new System.EventHandler(this.AddNewStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_addSymbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_addSearch;
        private System.Windows.Forms.Button btn_addSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_addSymbol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lb_searchResult;
        private System.Windows.Forms.ComboBox cb_language;
        private System.Windows.Forms.Label label4;
    }
}