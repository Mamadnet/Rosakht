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
    public partial class frmDeliverto : template
    {
        lqStockDataContext lq = new lqStockDataContext();
        public frmDeliverto()
        {
            InitializeComponent();
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
            a.Date = (new PersianDate(DateTime.Now)).ToString();
            a.Tedad = Convert.ToInt32((txtTedad.Text));
            a.EquipID = Convert.ToInt32(cmbEquipments.SelectedValue.ToString());
            
            lq.tblDelivereds.InsertOnSubmit(a);
            lq.SubmitChanges();

            _Fillgrid(); 
        }

        private void cmbEquipments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEquipments.SelectedValue.ToString() == "-1"){
                txtPartNum.Enabled = true;
                 }
            else
            {
                txtPartNum.Text = cmbEquipments.Text;
                txtPartNum.Enabled = false;
            }
            if (cmbEquipments.Items.Count >0)
                lblMojodi.Text = Convert.ToString(lq.CalculateTotal(Convert.ToInt32(cmbEquipments.SelectedValue.ToString())));
            else
                lblMojodi.Text = "";

        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        private void _cmbequipments()
        {


           // var m= lq.getkala_inanbar().
           
            var query = (from s in lq.tblEquipments
                         where s.tblType.ID == Convert.ToInt32(cmbTypes.SelectedValue)  && lq.CalculateTotal(s.ID)>0
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
    
    }
}
