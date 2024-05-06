using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace FumbleFoods.src
{
    public class Cart
    {
        public int CartPK { get; set; }
        public int UserId { get; set; }
        public Dictionary<int, int> Basket { get; set; }
    }
}