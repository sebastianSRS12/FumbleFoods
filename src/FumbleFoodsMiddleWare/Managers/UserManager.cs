using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace FumbleFoods.src
{
    public class UserManager : IUserManager
    {
        public void LoginUser(string emailOrUsername, string password)
        {
            return;
        }

        public bool RegisterUser(object sender, EventArgs e)
        {
            bool is_Registered = false;

            string firstName = FirstName.placeholder;
            string lastName = LastName.placeholder;
            string email = email.placeholder;
            string password = password.placeholder;

            if (UserAccessor.CreateUser(firstName, lastName, email, password))
            {
                is_Registered = true;
            }

            return is_Registered;
        }

        public bool checkSecurityCode(string securityCode)
        {
            return false;
        }

        public User DisplayUserInfo(string userId)
        {
            User tempUser = new User();
            return tempUser;
        }
    }
}
