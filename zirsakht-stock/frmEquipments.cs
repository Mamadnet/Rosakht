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


            dataGridView1.AutoGenerateColumns = false;
            var sql = (from s in lq.tblEquipments
                       select new {title=s.Partnumber,type=s.tblType.TypeDesc,unit=s.tblUnit.Unit });
            dataGridView1.DataSource = sql;
        }

        private void frmEquipments_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(txtPartNum, "فشردن دکمه اینتر برای لیست تجهیزات ");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tblEquipment eq = new tblEquipment();
            eq.Partnumber = txtPartNum.Text;
            eq.Type = Convert.ToInt32(cmbTypes.SelectedValue);
            eq.UnitID = Convert.ToInt32(cmbUints.SelectedValue);
            eq.UserID = int.Parse(frmLogin._usercode);
            lq.tblEquipments.InsertOnSubmit(eq);
            lq.SubmitChanges();
            MessageBox.Show("کالای مورد نظر با موفقیت ثبت گردید");
            //this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPartNum_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sql = (from s in lq.tblEquipments
                       where s.Type==int.Parse( cmbTypes.SelectedValue.ToString())
                       select new {partnumber=s.Partnumber, title = s.Partnumber, type = s.tblType.TypeDesc, unit = s.tblUnit.Unit });
            dataGridView1.DataSource = sql;
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
                        //  cmbEquipments.SelectedIndex = cmbEquipments.FindStringExact(m._EquipidHavaleh);
                    }
                }
            }
        }
    }
}
