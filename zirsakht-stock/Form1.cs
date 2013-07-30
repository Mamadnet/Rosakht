using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


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

       
       
    }
}
