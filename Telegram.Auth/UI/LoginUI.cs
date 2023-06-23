
namespace TelegramClient.Auth.UI;

public class LoginUI
{
    public void CursorSenter()
    {
        Console.CursorLeft = 50;
        Console.CursorTop = 13;
    }
    public void CursorSenter(int x, int y)
    {
        Console.CursorLeft = 50 + x;
        Console.CursorTop = 13 + y;
    }
    public void CursorSenterTop()
    {
        Console.CursorLeft = 51;
        Console.CursorTop = 6;
    }
    private void CursorSenterDown()
    {
        Console.CursorLeft = 49;
        Console.CursorTop = 20;
    }

    public void LogView()
    {
        CursorSenter();
        Console.CursorVisible = false;
        Console.Write("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
        CursorSenterTop();
        Console.Write("Enter your phone number: ");
        CursorSenterDown();
        Console.WriteLine("***** Welcome to login *****\n");
        Console.CursorLeft = 57;
        Console.CursorTop = 13;
        string logPhoneNumber = Console.ReadLine(); //regex qowiliwi kk!
        var logPhoneNumberLength = logPhoneNumber.Length;
        if (logPhoneNumberLength == "+998909221211".Length || logPhoneNumberLength == 9 || logPhoneNumberLength == 12)
            CheckSMS(logPhoneNumber);
        else
        {
            Console.Clear();
            CursorSenter(9,-1);
            Console.WriteLine("Nomer hato!");
            //Console.CursorLeft = 50;
            //Console.CursorTop = 11;
            CursorSenter(0, 1);
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            LogView();
            return;
        }
    }

    private void CheckSMS(string logPhoneNumber)
    {
        Console.Clear();
        Console.WriteLine();
        Console.CursorLeft = 51;
        Console.CursorTop = 6;
        Console.WriteLine("Checking your a SMS");
        Console.Write("\nEnter your a SMS: ");
        string SMS = Console.ReadLine();


    }
}