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
    public partial class frmResidIN_Havaleh : zirsakht_stock.template
    {
        public string _residnoHavaleh { get; private set; }
        public string _EquipidHavaleh { get; private set; }
        public string _typeidHavaleh { get; private set; }
        lqStockDataContext lq = new lqStockDataContext();
        public frmResidIN_Havaleh(object sql)
        {
            InitializeComponent();
            dataGridView1.DataSource = sql;
           

        }

        private void frmResidIN_Havaleh_Load(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             _residnoHavaleh = dataGridView1.SelectedRows[e.RowIndex].Cells["residno"].Value.ToString();
             _EquipidHavaleh = dataGridView1.SelectedRows[e.RowIndex].Cells["partnumber"].Value.ToString();
             string equipid = dataGridView1.SelectedRows[e.RowIndex].Cells["equipid"].Value.ToString();

             var sql = (from s in lq.tblEquipments
                        where s.ID == int.Parse(equipid)
                        select s);
             _typeidHavaleh = sql.First().tblType.TypeDesc.ToString();
             this.Close();
        }
    }
}
