using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace FumbleFoods.src
{
    public class CartAccessor : ICartAccessor
    {
        private Cart AccessCart(int userId)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.OpenConnection();

            string queryString = "SELECT * FROM Cart WHERE userId = " + userId ";";
            SqlCommand selectCommand = new SqlCommand(queryString, databaseConnection.conn);
            SqlDataReader sqlReader;
            Cart tempCart;
            try
            {
                sqlReader = selectCommand.ExecuteReader();

                if (sqlReader.Read())
                {
                    int cartPK = sqlReader.GetSqlInt32(0);
                    Dictionary<int, int> basket =
                        new Dictionary<int, int>();
                    tempCart = new Cart();
                    tempCart.setCartPK(cartPK);
                    tempCart.setUserId(userId);
                    while (sqlReader.Read())
                    {
                        //Create key and add quantity onto basket
                    }
                    tempCart.setBasket(basket);
                }
            }
            catch
            {
                // Return cart with placeholder fields
            }

            databaseConnection.CloseConnection();
            return tempCart;
        }
        public Cart GetCartbyId(int cartId) {
            Cart tempCart = new Cart();
            return tempCart;
        }
        public bool PlaceProductinCart(int cartId, int productId) {
            return false;
        }
    }
}