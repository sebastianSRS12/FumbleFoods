using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FumbleFoods.src
{
    public class DatabaseConnection
    {

        string ConnectionString = "Data Source=DESKTOP-10NMUFD\\SQLEXPRESS01;Initial Catalog=FumbleFoods;Integrated Security=True;Encrypt=False";
        SqlConnection conn;

        public void OpenConection()
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();
        }

        public void CloseConnection()
        {
            conn.Close();
        }

        public void ExecuteNonQueries(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
        }

        public int ExecuteNonQueriesReturnId(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, conn);
            return cmd.ExecuteNonQuery();
        }
    }
}