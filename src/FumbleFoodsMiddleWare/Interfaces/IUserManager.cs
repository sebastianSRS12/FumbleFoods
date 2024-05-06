namespace FumbleFoods.src
{
    public interface IUserManager
    {
        void LoginUser(string emailOrUsername, string password);
        bool RegisterUser(object sender, EventArgs e);
        bool checkSecurityCode(string securityCode);
        User DisplayUserInfo(string userId);
    }
}