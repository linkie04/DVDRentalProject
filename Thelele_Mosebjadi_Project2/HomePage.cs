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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void lblBanner_Click(object sender, EventArgs e)
        {

        }

        private void btnRentMovie_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentDVD rent = new RentDVD();

            rent.Show();
          
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin ulog = new UserLogin();

            ulog.Show();

}

        private void btnViewLatest_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewLatest view = new ViewLatest();

            view.Show();

          
        }
    }
}
