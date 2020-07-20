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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DefaultPage def = new DefaultPage();

            def.Show();

            this.Hide();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string adName, Adpass;

            adName = txtAdname.Text;
            Adpass = txtAdPassword.Text;

            if (adName == "lmonyela" && Adpass == "admin1234")
            {
                ActiveForm.Hide();
                AdminHome AdHome = new AdminHome();
                AdHome.Show();
                


            }
            else
            {
                MessageBox.Show("Incorrect details entered. Try again", "Jiba's Movie Rental", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
