namespace MyTrade
{
    partial class frm_IvRemoveStock
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
            this.lb_stocks = new System.Windows.Forms.ListBox();
            this.btn_removeStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_stocks
            // 
            this.lb_stocks.FormattingEnabled = true;
            this.lb_stocks.Location = new System.Drawing.Point(12, 12);
            this.lb_stocks.Name = "lb_stocks";
            this.lb_stocks.Size = new System.Drawing.Size(463, 121);
            this.lb_stocks.TabIndex = 3;
            // 
            // btn_removeStock
            // 
            this.btn_removeStock.Location = new System.Drawing.Point(12, 139);
            this.btn_removeStock.Name = "btn_removeStock";
            this.btn_removeStock.Size = new System.Drawing.Size(95, 23);
            this.btn_removeStock.TabIndex = 2;
            this.btn_removeStock.Text = "Remove Stock";
            this.btn_removeStock.UseVisualStyleBackColor = true;
            this.btn_removeStock.Click += new System.EventHandler(this.btn_removeStock_Click);
            // 
            // frm_IvRemoveStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 169);
            this.Controls.Add(this.lb_stocks);
            this.Controls.Add(this.btn_removeStock);
            this.Name = "frm_IvRemoveStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IVRemoveStock";
            this.Load += new System.EventHandler(this.IVRemoveStock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_stocks;
        private System.Windows.Forms.Button btn_removeStock;
    }
}