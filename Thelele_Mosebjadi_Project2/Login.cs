using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Thelele_Mosebjadi_Project2
{
    class Login
    {

        List<Login> details = new List<Login>();
        string sline;
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string userpassword;

        public string Userpassword
        {
            get { return userpassword; }
            set { userpassword = value; }
        }

        public Login()
        {

        }
        public Login(string username, string userpassword)
        {
            this.username = username;
            this.userpassword = userpassword;
        }
        public List<Login> Log()
        {
            StreamReader reader = new StreamReader("users.txt");
            sline = reader.ReadLine();
              while (sline != null)
              {
                  string[] myArray = sline.Split(';');
                  details.Add(new Login(myArray[0], myArray[1]));
                  sline = reader.ReadLine();

              }
              reader.Close();
              return details;
             

        }
    }
}
