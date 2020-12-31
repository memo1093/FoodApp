using System.Collections.Generic;

namespace foodapp.entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public bool IsApproved { get; set; }
        public int CategoryId { get; set; }
        public string ImageUrl { get; set; }
        
        public List<ProductCategory> ProductCategories{get; set;}
    }
}