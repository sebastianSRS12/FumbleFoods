namespace FumbleFoods.src
{
    public interface IUserAccessor
    {
        void AuthenticateUser(string email, string password);
        User GetUserById(int userId);
        bool IsEmailAvailable(string email);
        bool IsPhoneNumberAvailable(string phoneNumber);
        bool IsUsernameAvailable(string username);
    }
}