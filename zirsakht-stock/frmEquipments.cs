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
    public partial class frmEquipments : zirsakht_stock.template
    {
        lqStockDataContext lq = new lqStockDataContext();
        public frmEquipments()
        {
            InitializeComponent();
            var typequery = (from s in lq.tblTypes
                             select s).ToList();
            cmbTypes.DisplayMember = "TypeDesc";
            cmbTypes.ValueMember = "ID";
            cmbTypes.DataSource = typequery.ToArray();


            var unitquery = (from s in lq.tblUnits
                             select s);
            cmbUints.DisplayMember = "Unit";
            cmbUints.ValueMember = "ID";
            cmbUints.DataSource = unitquery;
        }

        private void frmEquipments_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tblEquipment eq = new tblEquipment();
            eq.Partnumber = txtPartNum.Text+"***";
            eq.Type = Convert.ToInt32(cmbTypes.SelectedValue);
            eq.UnitID = Convert.ToInt32(cmbUints.SelectedValue);
            lq.tblEquipments.InsertOnSubmit(eq);
            lq.SubmitChanges();
            MessageBox.Show("کالای مورد نظر با موفقیت ثبت گردید");
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPartNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
