using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Thelele_Mosebjadi_Project2
{
    class Booking : DVD
    {
        

        public Booking()
        {

        }
        public Booking(string dvdName, DateTime rentDate, string dvdLength, string ageRestrict, string genre, double price)
            :base(dvdName, rentDate, dvdLength, ageRestrict, genre, price)
        {

        }
      

       
       
       

        //create the invoice
        public override string CreateInvoice()
        {

            return string.Format("DVD: {0} \nRent Date: {1} \nLength: {2} \nAge Restriction: {3} \n____________________ \nTotal Price: R{4:0.00}", DvdName, RentDate, DvdLength, AgeRestrict, Price);
           
        }


        //save the invoice to a text file
        public override string SaveInvoice()
        {

            List<string> InvDetails = new List<string>();
            string saveLine;
            //Login Usename = new Login();
            saveLine = RentDate + ";" + DvdName + ";" + DvdLength + ";" + AgeRestrict + ";" + Price;
            
            return saveLine;
           

            
        }

       



        
    }
}
