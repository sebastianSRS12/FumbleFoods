namespace FumbleFoods.src
{
    public interface IProductAccessor
    {
        Product AccessProduct(int productId);
        Product GetProductById(int productId);
    }
}