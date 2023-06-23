
namespace TelegramClient.Auth.UI;

public class LoginUI
{
    public void LogView()
    {
        Console.Write("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("\n\t\t\t ***** Welcome to login *****\n");
        Console.Write("Enter your phone number: ");
        string logPhoneNumber = Console.ReadLine(); //regex qowiliwi kk!
        var logPhoneNumberLength = logPhoneNumber.Length;
        if (logPhoneNumberLength == "+998909221211".Length || logPhoneNumberLength == 9 || logPhoneNumberLength == 12)
            CheckSMS(logPhoneNumber);
        
    }

    private void CheckSMS(string logPhoneNumber)
    {
        Console.Clear();
        Console.WriteLine();
        Console.CursorLeft = 30;
        Console.WriteLine("Checking your a SMS");
        Console.Write("\nEnter your a SMS: ");
        string SMS = Console.ReadLine();


    }
}