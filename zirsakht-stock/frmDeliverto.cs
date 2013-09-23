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
    public partial class frmDeliverto : template
    {
        
        lqStockDataContext lq = new lqStockDataContext();
        int havalehno;
        public frmDeliverto()
        {
            InitializeComponent();

            havalehno =(int) lq.fnGetHavalehNO();
            dataGridView1.AutoGenerateColumns = false;
            _Fillgrid();

            var typequery = (from s in lq.tblTypes
                         select s).ToList();
            cmbTypes.DisplayMember = "TypeDesc";
            cmbTypes.ValueMember = "ID";
            cmbTypes.DataSource = typequery.ToArray();   

           // var query = (from s in lq.tblEquipments
           //              where s.tblType.ID== Convert.ToInt32( cmbTypes.SelectedValue.ToString())
           //              select s).ToList();
           // tblEquipment a = new tblEquipment();
           // a.Partnumber = "سایر";
           // a.ID = -1;
           //query.Add(a);
           //cmbEquipments.DisplayMember = "Partnumber";
           //cmbEquipments.ValueMember = "ID";

           // cmbEquipments.DataSource = query.ToArray();



            var querysites = (from s in lq.tblSites
                              orderby s.Ostan
                         select new { NM=s.Ostan+" "+s.Name,s.ID }).ToList();
            cmbSites.DisplayMember = "NM";
            cmbSites.ValueMember = "ID";
            cmbSites.DataSource = querysites.ToArray();


            _cmbequipments();
            
        }

        private void frmDeliverto_Load(object sender, EventArgs e)
        {
            txtPartNum.Text = cmbEquipments.Text;
            this.ActiveControl = txtResid;
            txtResid.Focus();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           lqStockDataContext lq = new lqStockDataContext();
            tblDelivered a = new tblDelivered();
            // a.DeliverTo = 1;
            a.PartNumber = txtPartNum.Text;
            a.Description = txtDesc.Text;
            a.ReceivedBy = txtPerson.Text;
            a.Agent = txtAgent.Text;
            a.SiteID =Convert.ToInt32( cmbSites.SelectedValue.ToString() );
            a.Date =DateTime.Now.ToPersianDate().ToString("d");
            a.Tedad = Convert.ToInt32((txtTedad.Text));
            a.EquipID = Convert.ToInt32(cmbEquipments.SelectedValue.ToString());
            a.Amvalno = txtAmval.Text;
            a.Temp = cmbTemp.Checked;
            a.ResidNo = txtResid.Text;
            a.dateadded = DateTime.Now;
            a.IdentificationNO = txtIdent.Text;
            a.HavalehNO = havalehno.ToString();
            a.UserID =int.Parse( frmLogin._usercode);
            lq.tblDelivereds.InsertOnSubmit(a);
            lq.SubmitChanges();
            MessageBox.Show("کالای مورد نظر با موفقیت ثبت گردید");
            btnAdd.Enabled = false;
            _Fillgrid();
            if (cmbEquipments.Items.Count > 0)
                lblMojodi.Text = Convert.ToString(lq.fnCalculateTotal(Convert.ToInt32(cmbEquipments.SelectedValue.ToString())));
            else
                lblMojodi.Text = "";
            btnReport.Enabled = true;

            reset_controls();
            txtResid.Focus();
            logEvents.RegEvent((int)logEvents.Actions.Issued_Havale, int.Parse(frmLogin._usercode), "ثبت حواله");
        }

        private void reset_controls()
        {
            txtAmval.Text = "";
            txtDesc.Text = "";
            txtIdent.Text = "";
            txtTedad.Text = "0";
            
        }


        private void cmbEquipments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEquipments.SelectedValue.ToString() == "-1"){
                txtPartNum.Enabled = true;
                 }
            else
            {
                var sql = (from s in lq.tblRecieveds
                           where s.EquipID==int.Parse(cmbEquipments.SelectedValue.ToString())
                           select s
                     );
                txtResid.Text = sql.First().ResidNo;
                txtPartNum.Text = cmbEquipments.Text;
                txtPartNum.Enabled = false;
            }
            if (cmbEquipments.Items.Count >0)
                lblMojodi.Text = Convert.ToString(lq.fnCalculateTotal(Convert.ToInt32(cmbEquipments.SelectedValue.ToString())));
            else
                lblMojodi.Text = "";

        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        private void _cmbequipments()
        {


          
            var query = (from s in lq.tblEquipments
                         where s.tblType.ID == Convert.ToInt32(cmbTypes.SelectedValue)  && lq.fnCalculateTotal(s.ID)>0
                         select s).ToList();

            
            //tblEquipment a = new tblEquipment();
            //a.Partnumber = "سایر";
            //a.ID = -1;
            //query.Add(a);
            cmbEquipments.DisplayMember = "Partnumber";
            cmbEquipments.ValueMember = "ID";
            cmbEquipments.DataSource = query.ToArray();

        }

        private void cmbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMojodi.Text = "";
            _cmbequipments();
        }

        private void _Fillgrid()
        {

            var sql = (from s in lq.tblDelivereds
                      select new {unit=s.tblEquipment.tblUnit.Unit, ID=s.ID,equipid=s.EquipID,siteid=s.SiteID,partnumber = s.PartNumber, tedad = s.Tedad, agent = s.Agent, date = s.Date, receivedby = s.ReceivedBy, description = s.Description, name = s.tblSite.Name }
                      );
            dataGridView1.DataSource = sql;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                //var rowview = row as DataGridViewRow;
                //tblDelivered _row = new tblDelivered();
                //_row = (tblDelivered)rowview.DataBoundItem;
                int _row =Convert.ToInt32( row.Cells["ID"].Value.ToString());
                var sql = (from s in lq.tblDelivereds
                           where s.ID == _row
                           select s);
                if (_row != null)
                {
                    try
                    {
                        lq.tblDelivereds.DeleteOnSubmit(sql.First());
                        lq.SubmitChanges();
                        _Fillgrid();
                    }
                    catch (SqlException)
                    {

                    }
                }
            }
        }

        private void txtTedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) != true && e.KeyChar != '\b')
                e.Handled = true;

           

        }

        

        private void txtResid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) != true && e.KeyChar != '\b')
                e.Handled = true;

            if (e.KeyChar == '\r')
            {


                var sql = (from s in lq.tblRecieveds
                           where s.ResidNo.Contains(txtResid.Text) && lq.fnCalculateTotal(s.EquipID)>0
                           select s
                     );

                if (sql.Count() > 0)
                {

                    frmResidIN_Havaleh m = new frmResidIN_Havaleh(sql);
                    m.ShowDialog();
                    if (m._residnoHavaleh != null)
                    {
                        txtResid.Text = m._residnoHavaleh;
                        cmbTypes.SelectedIndex = cmbTypes.FindStringExact(m._typeidHavaleh);
                        cmbEquipments.SelectedIndex = cmbEquipments.FindStringExact(m._EquipidHavaleh);
                    }
                }
            }
        }

        private void txtTedad_Validating(object sender, CancelEventArgs e)
        {
            TextBox m=(TextBox)sender;
            if (int.Parse(m.Text) > int.Parse(lblMojodi.Text))
            {
                errorProvider1.SetError(m, "تعداد تحویل کالا از موجودی بیشتر است");
                btnAdd.Enabled = false;
            }

            else
            {
                errorProvider1.SetError(m, "");
                btnAdd.Enabled = true;

            }


        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var sql = (from s in lq.vwHavalehs
                       where s.HavalehNO.Equals(havalehno)
                       select s
                   ).ToList();
            vwHavaleh f = new vwHavaleh();

            if (sql.Count() < 9)
            {
                for (int i = sql.Count(); i < 9; i++)
                    sql.Add(f);

            }
            frHavalehreport m = new frHavalehreport(sql);
            m.ShowDialog();
        }

       
    }
}
