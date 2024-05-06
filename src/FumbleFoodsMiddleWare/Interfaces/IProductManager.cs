namespace FumbleFoods.src
{
    public interface IProductManager
    {
        Product DisplayProductInfo(string productId);
        void AddProductToCart(User currentUser);
    }
}