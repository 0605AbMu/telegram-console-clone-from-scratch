
namespace TelegramClient.Auth.UI;

public class LoginUI : CMD
{
    
    public void LogView()
    {
        Console.CursorVisible = false;
        CursorSenter("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
        CursorSenterTop("Enter your phone number: ");
        CursorSenterDown("***** Welcome to login *****\n");
        Console.CursorLeft = 57;
        Console.CursorTop = 13;
        string logPhoneNumber = Console.ReadLine(); //regex qowiliwi kk!
        var logPhoneNumberLength = logPhoneNumber.Length;
        if (logPhoneNumberLength == "+998909221211".Length || logPhoneNumberLength == 9 || logPhoneNumberLength == 12)
            CheckSMS(logPhoneNumber);
        else
        {
            Console.Clear();
            CursorSenter(9,-1, "Nomer hato!");
            //Console.CursorLeft = 50;
            //Console.CursorTop = 11;
            CursorSenter(0, 1, "Press any key to continue...");
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

        Console.Clear();
        CursorSenterTop(4,0, "Enter your a SMS: ");
        CursorSenterDown(5,0, "Checking your a SMS");
        
        CursorSenter(12,0);
        string SMS = Console.ReadLine();

        
    }
}