using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq;
namespace zirsakht_stock
{
    public partial class frmAnbar : template
    {
        lqStockDataContext lq = new lqStockDataContext();
        public frmAnbar()
        {
            InitializeComponent();
        }

        private void frmAnbar_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tblAnbar eq = new tblAnbar();
            eq.Title = txtPartNum.Text;
            lq.tblAnbars.InsertOnSubmit(eq);
            lq.SubmitChanges();
            MessageBox.Show("کالای مورد نظر با موفقیت ثبت گردید");
            this.Close();
        }
    }
}
