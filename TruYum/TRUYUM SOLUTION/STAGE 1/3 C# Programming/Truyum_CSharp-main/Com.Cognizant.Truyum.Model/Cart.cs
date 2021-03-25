using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Cognizant.Truyum.Model
{
    public class Cart
    {
        public List<MenuItem>  menuItemList { get; set; }
        public double total { get; set; }
        public double userId { get; set; }
    }
}
