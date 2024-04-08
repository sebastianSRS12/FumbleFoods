using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

//This class is still a WIP,
//I am still trying to learn how to get information a user inputs into the database

namespace eCommerceSite.src
{
    public class UserRegistration
    {                                            //This is a temp connectionString, I was testing something with a really simple database I made
        private static string connectionString = "data source=DESKTOP-10NMUFD\\SQLEXPRESS01;initial catalog=FumbleFoods;trusted_connection=true";

        public static void SaveUserToDatabase(string firstName, string lastName, DateTime dateOfBirth, string email, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Users (First Name, Last Name, DateOfBirth, Email, Password) VALUES (@FirstName, @LastName, @DateOfBirth, @Email, @Password)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        command.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("User data saved successfully!");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error saving user data: {ex.Message}");
            }
        }
    }
}