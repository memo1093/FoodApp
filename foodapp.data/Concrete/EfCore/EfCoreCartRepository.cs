using System.Linq;
using foodapp.data.Abstract;
using foodapp.entity;
using Microsoft.EntityFrameworkCore;

namespace foodapp.data.Concrete.EfCore
{
    public class EfCoreCartRepository : EfCoreGenericRepository<Cart, FoodContext>, ICartRepository
    {
        public void DeleteFromCart(int cartId, int productId)
        {
            using (var context = new FoodContext())
            {

                var item = context.CartItems.Where(i=>i.ProductId==productId && i.CartId==cartId).FirstOrDefault();
                context.CartItems.Remove(item);
                context.SaveChanges();


                // var cmd = @"delete from fooddb.cartitems where CartId=@p0 ProductId=@p0";
                
                // context.Database.ExecuteSqlRaw(cmd,cartId,productId);
                
                
            }
        }

        public Cart GetByUserId(string userId)
        {
            using (var context = new FoodContext())
            {
                return context.Carts.Include(i=>i.CartItems)
                                    .ThenInclude(i=>i.Product)
                                    .FirstOrDefault(i=>i.UserId==userId);
            }
        }
        public override void Update(Cart entity)
        {
            using (var context = new FoodContext())
            {
                context.Carts.Update(entity);
                context.SaveChanges();   
            }
        }
    }
}