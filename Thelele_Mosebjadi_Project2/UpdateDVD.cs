using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Thelele_Mosebjadi_Project2
{
    public partial class UpdateDVD : Form
    {
        public UpdateDVD()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHome adHome = new AdminHome();

            adHome.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Booking book = new Booking();
            book.DvdName = txtDVDname.Text;
            book.DvdLength = txtDuration.Text;
            
            book.AgeRestrict = cboRestriction.Text;
            book.Genre = cboGenre.Text;
            txtPrice.Text = book.Price.ToString();

            string sline;

            sline = book.DvdName +";"+book.DvdLength +";"+ book.DvdLength+";" + book.Genre+";"+book.Price;
            StreamWriter add = new StreamWriter("DVD.txt", true);

            using(add)
            {
                add.WriteLine(sline);
            }
            MessageBox.Show("Information Added to file", "Jiba's Movie Rentals", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void UpdateDVD_Load(object sender, EventArgs e)
        {

        }
    }
}
