using System;
using System.Collections.Generic;
using System.Text;
using Com.Cognizant.Truyum.Dao;
using Com.Cognizant.Truyum.Model;

using System.Linq;
using System.Threading.Tasks;

namespace TruyumOnline
{
    public class CartDaoCollection : ICartDao
    {
        CartDaoSql obj = new CartDaoSql();
        public void AddCartItem(long userId, long menuItemId)
        {
            obj.AddCartItem(userId, menuItemId);
        }
    public List<MenuItem> GetAllCartItems(long userId)
    {
    return obj.GetAllCartItems(userId);
    }
       public  void RemoveCartItem(long userId, long menuItemId)
        {
            obj.RemoveCartItem(userId, menuItemId);
        }

        public Cart GetCartDetails(long userId)
        {
            Cart cart = new Cart();
            cart.userId = userId;
            cart.menuItemList = obj.GetAllCartItems(userId);
            cart.total = Convert.ToInt64(cart.menuItemList.Sum(e => e.price));
            return cart;
        }
    }
}
