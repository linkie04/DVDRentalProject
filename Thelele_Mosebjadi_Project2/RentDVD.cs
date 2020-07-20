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
    public partial class RentDVD : Form
    {
        public RentDVD()
        {
            InitializeComponent();
            dgMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        //read dta from text file into data  grid view
        public class Helper
        {
            public static DataTable ReadTextFile(string location, char delimiter = ';')
            {
                DataTable result;

                string[] LineArray = File.ReadAllLines(location);

                result = FormDataTable(LineArray, delimiter);
                return result;
            }
            private static DataTable FormDataTable(string [] LineArray, char delimiter)
            {
                DataTable dt = new DataTable();

                AddColumn(LineArray, delimiter, ref dt);
                AddRow(LineArray, delimiter, ref dt);
                    return dt;
            }
            private static void AddRow(string [] valueCollection, char delimiter, ref DataTable dt)
            {
                for (int i = 1; i < valueCollection.Length; i++)
                {
                    string[] values = valueCollection[i].Split(delimiter);
                    DataRow dr = dt.NewRow();
                    for (int j = 0; j < values.Length; j++)
                    {
                        dr[j] = values[j];
                    }
                    dt.Rows.Add(dr);
                }
            }
            private static void AddColumn(string [] colCollection, char delimiter, ref DataTable dt)
            {
                string[] columns = colCollection[0].Split(delimiter);

                foreach(string colName in columns)
                {
                    DataColumn dc = new DataColumn(colName, typeof(string));
                    dt.Columns.Add(dc);
                }
            }
        }

      

        private void btnExitRent_Click(object sender, EventArgs e)
        {
            UserLogin log = new UserLogin();

            log.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear alles
            rchInvoice.Clear();
            txtAgeRes.Clear();
            txtDuration.Clear();
            txtGenre.Clear();
            txtMovie.Clear();
           chkExRental.Checked =false;
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RentDVD_Load(object sender, EventArgs e)
        {
        //    StreamReader readcol = new StreamReader("DVD.txt");
        //    string col = readcol.ReadLine();

        //    string[] colArray = col.Split(';');
        //    List<string> columnNames = new List<string>();
        //    foreach (string b in colArray)
        //    {
        //        columnNames.Add(b);
        //    }

        //    dgMovies.DataSource = columnNames;

        ////    dgv_movies.DataSource = dvdListAdventure;


          //  dgMovies.ColumnCount = 4;
         

            dgMovies.DataSource = Helper.ReadTextFile("DVD.txt");

               txtAgeRes.Clear();
            txtDuration.Clear();
            txtGenre.Clear();
            txtMovie.Clear();
            rchInvoice.Clear();
            txtPrice.Text = "55";
            chkExRental.Checked = false;


           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // Avengers:Infinity War;2:23;13VL;Sci-Fi;55
            //Movie;Duration;Age Restriction;Genre;0
            txtMovie.Text = dgMovies.SelectedRows[0].Cells["Movie"].Value.ToString();
            txtDuration.Text = dgMovies.SelectedRows[0].Cells["Duration"].Value.ToString();
            txtAgeRes.Text = dgMovies.SelectedRows[0].Cells["Age Restriction"].Value.ToString();
            txtGenre.Text = dgMovies.SelectedRows[0].Cells["Genre"].Value.ToString();



        }

        private void txtMovie_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void rchInvoice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
          //  //add invoice to text file

          //  DVD saveInvoice = new Booking();

          //  StreamWriter save = new StreamWriter("invoices.txt");
          //  using (save)
          //  {
          //      save.WriteLine(saveInvoice.SaveInvoice());
          //  }
          ////  saveInvoice.SaveInvoice();

          //  MessageBox.Show("Information Added to file", "Jiba's Movie Rentals", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            DVD inv = new Booking();

            inv.DvdName = txtMovie.Text;
            inv.DvdLength = txtDuration.Text;
            inv.AgeRestrict = txtAgeRes.Text;

            if (chkExRental.Checked)
            {
               inv.Price = double.Parse(txtPrice.Text) + 35.99;
               txtPrice.Text = inv.Price.ToString();
            }
            else
            {
                inv.Price = double.Parse(txtPrice.Text);
                txtPrice.Text = inv.Price.ToString();
            }

            dtpDate.Value = DateTime.Now;
            inv.RentDate = dtpDate.Value;
            inv.Price = double.Parse(txtPrice.Text);
           // string usernaam;

            //Login getname = new Login();

            //usernaam = getname.Username;
           rchInvoice.AppendText(String.Format("{0} \n{1}",inv.CreateInvoice(),Environment.NewLine));

           //add invoice to text file

          // DVD saveInvoice = new Booking();

           StreamWriter save = new StreamWriter("invoices.txt", true);
           using (save)
           {
               save.WriteLine(inv.SaveInvoice());
           }
           //  saveInvoice.SaveInvoice();

           MessageBox.Show("Information Added to file", "Jiba's Movie Rentals", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
           // double price;
            
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtAgeRes.Clear();
            txtDuration.Clear();
            txtGenre.Clear();
            txtMovie.Clear();
            rchInvoice.Clear();
            txtPrice.Text = "55";
            chkExRental.Checked = false;


        }

        private void btnExitRentDvd_Click(object sender, EventArgs e)
        {
            UserLogin log = new UserLogin();

            log.Show();
            this.Hide();
        }
    }
}
