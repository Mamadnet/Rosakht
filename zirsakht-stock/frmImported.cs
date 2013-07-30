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


            _cmbequipments();
        }
        private void _Fillgrid()
        {

            var sql = (from s in lq.tblRecieveds
                       select new { unit = s.tblEquipment.tblUnit.Uint, ID = s.ID, equipid = s.EquipID, partnumber = s.PartNumber, tedad = s.Tedad, date = s.Date, receivedby = s.ReceivedBy, description = s.Description });
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
            cmbEquipments.DisplayMember = "Partnumber";
            cmbEquipments.ValueMember = "ID";
            cmbEquipments.DataSource = query.ToArray();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            tblRecieved a = new tblRecieved();
            // a.DeliverTo = 1;
            a.PartNumber = txtPartNum.Text;
            a.Description = txtDesc.Text;
            a.Source = txtPerson.Text;
            a.ReceivedBy = txtAgent.Text;
            a.Date = (new PersianDate(DateTime.Now)).ToString();
            a.Tedad = Convert.ToInt32((txtTedad.Text));
            a.EquipID = Convert.ToInt32(cmbEquipments.SelectedValue.ToString());
            lq.tblRecieveds.InsertOnSubmit(a);
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
            }
            else
            {
                txtPartNum.Text = cmbEquipments.Text;
                txtPartNum.Enabled = false;
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
