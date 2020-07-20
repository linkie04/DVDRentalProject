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
    public partial class ViewLatest : Form
    {
        public ViewLatest()
        {
            InitializeComponent();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage goback = new HomePage();
            goback.Show();

        }
    }
}
