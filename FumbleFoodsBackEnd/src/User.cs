using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace eCommerceSite
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
    }
}