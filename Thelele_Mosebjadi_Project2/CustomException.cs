using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thelele_Mosebjadi_Project2
{
    class CustomException : Exception
    {
        
        public CustomException()
        {

        }
        public CustomException(string message)
            : base(message)
        {

        }

    }
}
