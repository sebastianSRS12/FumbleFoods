using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FumbleFoods.src
{
    public class UserEngine : IUserEngine
    {

        public bool IsUserAuthorized(string userId)
        {
            return false;
        }

        public void CreateUserSession()
        {

        }

        public void TerminateUserSession()
        {

        }

    }
}