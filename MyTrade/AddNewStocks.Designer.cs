
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_addSearch = new System.Windows.Forms.TextBox();
            this.btn_addSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_addSymbol = new System.Windows.Forms.Button();
            this.lb_searchResult = new System.Windows.Forms.ListBox();
            this.cb_language = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add new stock to Watchlist (Search for Symbol)";
            // 
            // tb_addSearch
            // 
            this.tb_addSearch.Location = new System.Drawing.Point(12, 30);
            this.tb_addSearch.Multiline = true;
            this.tb_addSearch.Name = "tb_addSearch";
            this.tb_addSearch.Size = new System.Drawing.Size(260, 20);
            this.tb_addSearch.TabIndex = 2;
            // 
            // btn_addSearch
            // 
            this.btn_addSearch.Location = new System.Drawing.Point(12, 56);
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
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result";
            // 
            // btn_addSymbol
            // 
            this.btn_addSymbol.Location = new System.Drawing.Point(12, 224);
            this.btn_addSymbol.Name = "btn_addSymbol";
            this.btn_addSymbol.Size = new System.Drawing.Size(75, 23);
            this.btn_addSymbol.TabIndex = 9;
            this.btn_addSymbol.Text = "Add Stock";
            this.btn_addSymbol.UseVisualStyleBackColor = true;
            this.btn_addSymbol.Click += new System.EventHandler(this.btn_addSymbol_Click);
            // 
            // lb_searchResult
            // 
            this.lb_searchResult.FormattingEnabled = true;
            this.lb_searchResult.Location = new System.Drawing.Point(12, 103);
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
            this.cb_language.Location = new System.Drawing.Point(332, 30);
            this.cb_language.Name = "cb_language";
            this.cb_language.Size = new System.Drawing.Size(121, 21);
            this.cb_language.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Region";
            // 
            // frm_addStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 256);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_language);
            this.Controls.Add(this.lb_searchResult);
            this.Controls.Add(this.btn_addSymbol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_addSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_addSearch);
            this.Name = "frm_addStocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewStocks";
            this.Load += new System.EventHandler(this.AddNewStocks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_addSearch;
        private System.Windows.Forms.Button btn_addSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_addSymbol;
        private System.Windows.Forms.ListBox lb_searchResult;
        private System.Windows.Forms.ComboBox cb_language;
        private System.Windows.Forms.Label label4;
    }
}