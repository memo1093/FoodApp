using foodapp.entity;

namespace foodapp.business.Abstract
{
    public interface ICartService
    {
        void InitializeCart(string userId);
        Cart GetByUserId(string userId);

        void AddToCart(string userId, int productId, int quantity);
        void DeleteFromCart(int productId, string userId);
        void ClearCart(int cartId);
    }
}