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
    public partial class template : Form
    {
        public template()
        {
            InitializeComponent();
        }

        private void template_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void template_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void template_Load(object sender, EventArgs e)
        {

        }
    }
}
