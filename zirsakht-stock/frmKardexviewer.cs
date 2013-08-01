using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace zirsakht_stock
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
            
            this.rvKardex.RefreshReport();
        }
    }
}
