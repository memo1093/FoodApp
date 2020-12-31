using System.Collections.Generic;

namespace foodapp.entity
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public double CargoPrice { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}