using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Com.Cognizant.Truyum.Utility
{
    /// Data Access Layer - DAO
    public class DBHandler
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public static SqlConnection GetConnection()
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            return sqlCon;
        }
        /// Use to execute Insert Update & Delete queries only
        /// <param name="="sqlQuery"></param>
        public static int ExecuteNonQuery(string sqlQuery)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                {
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// Use to get the DataTable

        public static DataTable GetDataTable(string sqlQuery)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }


        /// Use to Get the Dataset
         public static DataSet GetDataSet(string sqlQuery)
        {
            DataSet ds = new DataSet();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                {
                    da.Fill(ds);
                }
            }
            return ds;
        }

        /// Use to retrieve only 1 value from the datbase

        public static object ExecuteScaler(string sqlQuery)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                {
                    return cmd.ExecuteScalar();
                }
            }
        }

        /// Use to retrieve just 1 row from the database
        
        public static SqlDataReader GetDataReader(string sqlQuery)
        {
            SqlDataReader dr;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                {
                    dr = cmd.ExecuteReader();
                }
            }
            return dr;
        }


    }
}
