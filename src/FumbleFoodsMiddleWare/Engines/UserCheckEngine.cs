using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FumbleFoods.src
{
    public class UserCheckEngine : IUserCheckEngine
    {
        public bool IsCorrectPassword(string password) {
            return false;
        }
        public bool IsCorrectUsername(string username) {
            return false;
        }
        public bool IsCorrectEmail(string username) {
            return false;
        }
    }
}