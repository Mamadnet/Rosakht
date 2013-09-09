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
        int resid;
        public frmImported()
        {

            InitializeComponent();
            
            resid = (int)lq.fnGetResidNO();
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

            var anbarquery = (from s in lq.tblAnbars
                              where s.ID>1
                             select s);
            cmbAnbar.DisplayMember = "title";
            cmbAnbar.ValueMember = "ID";
            cmbAnbar.DataSource = anbarquery;

            var kharidquery = (from s in lq.tblSubCategories
                               where s.catID == 2
                               select s).ToList();
            cmbKharidType.DisplayMember = "Title";
            cmbKharidType.ValueMember = "ID";
            cmbKharidType.DataSource = kharidquery.ToArray();




            _cmbequipments();
        }
        private void _Fillgrid()
        {

            var sql = (from s in lq.tblResids
                       join p in lq.tblRecieveds on s.ResidNo equals p.ResidNo
                    
                       select new { contractno = s.ContractNO, kharidtype = s.kharidType, unit = p.tblEquipment.tblUnit.Unit, ID = s.ID,pid=p.ID, equipid = p.EquipID, partnumber = p.PartNumber, tedad = p.Tedad, date = s.Date, receivedby = s.ReceivedBy, description = s.Description, ersal = s.Ersal });
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

            var a = (from c in lq.tblResids
                     where c.ResidNo.Equals(resid.ToString())
                     select c).First();
            a.ResidNo = txtResid.Text;
            if(a.ID!=null)
            lq.SubmitChanges();



            if (int.Parse(txtTedad.Text) > 0)
            {

                tblRecieved b = new tblRecieved();
                // a.DeliverTo = 1;
                b.PartNumber = txtPartNum.Text;
                b.EquipID = Convert.ToInt32(cmbEquipments.SelectedValue.ToString()) == -1 ? eqid.ID : Convert.ToInt32(cmbEquipments.SelectedValue.ToString());
                b.Tedad = Convert.ToInt32((txtTedad.Text));
                b.ResidNo = txtResid.Text;
                lq.tblRecieveds.InsertOnSubmit(b);
                lq.SubmitChanges();
            }
            else
            {
                MessageBox.Show("لطفا تمام موارد را تکمیل نمایید");
            }


            _Fillgrid(); 
        }

        private void frmImported_Load(object sender, EventArgs e)
        {
            txtPartNum.Text = cmbEquipments.Text;
            tblResid a = new tblResid();
            // a.DeliverTo = 1;
            a.issued = false;
            a.ResidNo = resid.ToString();
            a.kharidType = 4;   //   4 یعنی ورورد از انبار    
            a.kharid = false;
            a.AnbarID = 2;
            lq.tblResids.InsertOnSubmit(a);
            lq.SubmitChanges();

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
                int _row = Convert.ToInt32(row.Cells["pid"].Value.ToString());
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

        private void btnResid_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                var a = (from c in lq.tblResids
                         where c.ResidNo.Equals(txtResid.Text)
                         select c).First();
                // a.DeliverTo = 1;
                a.kharid = false;
                a.kharidType = int.Parse(cmbKharidType.SelectedValue.ToString());
                if (int.Parse(cmbKharidType.SelectedValue.ToString()) == 5)  //  5 عودتی
                    a.Returned = true;
                else
                    a.Returned = false;

                a.Description = txtDesc.Text;
                a.Ersal = txtersal.Text;
                a.ReceivedBy = txtPerson.Text;
                a.Date = (new PersianDate(DateTime.Now)).ToString();
                a.AnbarID = Convert.ToInt32(cmbAnbar.SelectedValue.ToString());
                
                a.ResidNo = txtResid.Text;
                a.issued = true;
                lq.SubmitChanges();
                MessageBox.Show("رسید مورد نظر با موفقیت ثبت گردید");
                this.Close();

            }

            else
            {

                MessageBox.Show("هیچ کالایی ثبت نشده است");

            }
        }


        private void deleteALLZERO()
        {

            //var b = (from c in lq.tblRecieveds
            //         where c.tblResid.issued == false
            //         select c).ToList();

            //lq.tblRecieveds.DeleteAllOnSubmit(b);

            //lq.SubmitChanges();


            //var a = (from c in lq.tblResids
            //         where c.issued == false
            //         select c).ToList();
            //lq.tblResids.DeleteAllOnSubmit(a);

            //lq.SubmitChanges();



        }

        private void frmImported_FormClosing(object sender, FormClosingEventArgs e)
        {
            deleteALLZERO();
        }

        private void cmbKharidType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(cmbKharidType.SelectedValue.ToString()) == 4)
            {
                cmbAnbar.Visible = true;
                lblanbar.Visible = true;
                txtResid.Enabled = true;
                txtResid.Text = "";

            }
            else
            {
                cmbAnbar.Visible = false;
                lblanbar.Visible = false;

                txtResid.Enabled = false;
                txtResid.Text = resid.ToString();

            }

        }

    }
}
