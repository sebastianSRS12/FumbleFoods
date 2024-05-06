using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace FumbleFoods.src
{
    public class AddressAccessor : IAddressAccessor
    {
        private Address AccessAddress(int addressId)
        {
            try
            {
                DatabaseConnection databaseConnection = new DatabaseConnection();
                databaseConnection.OpenConnection();

                string queryString = "SELECT * FROM Address WHERE addressId = " + addressId + ";";
                SqlCommand selectCommand = new SqlCommand(queryString, databaseConnection.conn);
                SqlDataReader sqlReader;
                Address tempAddress;

                sqlReader = selectCommand.ExecuteReader();

                if (sqlReader.Read())
                {
                    string city = sqlReader.GetString(2);
                    string state = sqlReader.GetString(3);
                    string zipCode = sqlReader.GetString(4);
                    string street = sqlReader.GetString(5);
                    string aptNum = sqlReader.GetString(6);
                    tempAddress = new Address();
                    tempAddress.setAddressId(addressId);
                    tempAddress.setCity(city);
                    tempAddress.setState(state);
                    tempAddress.setZipCode(zipCode);
                    tempAddress.setStreet(street);
                    tempAddress.setAptNum(aptNum);
                }
            }
            catch
            {
                tempAddress = new Address();
                tempAddress.setAddressId(addressId);
                tempAddress.setCity("NULL");
                tempAddress.setState("NULL");
                tempAddress.setZipCode("NULL");
                tempAddress.setStreet("NULL");
                tempAddress.setAptNum("NULL");
            }

            databaseConnection.CloseConnection();
            return tempAddress;
        }

        public Address GetAddressById(int addressId)
        {
            ;
        }

        public bool CreateAddress()
        {
            bool is_Address_Created = false;

            try {

                DatabaseConnection databaseConnection = new DatabaseConnection();
                databaseConnection.OpenConnection();
                string insertQuery = "INSERT INTO Address (city, state, zipcode, street, aptNum) " +
                                    "VALUES ();";
                
                databaseConnection.CloseConnection();

            }
            return is_Address_Created;
        }

        public int CreateAddressForUser()
        {
            int addressId;

            try {

                DatabaseConnection databaseConnection = new DatabaseConnection();
                databaseConnection.OpenConnection();

                string insertQuery = "INSERT INTO Address DEFAULT VALUES;
                string outputQuery = "SELECT SCOPE_IDENTITY()";
                databaseConnection.ExecuteNonQueries(insertQuery);
                addressId = databaseConnection.ExecuteNonQueriesReturnId(outputQuery);

                databaseConnection.CloseConnection();

            }
            catch {
                addressId = -1;
            }
            return addressId;
        }
    }
}