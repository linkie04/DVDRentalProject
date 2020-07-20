using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Thelele_Mosebjadi_Project2
{
    class MemberRegister : Person
    {
        
            
     
        public MemberRegister()
        {

        }
        public MemberRegister(string name, string surname, int age, string gender, string cellno)
            :base(name, surname, age, gender, cellno)
        {

        }

       
        

        //for user to register
        public void Register()
        {

            string line;

            line = Name + ";" + Surname + ";" + Age.ToString() + ";" + Gender + ";" + Cellno;
            StreamWriter memReg = new StreamWriter("members.txt", true);

            using (memReg)
            {  
                
                memReg.WriteLine(line);
            } 

            
        }


    }
}
