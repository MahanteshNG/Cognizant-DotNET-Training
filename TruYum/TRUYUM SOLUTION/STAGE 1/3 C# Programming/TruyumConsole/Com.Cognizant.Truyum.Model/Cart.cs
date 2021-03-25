using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Model
{
    public class Cart
    {
        private List<MenuItem> menuItemList;
        public List<MenuItem> MenuItemList 
        { 
            get => menuItemList;
            set => menuItemList = value;
        }

        private double total;
        public double Total { get; set; }
        
    }
}
