using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Cognizant.Truyum.Utility
{
    class DataUtility
    {
        public static DateTime ConvertToShortDataString(string inputDate)
        {
            return Convert.ToDateTime(DateTime.Parse(inputDate).ToShortDateString());
        }
    }
}
