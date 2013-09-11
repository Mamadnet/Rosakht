using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace zirsakht_stock
{
    
    public partial class frmHavalehGrid : zirsakht_stock.template
    {
        lqStockDataContext lq = new lqStockDataContext();
        public frmHavalehGrid()
        {
            InitializeComponent();
            //dataGridView1.AutoGenerateColumns = false;
            //var sql = (from s in lq.tblDelivereds
            //           select s
            //        );
            //dataGridView1.DataSource = sql;
        }

        private void frmHavalehGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
