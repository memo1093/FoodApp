using System.Collections.Generic;

namespace foodapp.entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public List<ProductCategory> ProductCategories{get; set;}
    }
}