namespace FumbleFoods.src
{
    public interface IUserEngine
    {
        void CreateUserSession();
        bool IsUserAuthorized(string userId);
        void TerminateUserSession();
    }
}