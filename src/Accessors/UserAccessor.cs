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

        public void AuthenticateUser(string email, string password)
        {

        }

        public User GetUserById(int userId)
        {
            User tempUser = new User();
            return tempUser;
        }

        public bool IsUsernameAvailable(string username)
        {
            return false;
        }

        public bool IsEmailAvailable(string email)
        {
            return false;
        }

        public bool IsPhoneNumberAvailable(string phoneNumber)
        {
            return false;
        }
    }
}