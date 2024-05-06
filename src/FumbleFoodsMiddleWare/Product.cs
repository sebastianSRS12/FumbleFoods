using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace FumbleFoods.src
{
    public class Product 
    {
        public int ProductId { get; set; }
        public int ManufacturerId { get; set;}
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Dimensions { get; set; }
        public string Weight { get; set; }
        public string Rating { get; set; }
        public string SKU { get; set; }
        public string Inventory { get; set;}
        public double Cost { get; set; }
        public string Category { get; set; }
    }
}