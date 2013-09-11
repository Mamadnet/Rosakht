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
    public partial class frmResid : zirsakht_stock.template
    {
        lqStockDataContext lq = new lqStockDataContext();

        public frmResid()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            var sql = (from s in lq.tblResids
                       select s
                    );
            dataGridView1.DataSource = sql;
        }

        private void frmResid_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int _row = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["residno"].Value.ToString());

            frmResidItems m = new frmResidItems(_row);
            m.ShowDialog();
        }
    }
}
