using System;
using System.Collections.Generic;
using System.Text;

namespace bumShopSolution.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public List<ProductInCategory> productInCategories { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
        public List<Cart> Carts { get; set; }
        public List<ProductTranslation> ProductTranslations { get; set; }
    }
}
