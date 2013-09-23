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
    public partial class frmResidEquipselection : zirsakht_stock.template
    {
        public string _EquipidHavaleh { get; private set; }
        public string _typeidHavaleh { get; private set; }
        lqStockDataContext lq = new lqStockDataContext();
        public frmResidEquipselection(object sql)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = sql;
        }

        private void frmResidEquipselection_Load(object sender, EventArgs e)
        {
         //   MessageBox.Show("");

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _EquipidHavaleh = dataGridView1.SelectedRows[0].Cells["partnumber"].Value.ToString();
            string equipid = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();


            var sql = (from s in lq.tblEquipments
                       where s.ID == int.Parse(equipid)
                       select s);
            _typeidHavaleh = sql.First().tblType.TypeDesc.ToString();
            this.Close();
        }
    }
}
