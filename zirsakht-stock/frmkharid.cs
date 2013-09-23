using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FarsiLibrary.Utils;

namespace zirsakht_stock
{
    public partial class frmkharid : template
    {
        lqStockDataContext lq = new lqStockDataContext();
        int resid;
        public frmkharid()
        {
            
            InitializeComponent();
            deleteALLZERO();
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

            
            tblResid a = new tblResid();
            // a.DeliverTo = 1;
            a.issued = false;
            a.ResidNo = resid.ToString();
            a.kharid = true;
            a.kharidType = 1;
            lq.tblResids.InsertOnSubmit(a);
            lq.SubmitChanges();
            
        }
        private void _Fillgrid()
        {

            var sql = (from s in lq.tblResids
                       join p in lq.tblRecieveds on s.ResidNo equals p.ResidNo
                       where s.issued == false
                       select new {dateadded=p.dateadded,pid=p.ID, contractno=s.ContractNO,kharidtype = s.tblSubCategory.title, unit = p.tblEquipment.tblUnit.Unit, ID = s.ID, equipid = p.EquipID, partnumber = p.PartNumber, tedad = p.Tedad, date = s.Date, receivedby = s.ReceivedBy, description = s.Description, ersal = s.Ersal });
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


            if (int.Parse(txtTedad.Text) > 0)
            {

                tblRecieved b = new tblRecieved();
                b.PartNumber = txtPartNum.Text;
                b.ResidNo = resid.ToString();
                b.Tedad = Convert.ToInt32((txtTedad.Text));
                b.EquipID = Convert.ToInt32(cmbEquipments.SelectedValue.ToString()) == -1 ? eqid.ID : Convert.ToInt32(cmbEquipments.SelectedValue.ToString());
                b.dateadded = DateTime.Now;
                lq.tblRecieveds.InsertOnSubmit(b);
                lq.SubmitChanges();
            }
            else
            {
                MessageBox.Show("لطفا تمام موارد را تکمیل نمایید");
            }
            _Fillgrid();


            cmbTypes.SelectedIndex = 0;
            txtTedad.Text = "0";
            txtDesc.Text = "";
            cmbTypes.Focus();
            
        }

        private void cmbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cmbequipments();
        }

        private void cmbEquipments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEquipments.SelectedValue!=null)
            {
            if (cmbEquipments.SelectedValue.ToString() == "-1")
            {
                txtPartNum.Enabled = true;
              //  cmbUints.Visible = true;

            }
            else
            {
                txtPartNum.Text = cmbEquipments.Text;
                txtPartNum.Enabled = false;
               // cmbUints.Visible = false;
            }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
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

        private void btnResid_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {

                var a = (from c in lq.tblResids
                         where c.ResidNo.Equals(resid.ToString())
                         select c).First();
                // a.DeliverTo = 1;
                a.kharid = true;
                a.ContractNO = txtGharardad.Text;
                a.kharidType = (int)cmbKharidType.SelectedValue;
                a.Description = txtDesc.Text;
                a.Ersal = txtdahandeh.Text;
                a.ReceivedBy = txtgirandeh.Text;
                a.Date = DateTime.Now.ToPersianDate().ToString("d");
                a.AnbarID = 1;
                a.ResidNo = resid.ToString();
                a.dateadded = DateTime.Now;
                a.issued = true;
                a.UserID = int.Parse(frmLogin._usercode);
                lq.SubmitChanges();
                MessageBox.Show("رسید مورد نظر با موفقیت ثبت گردید");
                this.Close();
                logEvents.RegEvent((int)logEvents.Actions.Register_Kharid, int.Parse(frmLogin._usercode), "ثبت خرید");

            }

            else
            {

                MessageBox.Show("هیچ کالایی ثبت نشده است");

            }


        }

        private void frmkharid_FormClosing(object sender, FormClosingEventArgs e)
        {
            deleteALLZERO();
           
        }

        private  void deleteALLZERO()
        {

            var b = (from c in lq.tblRecieveds
                     where c.tblResid.issued==false
                     select c).ToList();

            lq.tblRecieveds.DeleteAllOnSubmit(b);

            lq.SubmitChanges();


            var a = (from c in lq.tblResids
                     where c.issued==false
                     select c).ToList();
            lq.tblResids.DeleteAllOnSubmit(a);

            lq.SubmitChanges();



        }

        private void txtPartNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {


                var sql = (from s in lq.tblEquipments
                           where s.Partnumber.Contains(txtPartNum.Text)
                           select s
                     );

                if (sql.Count() > 0)
                {

                    frmResidEquipselection m = new frmResidEquipselection(sql);
                    m.ShowDialog();
                    if (m._EquipidHavaleh != null)
                    {
                        cmbTypes.SelectedIndex = cmbTypes.FindStringExact(m._typeidHavaleh);
                        cmbEquipments.SelectedIndex = cmbEquipments.FindStringExact(m._EquipidHavaleh);
                    }
                }
            }
        }

      
    }
}
