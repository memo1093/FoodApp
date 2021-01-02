using foodapp.business.Abstract;
using foodapp.data.Abstract;
using foodapp.entity;

namespace foodapp.business.Concrete
{
    public class CartManager : ICartService
    {
        private ICartRepository _cartRepository;

        public CartManager(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public void AddToCart(string userId, int productId, int quantity)
        {
            var cart = GetByUserId(userId);

            if (cart!=null)
            {
                var index = cart.CartItems.FindIndex(i=>i.ProductId==productId);
                //if The product is in cart(update)
                
                
                //if product is not in cart
                if (index<0)
                {
                    cart.CartItems.Add(new CartItem(){
                        ProductId=productId,
                        Quantity=quantity,
                        CartId=cart.Id,
                    });
                }
                else
                {
                    cart.CartItems[index].Quantity += quantity;
                }
                _cartRepository.Update(cart);
            }
        }

        public void ClearCart(int cartId)
        {
            _cartRepository.ClearCart(cartId);
        }

        public void DeleteFromCart(int productId,string userId)
        {
            
            var cart =_cartRepository.GetByUserId(userId);
            if (cart!=null)
            {
                _cartRepository.DeleteFromCart(cart.Id,productId);
            }
        }

        public Cart GetByUserId(string userId)
        {
            return _cartRepository.GetByUserId(userId);
        }


        public void InitializeCart(string userId)
        {
            _cartRepository.Create(new Cart(){UserId = userId});
        }
    }
}