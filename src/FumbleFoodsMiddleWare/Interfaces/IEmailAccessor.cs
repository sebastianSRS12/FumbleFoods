namespace FumbleFoods.src
{
    public interface IEmailAccessor
    {
        Email AccessEmail(int userId);
        Email GetEmailById(int userId);
        bool CreateEmail(int emailId, string emailAddress, int userId);
    }
}