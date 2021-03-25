using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Model;
using Com.Cognizant.Truyum.Utility;
using System.Data.SqlClient;

namespace Com.Cognizant.Truyum.Dao
{
  public class MenuItemDaoSql : IMenuItemDao
    {
        string sqlQuery = string.Empty;
        public MenuItem GetMenuItem(long menuItemId)
        {
            MenuItem menuItem = new MenuItem();
            sqlQuery = "SELECT * FROM MenuItem WHERE id = " + menuItemId.ToString();

            using (SqlConnection sqlCon = DBHandler.GetConnection())
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlCon))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null && dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            menuItem.active = Convert.ToBoolean(dr["active"]);
                            menuItem.category = Convert.ToString(dr["category"]);
                            menuItem.id = Convert.ToInt64(dr["id"]);
                            menuItem.name = Convert.ToString(dr["name"]);
                            menuItem.price = Convert.ToDecimal(dr["price"]);
                            menuItem.dateofLaunch = Convert.ToDateTime(dr["dateofLaunch"]);
                            menuItem.freeDelivery = Convert.ToBoolean(dr["freeDelivery"]);
                        }
                        dr.Close();
                    }
                }
            }
        
            return menuItem;
        }

        /// Function to get all the data
        
        public List<MenuItem> GetMenuItemListAdmin()
        {
            List<MenuItem> lstResult = new List<MenuItem>();
            sqlQuery = "SELECT * FROM MenuItem";
            DataTable dtData = DBHandler.GetDataTable(sqlQuery);
            if(dtData != null && dtData.Rows.Count > 0)
            {
                lstResult = Helper.ConvertDataTable<MenuItem>(dtData);
            }
            return lstResult;
        }

        public List<MenuItem> GetMenuItemListCustomer()
        {
            List<MenuItem> lstResult = new List<MenuItem>();
            MenuItem menuItem = null;
            sqlQuery = "SELECT * FROM MenuItem";
            DataTable dtData = DBHandler.GetDataTable(sqlQuery);
            if(dtData != null && dtData.Rows.Count > 0)
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

       
        public void ModifyMenuItem(MenuItem menuItem)
        {
            MenuItem objMenuItem = GetMenuItem(menuItem.id);
            if(objMenuItem != null)
            {
                objMenuItem.name = menuItem.name;
                objMenuItem.active = menuItem.active;
                objMenuItem.category = menuItem.category;
                objMenuItem.dateofLaunch = menuItem.dateofLaunch;
                objMenuItem.freeDelivery = menuItem.freeDelivery;
                objMenuItem.price = menuItem.price;


                sqlQuery = string.Format(@"UPDATE MenuItem SET
                        name = '{0}'
                        ,price = {1}
                        ,active = {2}
                        
                        ,dateOfLaunch = '{3}'
                        ,category = '{4}'
                        ,freeDelivery = {5}
                        WHERE id = {6} ",
                        objMenuItem.name, objMenuItem.price, (objMenuItem.active) ? 1: 0, objMenuItem.dateofLaunch, objMenuItem.category, (objMenuItem.freeDelivery) ? 1 : 0 , objMenuItem.id);
                int res = DBHandler.ExecuteNonQuery(sqlQuery);

            }
        }
    }
}
