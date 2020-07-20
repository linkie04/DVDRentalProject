using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Thelele_Mosebjadi_Project2
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDVD update = new UpdateDVD();

            update.Show();
            this.Hide();

           
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminLogin log = new AdminLogin();
            log.Show();
            this.Close();
        }
    }
}
