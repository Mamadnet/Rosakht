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
    public partial class frmkharid : template
    {
        lqStockDataContext lq = new lqStockDataContext();
        public frmkharid()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            _Fillgrid();

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

            var kharidquery = (from s in lq.tblSubCategories
                               where s.catID == 1
                               select s).ToList();
            cmbKharidType.DisplayMember = "Title";
            cmbKharidType.ValueMember = "ID";
            cmbKharidType.DataSource = kharidquery.ToArray();

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
            query.Reverse();
            cmbEquipments.DisplayMember = "Partnumber";
            cmbEquipments.ValueMember = "ID";
            cmbEquipments.DataSource = query.ToArray();

        }

        private void frmkharid_Load(object sender, EventArgs e)
        {
            
        }
        private void _Fillgrid()
        {

            var sql = (from s in lq.tblResids
                       select new { contractno=s.ContractNO,kharidtype = s.kharidType, unit = s.tblRecieved.tblEquipment.tblUnit.Unit, ID = s.ID, equipid = s.tblRecieved.EquipID, partnumber = s.PartNumber, tedad = s.Tedad, date = s.Date, receivedby = s.ReceivedBy, description = s.Description, ersal = s.Ersal });
            dataGridView1.DataSource = sql;
        }
       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbEquipments.SelectedValue) == -1)
            {
                tblEquipment eq = new tblEquipment();
                eq.Partnumber = txtPartNum.Text;
                eq.Type = Convert.ToInt32(cmbTypes.SelectedValue);
                eq.UnitID = Convert.ToInt32(cmbUints.SelectedValue);
                lq.tblEquipments.InsertOnSubmit(eq);
                lq.SubmitChanges();

            }
            var eqid = (from c in lq.tblEquipments
                        select c).OrderByDescending(x => x.ID).First();


            tblResid a = new tblResid();
            // a.DeliverTo = 1;
            a.kharid = true;
            a.ContractNO = txtGharardad.Text;
            a.kharidType = (int)cmbKharidType.SelectedValue;
            a.PartNumber = txtPartNum.Text;
            a.Description = txtDesc.Text;
            a.Ersal = txtdahandeh.Text;
            a.ReceivedBy = txtgirandeh.Text;
            a.Date = (new PersianDate(DateTime.Now)).ToString();
            a.Tedad = Convert.ToInt32((txtTedad.Text));
            lq.tblResids.InsertOnSubmit(a);
            lq.SubmitChanges();
          


            tblRecieved b = new tblRecieved();
            b.EquipID = Convert.ToInt32(cmbEquipments.SelectedValue.ToString()) == -1 ? eqid.ID : Convert.ToInt32(cmbEquipments.SelectedValue.ToString());
            lq.tblRecieveds.InsertOnSubmit(b);
            lq.SubmitChanges();



            _Fillgrid(); 
        }

        private void cmbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cmbequipments();
        }

        private void cmbEquipments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEquipments.SelectedValue.ToString() == "-1")
            {
                txtPartNum.Enabled = true;
                cmbUints.Visible = true;

            }
            else
            {
                txtPartNum.Text = cmbEquipments.Text;
                txtPartNum.Enabled = false;
                cmbUints.Visible = false;
            }
        }
    }
}
