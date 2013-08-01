using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Arash;
using System.Data.SqlClient;

namespace zirsakht_stock
{
    public partial class frmkardex : zirsakht_stock.template
    {
        lqStockDataContext lq = new lqStockDataContext();

        public frmkardex()
        {
            InitializeComponent();

            var sql = (from s in lq.vwKardes 
                             select s);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = sql;


            var typequery = (from s in lq.tblTypes
                             select s).ToList();
            cmbTypes.DisplayMember = "TypeDesc";
            cmbTypes.ValueMember = "ID";
            cmbTypes.DataSource = typequery.ToArray(); 
           
        }

        private void cmbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cmbequipments();

        }

        private void _cmbequipments()
        {
            var query = (from s in lq.tblEquipments
                         where s.tblType.ID == Convert.ToInt32(cmbTypes.SelectedValue)
                         select s).ToList();

            tblEquipment a = new tblEquipment();
            a.Partnumber = "سایر";
            a.ID = -1;
            query.Add(a);
            cmbEquipments.DisplayMember = "Partnumber";
            cmbEquipments.ValueMember = "ID";
            cmbEquipments.DataSource = query.ToArray();

        }

        private void cmbEquipments_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sql = (from s in lq.vwKardes
                       where s.equipid==Convert.ToInt32( cmbEquipments.SelectedValue)
                       select s);

            dataGridView1.DataSource = sql;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var sql = (from s in lq.vwKardes
                       where s.equipid == Convert.ToInt32(cmbEquipments.SelectedValue)
                       select s);
            frmKardexviewer m = new frmKardexviewer(sql);
            m.ShowDialog();
                
        }

       
    }
}
