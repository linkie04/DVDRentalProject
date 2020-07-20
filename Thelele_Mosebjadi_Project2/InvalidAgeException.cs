using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thelele_Mosebjadi_Project2
{
    class InvalidAgeException
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public InvalidAgeException(int age)
        {
            this.age = age;    
        }
        public void validate(int age)
        {
           if (age < 18 || age < 0 || age > 79)
           {
               throw new CustomException("Invalid Age entered");
           }
           //else
           //{
           //    this.age = age;
           //}
        }
    }
}
