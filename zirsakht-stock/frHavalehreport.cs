using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace zirsakht_stock
{
    public partial class frHavalehreport : Form
    {
        object datasrc;

        public frHavalehreport(object var)
        {
            InitializeComponent();
            datasrc = var;
        }

        private void frHavalehreport_Load(object sender, EventArgs e)
        {
            //if()
            vwHavalehBindingSource.DataSource = datasrc;
            this.reportViewer1.RefreshReport();
        }
    }
}
