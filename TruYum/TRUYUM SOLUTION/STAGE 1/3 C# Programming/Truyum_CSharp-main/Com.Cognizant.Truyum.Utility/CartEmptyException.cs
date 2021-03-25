using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Com.Cognizant.Truyum.Utility
{
    public class CartEmptyException : Exception
    {
        public CartEmptyException()
        {

        }


        public CartEmptyException(double total) : base(String.Format("No item in the Cart"))
        {

        }
    }
}
