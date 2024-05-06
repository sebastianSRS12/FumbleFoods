namespace FumbleFoods.src
{
    public interface IUserChangeEngine
    {
        bool ChangeUserPassword(string currentPassword, string newPassword);
        bool ChangeUsername(string currentUsername, string pastUsername);
        bool ChangeEmail(string currentEmail, string newEmail);
        bool ChangeCreditCardNumber(string currentCreditCardNumber, string newCreditCardNumber);
        bool ChangeAddress(Address currentAddress, Address newAddress);
    }
}