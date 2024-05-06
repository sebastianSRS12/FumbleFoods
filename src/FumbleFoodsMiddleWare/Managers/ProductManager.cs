using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using ProductAccessor.cs;

namespace FumbleFoods.src
{
    public class ProductManager : IProductManager
    {
        public Product DisplayProductInfo(string productId) {
            Product product_to_display = ProductAccessor.GetProductById(productId);
            return product_to_display;
        }
        public void AddProductToCart(User currentUser) {
            return;
        }
    }
}