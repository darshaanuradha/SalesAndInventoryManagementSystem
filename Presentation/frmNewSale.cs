using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMS.Presentation
{
    public partial class frmNewSale : Form
    {
        public frmNewSale()
        {
            InitializeComponent();
        }
        private void btnBackDash_Click(object sender, EventArgs e)
        {
            frmDashboard frmDashboard = new frmDashboard();
            frmDashboard.Show();
            this.Hide();
        }
    }
}
