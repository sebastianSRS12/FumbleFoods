namespace FumbleFoods.src
{
    public interface IUserCheckEngine
    {
        bool IsCorrectPassword(string password);
        bool IsCorrectUsername(string username);
        bool IsCorrectEmail(string username);
    }
}