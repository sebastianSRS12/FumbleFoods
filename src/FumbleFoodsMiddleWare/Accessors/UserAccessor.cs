using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace FumbleFoods.src
{
    public class UserAccessor : IUserAccessor
    {
        private User AccessUser(int userId)
        {
            try
            {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.OpenConnection();

            string queryString = "SELECT * FROM User WHERE userId = " + userId + ";";
            SqlCommand selectCommand = new SqlCommand(queryString, databaseConnection.conn);
            SqlDataReader sqlReader;
            User tempUser;
            sqlReader = selectCommand.ExecuteReader();

            if (sqlReader.Read())
            {
                AddressAccessor getAddress = new AddressAccessor();
                string firstName = sqlReader.GetString(1);
                string lastName = sqlReader.GetString(2);
                string password = sqlReader.GetString(3);
                string username = sqlReader.GetString(4);
                string creditCardNumber = sqlReader.GetString(5);
                Address address = getAddress.GetAddressById(sqlReader.GetSqlInt32(6));
                tempUser = new User();
                tempUser.setUserId(userId);
                tempUser.setFirstName(firstName);
                tempUser.setLastName(lastname);
                tempUser.setPassword(password);
                tempUser.setUsername(username);
                tempUser.setCreditCardNumber(creditCardNumber);
                tempUser.setAddress(address);
            }
            }
            catch
            {
                // Return User with placeholder fields
            }

            databaseConnection.CloseConnection();
            return tempUser;
        }

        public void AuthenticateUser(string emailORusername, string password)
        {
            ;
        }

        public User GetUserById(int userId)
        {
            User tempUser = new User();
            return tempUser;
        }

        public bool CreateUser(string firstName, string lastName, string email, string password)
        {
            bool is_User_Created = false;

            try {

                DatabaseConnection databaseConnection = new DatabaseConnection();
                databaseConnection.OpenConnection();
                int addressID = AddressAccessor.CreateAddressForUser();
                
                string insertQuery = "INSERT INTO User (firstName, lastName, password, username, addressId) " +
                                    "VALUES (" + firstName + "," + lastName + "," + password + "," + firstName + lastName + "," + addressID");";
                int userId = databaseConnection.ExecuteNonQueriesReturnId();
                
                EmailAccessor.CreateEmailForUser(email, userId)
                
                databaseConnection.CloseConnection();

            }
            return is_User_Created;
        }

        public bool IsEmailAvailable(string email)
        {
            return false;
        }

        public bool IsPhoneNumberAvailable(string phoneNumber)
        {
            return false;
        }

        public bool IsUsernameAvailable(string username)
        {
            return false;
        }
    }
}