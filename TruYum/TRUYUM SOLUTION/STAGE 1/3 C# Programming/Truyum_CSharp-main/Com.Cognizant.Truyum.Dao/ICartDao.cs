using Com.Cognizant.Truyum.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Cognizant.Truyum.Dao
{
    public interface ICartDao
    {
        void AddCartItem(long userId, long menuItemId);
        List<MenuItem> GetAllCartItems(long userId);
        void RemoveCartItem(long userId, long menuItemId);
        
    }
}
