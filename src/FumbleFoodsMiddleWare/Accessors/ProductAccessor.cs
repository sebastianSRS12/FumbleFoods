using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace FumbleFoods.src
{
    public class ProductAccessor : IProductAccessor
    {
        private Product AccessProduct(int productId)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.OpenConnection();

            string queryString = "SELECT * FROM Product WHERE productId = " + productId ";";
            SqlCommand selectCommand = new SqlCommand(queryString, databaseConnection.conn);
            SqlDataReader sqlReader;
            Product tempProduct;
            try
            {
                sqlReader = selectCommand.ExecuteReader();

                if (sqlReader.Read())
                {
                    int productID = sqlReader.GetSqlInt32(0);
                    int manfacturerID = sqlReader.GetSqlInt32(1);
                    string productName = sqlReader.GetString(2);
                    string description = sqlReader.GetString(3);
                    string dimensions = sqlReader.GetString(4);
                    string weight = sqlReader.GetString(5);
                    string rating = sqlReader.GetString(6);
                    string sku = sqlReader.GetString(7);
                    string inventory = sqlReader.GetString(8);
                    double cost = sqlReader.GetDouble(9);
                    string category = sqlReader.GetString(10);
                    tempProduct = new Product();
                    tempProduct.setProductId(productID);
                    tempProduct.setManufacturerId(manfacturerID);
                    tempProduct.setProductName(productName);
                    tempProduct.setDescription(description);
                    tempProduct.setDimensions(dimensions);
                    tempProduct.setWeight(weight);
                    tempProduct.setRating(rating);
                    tempProduct.setSKU(sku);
                    tempProduct.setInventory(inventory);
                    tempProduct.setCost(cost);
                    tempProduct.setCategory(category);
                }
            }
            catch
            {
                tempProduct = new Product();
                tempProduct.setProductId(-1);
                tempProduct.setManufacturerId(-1);
                tempProduct.setProductName("productName");
                tempProduct.setDescription("description");
                tempProduct.setDimensions("dimensions");
                tempProduct.setWeight("weight");
                tempProduct.setRating("rating");
                tempProduct.setSKU("sku");
                tempProduct.setInventory("inventory");
                tempProduct.setCost(-1.00);
                tempProduct.setCategory("category");
            }

            databaseConnection.CloseConnection();
            return tempProduct;
        }

        public Product GetProductById(int productId)
        {
            Product tempProduct = AccessProduct(productId);
            return tempProduct;
        }
    }
}