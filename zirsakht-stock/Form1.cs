using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Deployment.Application;



namespace zirsakht_stock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         

           
            
            
        }

        private void خروجازانبارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeliverto frmD = new frmDeliverto();
            frmD.ShowDialog();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ورودبهانبارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImported frmD = new frmImported();
            frmD.ShowDialog();
        }

        private void کاردکسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkardex m = new frmkardex();
            m.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void ثبتخریدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkharid frmD = new frmkharid();
            frmD.ShowDialog();

        }

        private void رسیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResid frmD = new frmResid();
            frmD.ShowDialog();
        }

        private void کالایجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEquipments frmD = new frmEquipments();
            frmD.ShowDialog();
        }

        private void تعریفانبارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnbar a = new frmAnbar();
            a.ShowDialog();
        }

        private void گزارشToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void حوالهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHavalehGrid m = new frmHavalehGrid();
            m.ShowDialog();
        }

        private void دربارهToolStripMenuItem_Click(object sender, EventArgs e)
        {
           try
            {
                ApplicationDeployment deploy = ApplicationDeployment.CurrentDeployment;
                UpdateCheckInfo update = deploy.CheckForDetailedUpdate();
                MessageBox.Show("نسخه : " + deploy.CurrentVersion);
            }
            catch
            {
            }

        }

        private void فایلToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
       
    }
}
