
using System.Drawing;
using ConsoleApp1;

namespace TelegramClient.Auth.UI;

public class LoginUI
{
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
}