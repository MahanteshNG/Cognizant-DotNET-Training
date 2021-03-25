using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Cognizant.Truyum.Model
{
    public class MenuItem
    {
        public long id { get; set; }
        public string name { get; set; }
        public decimal  price { get; set; }
        public bool active { get; set; }
        public DateTime dateofLaunch { get; set; }
        public string category { get; set; }
        public bool freeDelivery { get; set; }
    }

}
