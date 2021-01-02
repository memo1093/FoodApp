using System.Collections.Generic;
using System.Linq;

namespace foodapp.webui.Models
{
    public class CartModel
    {
        public int CartId { get; set; }
        public decimal CargoPrice { get; set; }=7.00m;
        public List<CartItemModel> CartItems { get; set; }
        public decimal CartTotal()
        {
           return (decimal)CartItems.Sum(i=>i.Price*i.Quantity);
        }
        public decimal TotalPrice()
        {
            return CargoPrice+CartTotal();
        }
    }

    public class CartItemModel
    {
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
        public string CategoryName { get; set; }
    }
}