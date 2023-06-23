namespace TelegramClient.Auth.UI;

public class RegistraionUI
{
    private Context _context;

    public RegistraionUI()
    {
        this._context = new Context();
    }
    public void Registraion()
    {
        Console.CursorLeft = 30;
        Console.Write("Name : ");
        string name = Console.ReadLine();
        Console.Write("Password : ");
        string password = Console.ReadLine();
        Console.Write("Phone Number : ");
        string phone = Console.ReadLine();

    }
}