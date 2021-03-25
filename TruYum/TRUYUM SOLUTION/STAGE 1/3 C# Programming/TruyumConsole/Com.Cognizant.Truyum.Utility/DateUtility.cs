using System;

namespace Com.Cognizant.Truyum.Utility
{
    public class DateUtility
    {
        public DateTime ConvertToDate(String inputDate)
        {
            return DateTime.Parse(inputDate);
        }
    }
}
