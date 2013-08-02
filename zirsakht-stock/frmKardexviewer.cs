using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Arash;

using Microsoft.Reporting.WinForms;namespace zirsakht_stock
{
    public partial class frmKardexviewer : zirsakht_stock.template
    {
        object datasrc;
        public frmKardexviewer(object var)
        {
            InitializeComponent();
            datasrc = var;
        }

        private void frmKardexviewer_Load(object sender, EventArgs e)
        {
            lqStockDataContextBindingSource.DataSource = datasrc;
            ReportParameter printdate = new ReportParameter("PrintDate",new Arash.PersianDate( DateTime.Now).ToString() );
            this.rvKardex.LocalReport.SetParameters(new ReportParameter[] { printdate });
            
            this.rvKardex.RefreshReport();
        }

        private void frmKardexviewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            rvKardex.LocalReport.ReleaseSandboxAppDomain();

        }
    }
}
