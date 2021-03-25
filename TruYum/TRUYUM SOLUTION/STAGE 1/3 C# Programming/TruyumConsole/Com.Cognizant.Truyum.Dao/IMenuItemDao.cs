using Com.Cognizant.Truyum.Model;
using System.Collections.Generic;

namespace Com.Cognizant.Truyum.Dao
{
    public interface IMenuItemDao
    {
        public List<MenuItem> GetMenuItemListAdmin();

        public List<MenuItem> GetMenuItemListCustomer();

        public void ModifyMenuItem(MenuItem menuItem);

        public List<MenuItem> GetMenuItem(long menuItemId);
    }
}