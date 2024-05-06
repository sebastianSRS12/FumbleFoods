using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace FumbleFoods.src
{
    public class EmailAccessor : IEmailAccessor
    {
        private Email AccessEmail(int userId)
        {
            try
            {
                DatabaseConnection databaseConnection = new DatabaseConnection();
                databaseConnection.OpenConnection();

                string queryString = "SELECT * FROM Email WHERE userId = " + userId + ";";
                SqlCommand selectCommand = new SqlCommand(queryString, databaseConnection.conn);
                SqlDataReader sqlReader;
                Email tempEmail;

                sqlReader = selectCommand.ExecuteReader();

                if (sqlReader.Read())
                {
                    string emailId = sqlReader.GetString(0);
                    string emailAddress = sqlReader.GetString(1);
                    tempEmail = new Email();
                    tempEmail.setEmailId(emailId);
                    tempEmail.setEmailAddress(emailAddress);
                    tempEmail.setUserId(userId);
                }
            }
            catch
            {
                tempEmail = new Email();
                tempEmail.setEmailId(-1);
                tempEmail.setEmailAddress("NotReal@Fake.null");
                tempEmail.setUserId(userId);
            }

            databaseConnection.CloseConnection();
            return tempEmail;
        }

        public void CreateEmailForUser(string email, int userId)
        {
            try {

                DatabaseConnection databaseConnection = new DatabaseConnection();
                databaseConnection.OpenConnection();

                string insertQuery = "INSERT INTO Email (emailAddress, userId)" +
                "VALUES (" + email +"," + userId + ");"
                databaseConnection.ExecuteNonQueries(insertQuery);

                databaseConnection.CloseConnection();

            }
            return;
        }
    }
}