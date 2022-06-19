namespace MyTrade
{
    partial class frm_IvAddStocks
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
            this.label4 = new System.Windows.Forms.Label();
            this.cb_language = new System.Windows.Forms.ComboBox();
            this.lb_searchResult = new System.Windows.Forms.ListBox();
            this.btn_selectSymbol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_addSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_addSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_addStock = new System.Windows.Forms.Button();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_selectedStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_avgPrice = new System.Windows.Forms.TextBox();
            this.tb_fees = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Region";
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
            this.cb_language.Location = new System.Drawing.Point(331, 25);
            this.cb_language.Name = "cb_language";
            this.cb_language.Size = new System.Drawing.Size(121, 21);
            this.cb_language.TabIndex = 21;
            // 
            // lb_searchResult
            // 
            this.lb_searchResult.FormattingEnabled = true;
            this.lb_searchResult.Location = new System.Drawing.Point(11, 98);
            this.lb_searchResult.Name = "lb_searchResult";
            this.lb_searchResult.Size = new System.Drawing.Size(463, 95);
            this.lb_searchResult.TabIndex = 20;
            // 
            // btn_selectSymbol
            // 
            this.btn_selectSymbol.Location = new System.Drawing.Point(11, 199);
            this.btn_selectSymbol.Name = "btn_selectSymbol";
            this.btn_selectSymbol.Size = new System.Drawing.Size(93, 23);
            this.btn_selectSymbol.TabIndex = 19;
            this.btn_selectSymbol.Text = "Select Stock";
            this.btn_selectSymbol.UseVisualStyleBackColor = true;
            this.btn_selectSymbol.Click += new System.EventHandler(this.btn_selectSymbol_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Result";
            // 
            // btn_addSearch
            // 
            this.btn_addSearch.Location = new System.Drawing.Point(11, 51);
            this.btn_addSearch.Name = "btn_addSearch";
            this.btn_addSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_addSearch.TabIndex = 17;
            this.btn_addSearch.Text = "Search";
            this.btn_addSearch.UseVisualStyleBackColor = true;
            this.btn_addSearch.Click += new System.EventHandler(this.btn_addSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Add new stock to Watchlist (Search for Symbol)";
            // 
            // tb_addSearch
            // 
            this.tb_addSearch.Location = new System.Drawing.Point(11, 25);
            this.tb_addSearch.Multiline = true;
            this.tb_addSearch.Name = "tb_addSearch";
            this.tb_addSearch.Size = new System.Drawing.Size(260, 20);
            this.tb_addSearch.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(11, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 1);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btn_addStock
            // 
            this.btn_addStock.Location = new System.Drawing.Point(11, 480);
            this.btn_addStock.Name = "btn_addStock";
            this.btn_addStock.Size = new System.Drawing.Size(138, 23);
            this.btn_addStock.TabIndex = 24;
            this.btn_addStock.Text = "Add Stock to Portfolio";
            this.btn_addStock.UseVisualStyleBackColor = true;
            this.btn_addStock.Click += new System.EventHandler(this.btn_addStock_Click);
            // 
            // tb_amount
            // 
            this.tb_amount.Location = new System.Drawing.Point(11, 331);
            this.tb_amount.Multiline = true;
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(260, 20);
            this.tb_amount.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Selected Stock";
            // 
            // tb_selectedStock
            // 
            this.tb_selectedStock.Location = new System.Drawing.Point(11, 279);
            this.tb_selectedStock.Multiline = true;
            this.tb_selectedStock.Name = "tb_selectedStock";
            this.tb_selectedStock.ReadOnly = true;
            this.tb_selectedStock.Size = new System.Drawing.Size(260, 20);
            this.tb_selectedStock.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Average Buy Price";
            // 
            // tb_avgPrice
            // 
            this.tb_avgPrice.Location = new System.Drawing.Point(11, 384);
            this.tb_avgPrice.Multiline = true;
            this.tb_avgPrice.Name = "tb_avgPrice";
            this.tb_avgPrice.Size = new System.Drawing.Size(260, 20);
            this.tb_avgPrice.TabIndex = 29;
            // 
            // tb_fees
            // 
            this.tb_fees.Location = new System.Drawing.Point(11, 437);
            this.tb_fees.Multiline = true;
            this.tb_fees.Name = "tb_fees";
            this.tb_fees.Size = new System.Drawing.Size(260, 20);
            this.tb_fees.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Fees (leave empty if there were none)";
            // 
            // frm_IvAddStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 231);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_fees);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_avgPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_selectedStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_amount);
            this.Controls.Add(this.btn_addStock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_language);
            this.Controls.Add(this.lb_searchResult);
            this.Controls.Add(this.btn_selectSymbol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_addSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_addSearch);
            this.Name = "frm_IvAddStocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IVAddStocks";
            this.Load += new System.EventHandler(this.frm_IvAddStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_language;
        private System.Windows.Forms.ListBox lb_searchResult;
        private System.Windows.Forms.Button btn_selectSymbol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_addSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_addSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_addStock;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_selectedStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_avgPrice;
        private System.Windows.Forms.TextBox tb_fees;
        private System.Windows.Forms.Label label7;
    }
}