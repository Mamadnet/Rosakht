using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Arash;
using System.Data.SqlClient;

namespace zirsakht_stock
{
    public partial class frmResidItems : zirsakht_stock.template
    {
        lqStockDataContext lq = new lqStockDataContext();
        public frmResidItems(int residno)
        {
            InitializeComponent();
            var sql = (from s in lq.tblRecieveds
                       where s.ResidNo.Equals(residno.ToString())
                       select s
                   );
            dataGridView1.DataSource = sql;
        }

        private void frmResidItems_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }
    }
}
