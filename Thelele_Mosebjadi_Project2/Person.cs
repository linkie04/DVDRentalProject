using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thelele_Mosebjadi_Project2
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private string cellno;

        public string Cellno
        {
            get { return cellno; }
            set { cellno = value; }
        }

        public Person()
        {

        }
        public Person(string name, string surname, int age, string gender, string cellno)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.gender = gender;
            this.cellno = cellno;
        }

  
 
    }
}
