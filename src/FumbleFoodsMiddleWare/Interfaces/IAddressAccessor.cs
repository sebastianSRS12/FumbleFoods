namespace FumbleFoods.src
{
    public interface IAddressAccessor
    {
        Address AccessAddress(int addressId);
        Address GetAddressById(int addressId);
        bool CreateAddress();
        Address CreateAddressForUser();
    }
}