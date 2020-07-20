using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thelele_Mosebjadi_Project2
{
   abstract class DVD
    {
        private string dvdName;

        public string DvdName
        {
            get { return dvdName; }
            set { dvdName = value; }
        }
        private DateTime rentDate;

        public DateTime RentDate
        {
            get { return rentDate; }
            set { rentDate = value; }
        }
        private string dvdLength;

        public string DvdLength
        {
            get { return dvdLength; }
            set { dvdLength = value; }
        }
        private string ageRestrict;

        public string AgeRestrict
        {
            get { return ageRestrict; }
            set { ageRestrict = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private string genre;

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }


        public DVD()
        {

        }

        public DVD(string dvdName, DateTime rentDate, string dvdLength, string ageRestrict, string genre, double price )
        {
            this.dvdName = dvdName;
            this.rentDate = rentDate;
            this.dvdLength = dvdLength;
            this.ageRestrict = ageRestrict;
            this.price = price;
            this.genre = genre;
        }

       public abstract string CreateInvoice();

       public abstract string SaveInvoice();
    }
}
