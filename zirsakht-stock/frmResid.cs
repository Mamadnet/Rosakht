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
            var sql = (from s in lq.tblResids
                       select s
                    );
            dataGridView1.DataSource = sql;
        }

        private void frmResid_Load(object sender, EventArgs e)
        {

        }
    }
}
