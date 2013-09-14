namespace zirsakht_stock
{
    partial class frmKardexviewer
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvKardex = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lqStockDataContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwKardeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //((System.ComponentModel.ISupportInitialize)(this.lqStockDataContextBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.vwKardeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvKardex
            // 
            this.rvKardex.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dskardex";
            reportDataSource1.Value = this.lqStockDataContextBindingSource;
            this.rvKardex.LocalReport.DataSources.Add(reportDataSource1);
            this.rvKardex.LocalReport.ReportEmbeddedResource = "zirsakht_stock.Report1.rdlc";
            this.rvKardex.Location = new System.Drawing.Point(0, 0);
            this.rvKardex.Name = "rvKardex";
            this.rvKardex.Size = new System.Drawing.Size(892, 373);
            this.rvKardex.TabIndex = 0;
            // 
            // lqStockDataContextBindingSource
            // 
            this.lqStockDataContextBindingSource.DataSource = typeof(zirsakht_stock.lqStockDataContext);
            // 
            // vwKardeBindingSource
            // 
            this.vwKardeBindingSource.DataSource = typeof(zirsakht_stock.vwKarde);
            // 
            // frmKardexviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(892, 373);
            this.Controls.Add(this.rvKardex);
            this.Name = "frmKardexviewer";
            this.Text = "کاردکس";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKardexviewer_FormClosing);
            this.Load += new System.EventHandler(this.frmKardexviewer_Load);
            //((System.ComponentModel.ISupportInitialize)(this.lqStockDataContextBindingSource)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.vwKardeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvKardex;
        private System.Windows.Forms.BindingSource vwKardeBindingSource;
        private System.Windows.Forms.BindingSource lqStockDataContextBindingSource;
    }
}
