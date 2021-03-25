using System;
using System.Collections.Generic;
using System.Text;
using Com.Cognizant.Truyum.Dao;
using Com.Cognizant.Truyum.Model;
using System.Linq;
using System.Threading.Tasks;

namespace TruyumOnline
{
   public  class MenuItemDaoCollection : IMenuItemDao
    {
        MenuItemDaoSql obj = new MenuItemDaoSql();
        public MenuItem GetMenuItem(long menuItemId)
        {
            return obj.GetMenuItem(menuItemId);
        }
        public List<MenuItem> GetMenuItemListAdmin()
        {
            return obj.GetMenuItemListAdmin();
        }
        public List<MenuItem> GetMenuItemListCustomer()
        {
            return obj.GetMenuItemListCustomer();
        }

        public void ModifyMenuItem(MenuItem menuItem)
        {
            obj.ModifyMenuItem(menuItem);
        }

   
    }
}
