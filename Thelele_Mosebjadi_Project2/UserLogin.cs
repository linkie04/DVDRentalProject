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
    public partial class UserLogin : Form
    {
        

        public UserLogin()
        {
            InitializeComponent();
        }

        static int count = 3;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            //add validation code here

              string uname, upass;
              bool pass = false;
            uname = txtUsername.Text;
            upass = txtPassword.Text;

            Login logs = new Login();
            List<Login> myList = logs.Log();


          

                foreach (Login line in myList)
                {
                    if ((uname == line.Username) && (upass == line.Userpassword))
                    {
                    pass = true;
                        MessageBox.Show("Successfully logged in as " + uname + ".", "Jiba's Movie Rentals");

                        ActiveForm.Close();
                        HomePage home = new HomePage();
                        home.Show();
                    }
                }
            if (uname == string.Empty || upass == string.Empty || (uname == string.Empty && upass == string.Empty))
            {
                count--;
                pass = false;
                
                
            }
            if(pass == false)
            {
                MessageBox.Show("Invalid inormation entered.", "Jiba's Movie Rentals", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (count == 0)
            {
                btnLogin.Enabled = false;
                MessageBox.Show("Out of attempts", "Jiba's Movie Rentals", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }





        }
          

           

            
            


        

        private void btnBack_Click(object sender, EventArgs e)
        {
            DefaultPage def = new DefaultPage();

            def.Show();
            this.Close();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
            txtUsername.Focus();
           // btnLogin.Enabled = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            Register openReg = new Register();
            openReg.Show();

           
        }

    }   
}



//==========================================================================================================


 