using System.Drawing;
using Telegram.Clent.UI;
using TelegramChat.Domain;


public class Layout
{
    public delegate void OnKeys();
    public OnKeys OnArrowUpKey;
    public OnKeys OnArrowDownKey;
    public OnKeys OnArrowRightKey;
    public OnKeys OnArrowLeftKey;
    public OnKeys OnArrowEnterKey;
    public OnKeys OnArrowSpaceKey;
    public Layout(Point top, Point left)
    {
        Top = top;
        Button = left;
    }

    public Point Top { get; set; }
    public Point Button { get; set; }
    private int massageLine = 0;

    public void Clear()
    {
        Console.CursorLeft = Top.X;
        Console.CursorTop = Top.Y;
        int x = Button.X - Top.X;
        int y = Button.Y - Top.Y;
        for (int i = 0; i < y + 2; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write(" ");
            }

            Console.WriteLine();
            Console.CursorLeft = Top.X;
        }

        massageLine = 0;
    }

    private int ActivIndex = 1;

    public void Write(ViewModel viewModel)
    {
        Console.CursorLeft = Top.X + 2;
        Console.CursorTop = Top.Y + 1 + massageLine;
        int x = Button.X - Top.X;
        int y = Button.Y - Top.Y;
        string str = "";
        int hour = 0;
        int minut = 0;
        string massage = "";
        string chatData = "";
        


        hour = viewModel.MessageDate.Hour;
        minut = viewModel.MessageDate.Minute;
        string hours = "";
        if (hour < 10 )
            hours += "0";
        hours += hour.ToString() + ":";
        if (minut < 10)
            hours += "0";
        hours += minut.ToString();

        chatData = $"{viewModel.ClientName.PadRight(Button.X - Top.X - 11, ' ')} {hours}\n";
        if (ActivIndex == 1)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            ActivIndex++;
        }
        Console.Write(chatData);

        Console.CursorLeft = Top.X + 2;
        if (viewModel.LastMessage.Length > Button.X - Top.X)
            massage = viewModel.LastMessage.Substring(0, Button.X - Top.X - 8) + "...\n";

        else
            massage = $"{viewModel.LastMessage.PadRight(Button.X - Top.X - 5, ' ')}\n";

        Console.Write(massage);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

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
        int x = Button.X - Top.X;
        int y = Button.Y - Top.Y;
        Console.WriteLine("-".PadRight(Button.X - Top.X, '-'));
        for (int i = 0; i < y; i++)
        {
            Console.CursorLeft = Top.X;
            Console.Write("|");
            Console.CursorLeft = (Button.X - Top.X) + Top.X - 1;
            Console.Write("|");
            Console.WriteLine();
        }

        Console.CursorLeft = Top.X;
        Console.WriteLine("-".PadRight(Button.X - Top.X, '-'));
    }
}