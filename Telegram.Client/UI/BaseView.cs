namespace Telegram.Clent.UI;

public class BaseView
{
    protected readonly ContextClient _context;
    protected int index = 1;

    public BaseView(ContextClient context)
    {
        _context = context;
    }

    public Client.Domain.Client SignedUser { get; set; }


    public void Start()
    {
        Home();
    }

    public virtual void Home(string? message = null)

    {
        Console.Clear();
        if (message is not null)
            Console.WriteLine(message);
    }

    public void LogOut()
    {
        Console.WriteLine("Are you sure to log out?(Y/N)");
        if (Console.ReadKey().Key == ConsoleKey.Y) return;
        Home();
    }
}