using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Com.Cognizant.Truyum.Model;
using Com.Cognizant.Truyum.Utility;

namespace Com.Cognizant.Truyum.Dao
{
   public  class CartDaoSql : ICartDao
    {
        
            string sqlQuery = string.Empty;
            public void AddCartItem(long userId, long menuItemId)
            {
                using (SqlConnection sqlCon = DBHandler.GetConnection())
                {
                    sqlCon.Open();
                sqlQuery = "SELECT 1 FROM CART WHERE MenuItemId = " + menuItemId.ToString() + "AND UserId = " + userId.ToString();
                short res = Convert.ToInt16(DBHandler.ExecuteScaler(sqlQuery));
                if(res == 0 )
                {
                    sqlQuery = @"INSERT INTO CART (MenuItemId, UserId)" +
                        "VALUES(" + menuItemId.ToString() + "," + userId.ToString() + ")";
                    using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, sqlCon))
                    {
                        sqlCmd.ExecuteNonQuery();
                    }
                }
                    }
                }
            
        
        public List<MenuItem> GetAllCartItems(long userId)
        {
            List<MenuItem> lstResult = new List<MenuItem>();
            MenuItem menuItem = null;
        sqlQuery = @"SELECT m.* FROM Cart AS c 
                        INNER JOIN MenuItem As m on m.id = c.MenuItemId
                         AND c.UserId = " + userId.ToString();
            DataTable dtData = DBHandler.GetDataTable(sqlQuery);
            if (dtData != null && dtData.Rows.Count > 0)
            {
                foreach (DataRow dr in dtData.Rows)
                {
                    menuItem = new MenuItem();

                    menuItem.active = Convert.ToBoolean(dr["active"]);
                    menuItem.category = Convert.ToString(dr["category"]);
                    menuItem.id = Convert.ToInt64(dr["id"]);
                    menuItem.name = Convert.ToString(dr["name"]);
                    menuItem.price = Convert.ToDecimal(dr["price"]);
                    menuItem.dateofLaunch = Convert.ToDateTime(dr["dateofLaunch"]);
                    menuItem.freeDelivery = Convert.ToBoolean(dr["freeDelivery"]);


                    lstResult.Add(menuItem);
                }
            }

            return lstResult;
        }

        public void RemoveCartItem(long userId, long menuItemId)
        {
            using (SqlConnection sqlCon = DBHandler.GetConnection())
            {
                sqlCon.Open();
                sqlQuery = @"DELETE FROM CART WHERE MenuItemId = " + menuItemId.ToString() + " AND UserId = " + userId.ToString();
                using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, sqlCon))
                {
                    sqlCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
