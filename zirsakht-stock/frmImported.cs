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
    public partial class frmImported : template
    {
        lqStockDataContext lq = new lqStockDataContext();
        public frmImported()
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




            _cmbequipments();
        }
        private void _Fillgrid()
        {

            var sql = (from s in lq.tblResids
                       select new { unit = s.tblRecieved.tblEquipment.tblUnit.Unit, ID = s.ID, equipid = s.tblRecieved.EquipID, partnumber = s.PartNumber, tedad = s.Tedad, date = s.Date, receivedby = s.ReceivedBy, description = s.Description,ersal=s.Ersal });
            dataGridView1.DataSource = sql;
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
            a.PartNumber = txtPartNum.Text;
            a.Description = txtDesc.Text;
            a.Ersal =txtersal.Text;
            a.ReceivedBy = txtPerson.Text;
            a.Date = (new PersianDate(DateTime.Now)).ToString();
           
            lq.tblResids.InsertOnSubmit(a);
            lq.SubmitChanges();

            var residno = (from c in lq.tblResids
                        select c).OrderByDescending(x => x.ID).First();



            tblRecieved b = new tblRecieved();
            // a.DeliverTo = 1;
            b.PartNumber = txtPartNum.Text;
            b.EquipID = Convert.ToInt32(cmbEquipments.SelectedValue.ToString()) == -1 ? eqid.ID : Convert.ToInt32(cmbEquipments.SelectedValue.ToString());
            b.Tedad = Convert.ToInt32((txtTedad.Text));
            b.ResidNo = residno.ID;

            lq.tblRecieveds.InsertOnSubmit(b);
            lq.SubmitChanges();


            _Fillgrid(); 
        }

        private void frmImported_Load(object sender, EventArgs e)
        {
            txtPartNum.Text = cmbEquipments.Text;

        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        private void cmbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cmbequipments();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _delete();
        }
        private void _delete()
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                //var rowview = row as DataGridViewRow;
                //tblDelivered _row = new tblDelivered();
                //_row = (tblDelivered)rowview.DataBoundItem;
                int _row = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                var sql = (from s in lq.tblRecieveds
                           where s.ID == _row
                           select s);
                if (_row > 0)
                {
                    try
                    {
                        lq.tblRecieveds.DeleteOnSubmit(sql.First());
                        lq.SubmitChanges();
                        _Fillgrid();
                    }
                    catch (SqlException)
                    {

                    }
                }
            }
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

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                _delete();

            }

        }

        private void txtTedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) != true && e.KeyChar != '\b')
                e.Handled = true;
         
        }
        
     


    }
}
