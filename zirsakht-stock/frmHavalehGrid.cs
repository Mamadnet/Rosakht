using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;
using System.Threading;
using FarsiLibrary.Utils;
using FarsiLibrary.Utils.Internals;



namespace zirsakht_stock
{
    
    public partial class frmHavalehGrid : zirsakht_stock.template
    {
        lqStockDataContext lq = new lqStockDataContext();
        object sql;
        CultureInfo oldValue;
        public frmHavalehGrid()
        {
            InitializeComponent();
           dataGridView1.AutoGenerateColumns = false;
            var sql = (from s in lq.tblDelivereds
                       select new { havalehno = s.HavalehNO, partnumber = s.PartNumber, site = s.tblSite.Name, tedad = s.Tedad, date = s.Date, agent = s.Agent, description = s.Description, amvalno = s.Amvalno, temp = s.Temp, residno = s.ResidNo }
                    );
            if (sql.Count() > 0)
            {
                dataGridView1.DataSource = sql;
            }

            var querysites = (from s in lq.tblSites
                              orderby s.Ostan
                              select s).ToList();
            tblSite a = new tblSite();
            a.Name = "همه";
            a.ID = -1;
            querysites.Add(a);
            querysites.Reverse();
            cmbSites.DisplayMember = "name";
            cmbSites.ValueMember = "ID";
            cmbSites.DataSource = querysites.ToArray();

            oldValue = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            
        }

        private void frmHavalehGrid_FormClosing(object sender, FormClosingEventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = oldValue;
            Thread.CurrentThread.CurrentUICulture = oldValue;
        }
         

//set Persian option to specified culture
            
//PersianCultureHelper.SetPersianOptions(info);
     

        private void frmHavalehGrid_Load(object sender, EventArgs e)
        {
            faStart.SelectedDateTime = DateTime.Now.Date;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime m = DateTime.Now.Date;
            if (cmbReturned.Checked)
                sql = (from s in lq.tblDelivereds
                       where s.ResidNo.Contains(txtresidno.Text) && s.ReceivedBy.Contains(txtErsal.Text) 
                       && s.Temp == cmbReturned.Checked 
                       && (s.SiteID == int.Parse(cmbSites.SelectedValue.ToString()) || int.Parse(cmbSites.SelectedValue.ToString()) == -1) 
                       && (faStart.SelectedDateTime == null || faStart.SelectedDateTime < s.dateadded) 
                       && (faEnd.SelectedDateTime > s.dateadded || faEnd.SelectedDateTime == null)
                       select new { havalehno = s.HavalehNO, partnumber = s.PartNumber, site = s.tblSite.Name, tedad = s.Tedad, date = s.Date, agent = s.Agent, description = s.Description, amvalno = s.Amvalno, temp = s.Temp, residno = s.ResidNo }
                       );
            else
                sql = (from s in lq.tblDelivereds
                       // join rs in lq.tblRecieveds on s.ResidNo.Contains("kk") 
                       where s.ResidNo.Contains(txtresidno.Text) && s.ReceivedBy.Contains(txtErsal.Text)
                       && s.PartNumber.Contains(txtPart.Text)
                       && (s.SiteID == int.Parse(cmbSites.SelectedValue.ToString()) || int.Parse(cmbSites.SelectedValue.ToString()) == -1)
                       && (faStart.SelectedDateTime == null || faStart.SelectedDateTime < s.dateadded)
                       && (faEnd.SelectedDateTime > s.dateadded || faEnd.SelectedDateTime == null)
                       select new {havalehno=s.HavalehNO, partnumber=s.PartNumber,site=s.tblSite.Name,tedad=s.Tedad,date=s.Date,agent=s.Agent,description=s.Description,amvalno=s.Amvalno,temp=s.Temp,residno=s.ResidNo }
                   );


            dataGridView1.DataSource = sql;
        }

        private void frmHavalehGrid_Load_1(object sender, EventArgs e)
        {
            faStart.SelectedDateTime = DateTime.Now;
            faEnd.SelectedDateTime = DateTime.Now;
       
        }

        private void faStart_SelectedDateTimeChanging(object sender, FarsiLibrary.Win.Events.SelectedDateTimeChangingEventArgs e)
        {
            PersianDate pd = e.NewValue;
            DateTime m;

            //DateTime m = new DateTime(pd.Year, pd.Month, pd.Day);
            if(pd!=null)
                      m = PersianDateConverter.ToGregorianDateTime(pd);


        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var sql = (from s in lq.vwHavalehs
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
