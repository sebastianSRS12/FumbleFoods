using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace FumbleFoods.src
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string CreditCardNumber { get; set; }
        public Address Address { get; set; }
    }
}
