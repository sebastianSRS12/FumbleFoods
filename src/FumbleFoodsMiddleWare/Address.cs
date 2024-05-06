using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace FumbleFoods.src
{
    public class Address
    {
        public int AddressId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string AptNum { get; set; }
    }
}