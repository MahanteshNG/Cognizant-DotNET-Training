using Com.Cognizant.Truyum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
    public interface ICartDao
    {
        public void AddCartItem(long userId, long menuItemId);

        // implemenmt: Cart raises CartEmptyException+
        public void GetAllCartItems(long userId);

        public void AddCRemoveCartItemartItem(long userId, long productId);
    }
}