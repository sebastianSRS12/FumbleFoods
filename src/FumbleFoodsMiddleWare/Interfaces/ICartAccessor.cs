namespace FumbleFoods.src
{
    public interface ICartAccessor
    {
        Cart AccessCart(int cartId);
        Cart GetCartbyId(int cartId);
        bool PlaceProductinCart(int cartId, int productId);
    }
}