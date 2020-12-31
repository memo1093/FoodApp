using System.Collections.Generic;
using System.Linq;

namespace foodapp.webui.Models
{
    public class CartModel
    {
        public int CartId { get; set; }
        public double CargoPrice { get; set; }=7.00;
        public List<CartItemModel> CartItems { get; set; }
        public double CartTotal()
        {
           return (double)CartItems.Sum(i=>i.Price*i.Quantity);
        }
        public double TotalPrice()
        {
            return CargoPrice+CartTotal();
        }
    }

    public class CartItemModel
    {
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
        public string CategoryName { get; set; }
    }
}