using System.Collections.Generic;

namespace foodapp.entity
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<Product> Products{get; set;}
    }
}