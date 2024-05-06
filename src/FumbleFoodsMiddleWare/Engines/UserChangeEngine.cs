using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FumbleFoods.src
{
    public class UserChangeEngine : IUserChangeEngine
    {
        bool ChangePassword(string currentPassword, string newPassword) {
            return false;
        }
        bool ChangeUsername(string currentUsername, string pastUsername) {
            return false;
        }
        bool ChangeEmail(string currentEmail, string newEmail) {
            return false;
        }
        bool ChangeCreditCardNumber(string currentCreditCardNumber, string newCreditCardNumber) {
            return false;
        }
        bool ChangeAddress(Address currentAddress, Address newAddress) {
            return false;
        }
    }
}