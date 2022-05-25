
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
            this.btn_addSymbol = new System.Windows.Forms.Button();
            this.cb_searchResult = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_addSymbol
            // 
            this.tb_addSymbol.Location = new System.Drawing.Point(12, 29);
            this.tb_addSymbol.Multiline = true;
            this.tb_addSymbol.Name = "tb_addSymbol";
            this.tb_addSymbol.Size = new System.Drawing.Size(364, 20);
            this.tb_addSymbol.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add new stock to Watchlist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add new stock to Watchlist (Search for Symbol)";
            // 
            // tb_addSearch
            // 
            this.tb_addSearch.Location = new System.Drawing.Point(12, 163);
            this.tb_addSearch.Multiline = true;
            this.tb_addSearch.Name = "tb_addSearch";
            this.tb_addSearch.Size = new System.Drawing.Size(364, 20);
            this.tb_addSearch.TabIndex = 2;
            // 
            // btn_addSearch
            // 
            this.btn_addSearch.Location = new System.Drawing.Point(12, 190);
            this.btn_addSearch.Name = "btn_addSearch";
            this.btn_addSearch.Size = new System.Drawing.Size(364, 23);
            this.btn_addSearch.TabIndex = 4;
            this.btn_addSearch.Text = "btn_addSearch";
            this.btn_addSearch.UseVisualStyleBackColor = true;
            this.btn_addSearch.Click += new System.EventHandler(this.btn_addSearch_Click);
            // 
            // btn_addSymbol
            // 
            this.btn_addSymbol.Location = new System.Drawing.Point(12, 55);
            this.btn_addSymbol.Name = "btn_addSymbol";
            this.btn_addSymbol.Size = new System.Drawing.Size(364, 23);
            this.btn_addSymbol.TabIndex = 5;
            this.btn_addSymbol.Text = "btn_addSymbol";
            this.btn_addSymbol.UseVisualStyleBackColor = true;
            this.btn_addSymbol.Click += new System.EventHandler(this.btn_addSymbol_Click);
            // 
            // cb_searchResult
            // 
            this.cb_searchResult.FormattingEnabled = true;
            this.cb_searchResult.Location = new System.Drawing.Point(12, 275);
            this.cb_searchResult.Name = "cb_searchResult";
            this.cb_searchResult.Size = new System.Drawing.Size(364, 21);
            this.cb_searchResult.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select Stock to add to Watchlist";
            // 
            // frm_addStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 436);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_searchResult);
            this.Controls.Add(this.btn_addSymbol);
            this.Controls.Add(this.btn_addSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_addSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_addSymbol);
            this.Name = "frm_addStocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewStocks";
            this.Load += new System.EventHandler(this.AddNewStocks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_addSymbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_addSearch;
        private System.Windows.Forms.Button btn_addSearch;
        private System.Windows.Forms.Button btn_addSymbol;
        private System.Windows.Forms.ComboBox cb_searchResult;
        private System.Windows.Forms.Label label3;
    }
}