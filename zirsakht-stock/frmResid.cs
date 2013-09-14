using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Globalization;
using System.Threading;
using FarsiLibrary.Utils;
using FarsiLibrary.Utils.Internals;

namespace zirsakht_stock
{
    public partial class frmResid : zirsakht_stock.template
    {
        lqStockDataContext lq = new lqStockDataContext();
        object sql;
        CultureInfo oldValue;

        public frmResid()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            sql = (from s in lq.tblResids
                       select s
                    );
            dataGridView1.DataSource = sql;
            oldValue = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            
        }

        private void frmResid_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int _row = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["residno"].Value.ToString());

            frmResidItems m = new frmResidItems(_row);
            m.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cmbReturned.Checked)
            sql = (from s in lq.tblResids
                   where s.ResidNo.Contains(txtresidno.Text) && s.Ersal.Contains(txtErsal.Text) 
                   && s.Returned == cmbReturned.Checked 
                   && s.tblRecieveds.Where(p => p.PartNumber.Contains(txtPart.Text)).Count() > 0 
                   && (s.ContractNO.Contains(txtgharar.Text) || s.ContractNO == null) 
                   && (faStart.SelectedDateTime == null || faStart.SelectedDateTime < s.dateadded) 
                   && (faEnd.SelectedDateTime > s.dateadded || faEnd.SelectedDateTime == null)
                       select s
                   );
            else
                sql = (from s in lq.tblResids
                       where s.ResidNo.Contains(txtresidno.Text) && s.Ersal.Contains(txtErsal.Text) 
                       && s.tblRecieveds.Where(p => p.PartNumber.Contains(txtPart.Text)).Count() > 0 
                       && (s.ContractNO.Contains(txtgharar.Text) || s.ContractNO == null) 
                       && (faStart.SelectedDateTime == null || faStart.SelectedDateTime < s.dateadded) 
                       && (faEnd.SelectedDateTime > s.dateadded || faEnd.SelectedDateTime == null)
                       select s
                   );

            
            dataGridView1.DataSource = sql;

        }
                private void txtresidno_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
           
                //var f=(IQueryable<tblResid>)sql;
               
                //f=f.Where(p => p.ResidNo.Contains(txtresidno.Text));
                //dataGridView1.DataSource =f ;
           

        }

                private void txtErsal_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
                {
                    //var f = (IQueryable<tblResid>)sql;
                    

                    //    f = f.Where(p => p.Ersal.Contains(txtErsal.Text));
                    //    dataGridView1.DataSource = f;
                    

                }

                private void cmbReturned_CheckedChanged(object sender, EventArgs e)
                {
                   
                       
          
                }

                private void cmbReturned_CheckStateChanged(object sender, EventArgs e)
                {
                    //var f = (IQueryable<tblResid>)sql;
                    //if (cmbReturned.Enabled == true)
                    //{

                    //    f = f.Where(p => p.Returned == cmbReturned.Enabled);
                    //    dataGridView1.DataSource = f;
                    //}
                    //else
                    //{

                    //}

                }

                private void txtgharar_TextChanged(object sender, EventArgs e)
                {

                }

                private void frmResid_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
                {
                    Thread.CurrentThread.CurrentCulture = oldValue;
                    Thread.CurrentThread.CurrentUICulture = oldValue;
                }
    }
}
