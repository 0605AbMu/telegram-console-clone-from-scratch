using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace TelegramClient.Auth.UI;

public class RegistraionUI : CMD
{
    private Context _context;

    public RegistraionUI()
    {
        this._context = new Context();
    }
    public void Registraion()
    {
        Console.Write("Name : ");
        string name = Console.ReadLine();
        PhoneNumber1();
        string phone = Console.ReadLine();
        
        Console.Write("Password : ");
        string password = ReadPassword();
        IsPassword(password);
        
        this._context.AuthService.Registration(name, password, phone);
        Console.ReadKey();
    }

   
    public bool IsPassword(string password)
    {
        if (password.Length < 6)
            return false;

        bool raqam = false;
        bool harf = false;

        foreach (var pas in password)
        {
            if (char.IsLetter(pas))
                return true;
            if (char.IsNumber(pas))
                return true;
        }

        return raqam && harf;
    }
    public string ReadPassword()
    {
        string password = "";
        ConsoleKeyInfo key;
        do
        {
            key = Console.ReadKey(true);
            if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Spacebar && key.Key != ConsoleKey.Tab)
            {
                password += key.KeyChar;
                Console.Write("*");
            }
            else
            {
                if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Remove(password.Length - 1);
                    Console.Write("\b \b");
                }
            }
        } while (key.Key != ConsoleKey.Enter || !IsPassword(password));
        
           
        return password;
    }


    public void PhoneNumber2(string phone )
    {
        bool he = true;
        while (he)
        {
            if (phone.Length == 9)
            {
                he = false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Raqam 9 ta sondan iborat bulishi kerak");
                Console.ReadKey();
                Console.Clear();
                PhoneNumber1();
            }
        }
    }
    public void PhoneNumber1()
    {
        Dictionary<string, string> cou = new Dictionary<string, string>()
        {
            ["UZ"] = "+998", // O'zbekiston
            ["RU"] = "+7", // Rossiya
            ["KZ"] = "+7", // Qozog'iston
        };

        foreach (var item in cou)
        {
            Console.WriteLine($"{item.Key}");
        }

        Console.Write("Davlatni Tanlang : ");
        string phon = Console.ReadLine().ToUpper();

        foreach (var item in cou)
        {
            if (phon == item.Key)
            {
                Console.Write($"{item.Key} >> {item.Value}");
            }
        }

    }
    

}