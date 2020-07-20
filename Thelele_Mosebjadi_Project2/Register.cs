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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserLogin userpage = new UserLogin();

            userpage.Show();

            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
                MemberRegister memReg = new MemberRegister();

              
                memReg.Name = txtName.Text;
                memReg.Surname = txtSurname.Text;
                try
                {

                     memReg.Age = int.Parse(txtAge.Text);
                     InvalidAgeException error = new InvalidAgeException(memReg.Age);
                    error.validate(memReg.Age);
                    memReg.Gender = cboGender.Text;
                    memReg.Cellno = txtCellno.Text;

                  if ((txtName != null) || (txtSurname != null) || (txtAge != null) || (txtCellno != null) || cboGender != null)
                  {
                    memReg.Register();


                    Login setUser = new Login();
                    setUser.Username = memReg.Name.ToLower();
                    setUser.Userpassword = setUser.Username.Substring(0, 3) + memReg.Surname.Substring(0, 2).ToLower();



                    MessageBox.Show("Welcome " + memReg.Name + " !" + " Your username is " + setUser.Username + ". Your password is " + setUser.Userpassword, "Jiba's Movie Rentals", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string addLine;
                    addLine = setUser.Username + ";" + setUser.Userpassword;
                    StreamWriter addUser = new StreamWriter("users.txt", true);

                    using (addUser)
                    {
                        addUser.WriteLine(addLine);
                    }

                    txtAge.Clear();
                    txtCellno.Clear();
                    txtName.Clear();
                    txtSurname.Clear();
                    txtName.Focus();

                    btnSubmit.Enabled = false;
                  }
                  else
                  {
                    MessageBox.Show("Not all information entered.Please enter all asked info ", "Jiba's Movie Rentals", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();

                  }


            }
                catch (Exception er) { MessageBox.Show(er.Message, "Jiba's Movie Rentals", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);  }
               

                

            
           
           
        }

        private void txtCellno_MouseHover(object sender, EventArgs e)
        {
            txtCellno.BackColor = Color.Coral;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            txtAge.Clear();
            txtCellno.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtName.Focus();
             
        }
    }
}
