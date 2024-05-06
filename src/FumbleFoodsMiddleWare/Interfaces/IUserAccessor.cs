namespace FumbleFoods.src
{
    public interface IUserAccessor
    {
        User AccessUser(int userId);
        void AuthenticateUser(string emailORusername, string password);
        User GetUserById(int userId);
        bool CreateUser(string firstName, string lastName, string email, string password);
        bool IsEmailAvailable(string email);
        bool IsPhoneNumberAvailable(string phoneNumber);
        bool IsUsernameAvailable(string username);
    }
}