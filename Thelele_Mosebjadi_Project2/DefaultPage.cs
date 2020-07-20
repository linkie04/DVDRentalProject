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
    public partial class DefaultPage : Form
    {
        public DefaultPage()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {  

            //validation code here


            UserLogin userlog = new UserLogin();

            userlog.Show();

            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {//validation code here 





            AdminLogin adminLog = new AdminLogin();

            adminLog.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void DefaultPage_Load(object sender, EventArgs e)
        {

        }
    }
}
