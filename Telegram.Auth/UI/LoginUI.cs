
using System.Drawing;
using ConsoleApp1;
using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Domain;
using TelegramClient.Auth.Service;

namespace TelegramClient.Auth.UI;

public class LoginUI
{
    private UserService _userService;
    public LoginUI()
    {
        _userService = new UserService();
    }
    private Layout _layout = new Layout(new Point(60,30), new Point(120,60));

    public string LogView()
    {
        _layout.Ramka();
        _layout.Write("Enter your a phone number");
        var phoneNumber = _layout.Read();
        var phoneNumberLenght = phoneNumber.Length;
        if (phoneNumberLenght == "+998901231212".Length || phoneNumberLenght == 12 || phoneNumberLenght == 9)
        {
            return phoneNumber;
        }

        return null;
    }


    public User LoginView(string password, string phone)
    {
        var user = this._userService.GetAllModel().Find(x => x.Phonenumber == phone && x.Password == password);
        if (user == null)
            return new User();
        return user;
    }
}