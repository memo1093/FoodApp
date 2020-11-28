using System.Collections.Generic;
using foodapp.entity;

namespace foodapp.webui.Models
{
    public class ProductViewModel
    {
        public List<Product> Products{get; set;}
        public List<Category> Categories { get; set; }
    }
}