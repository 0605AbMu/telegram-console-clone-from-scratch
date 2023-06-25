using System.Drawing;
using Telegram.Clent.UI;

public class Layout
{
    public delegate void OnKeys();

    private int massageLine;
    public OnKeys OnArrowDownKey;
    public OnKeys OnArrowEnterKey;
    public OnKeys OnArrowEscapeKey;
    public OnKeys OnArrowLeftKey;
    public OnKeys OnArrowRightKey;
    public OnKeys OnArrowTabKey;

    /// <summary>
    ///     Onkeys delegate ti orqali tugmalarni sozlab oldik.
    ///     OnArrowUpKey tepadagi strelka tugmasi ;
    ///     OnArrowDownKey pastdagi strelka tugmasi;
    ///     OnKeys OnArrowRightKey o'ngdagi strelka tugmasi;
    ///     OnKeys OnArrowLeftKey chapdagi strelka tugmasi;
    ///     OnKeys OnArrowEnterKey enter tugmasi;
    ///     OnKeys OnArrowTabKey tab tugmasi;
    ///     OnKeys OnArrowEscapeKey esc tugmasi;
    /// </summary>
    public OnKeys OnArrowUpKey;

    public Layout(Point top, Point left)
    {
        Top = top;
        Button = left;
    }

    public Point Top { get; set; }
    public Point Button { get; set; }


    /// <summary>
    ///     Readkey orqali tanlab kerakli menularga junatib yuboradi.
    /// </summary>
    public void ReadKey()
    {
        while (true)
        {
            var key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                {
                    OnArrowUpKey();
                    break;
                }
                case ConsoleKey.DownArrow:
                {
                    OnArrowDownKey();
                    break;
                }
                case ConsoleKey.RightArrow:
                {
                    OnArrowRightKey();
                    break;
                }
                case ConsoleKey.LeftArrow:
                {
                    OnArrowLeftKey();
                    break;
                }
                case ConsoleKey.Tab:
                {
                    OnArrowTabKey();
                    break;
                }
                case ConsoleKey.Enter:
                {
                    OnArrowEnterKey();
                    break;
                }
                case ConsoleKey.Escape:
                {
                    OnArrowEscapeKey();
                    break;
                }
            }
        }
    }

    public void Clear()
    {
        Console.CursorLeft = Top.X ;
        Console.CursorTop = Top.Y;
        var x = Button.X - Top.X;
        var y = Button.Y - Top.Y;
        for (var i = 0; i < y; i++)
        {
            Console.WriteLine("".PadRight(x, ' '));
            Console.CursorLeft = Top.X;
        }
        massageLine = 0;
    }

    public void Write(ViewModel viewModel)
    {
        Console.CursorLeft = Top.X + 2;
        Console.CursorTop = Top.Y + 1 + massageLine;
        var x = Button.X - Top.X;
        var y = Button.Y - Top.Y;
        var str = "";
        int hour;
        int minut;
        var massage = "";
        var chatData = "";


        hour = viewModel.MessageDate.Hour;
        minut = viewModel.MessageDate.Minute;

        chatData = $"{viewModel.ClientName.PadRight(Button.X - Top.X - viewModel.ClientName.Length - 5, ' ')} {hour}:{minut}\n";
        Console.Write(chatData);

        Console.CursorLeft = Top.X + 2;
        if (viewModel.LastMessage.Length > Button.X - Top.X)
            massage = viewModel.LastMessage.Substring(0, Button.X - Top.X - 8) + "...\n";

        else
            massage = $"{viewModel.LastMessage.PadRight(Button.X - Top.X - 5, ' ')}\n";

        Console.Write(massage);

        Console.CursorLeft = Top.X + 2;
        Console.Write("+" + "-".PadRight(Button.X - Top.X - 6, '-') + "+");

        Console.WriteLine();
        Console.CursorLeft = Top.X + 2;
        massage = "";
        //}

        massageLine += 3;
    }

    public void Initial()
    {
        Console.CursorLeft = Top.X;
        Console.CursorTop = Top.Y;
        var x = Button.X - Top.X;
        var y = Button.Y - Top.Y;
        Console.Write("".PadRight(x, '-'));
        Console.CursorLeft = Top.X;
        for (var i = 1; i <= y - 2; i++)
        {
            Console.CursorTop = Top.Y + i;
            Console.CursorLeft = Top.X;
            Console.Write("|".PadRight(x - 1) + "|");
        }
        Console.CursorLeft = Top.X;
        Console.Write("".PadRight(x, '-'));
    }
}