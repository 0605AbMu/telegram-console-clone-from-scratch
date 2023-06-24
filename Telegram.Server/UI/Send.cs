using System.Drawing;

namespace Telegram.Server.UI;
/// <summary>
/// Send class ChatService ning UI qismi uchun view tayyorlab beradi
/// </summary>
public partial class Send
{
   
    public  Send(Point top, Point left)
    {
        Top = top;
        Button = left;
    }
    
    public Point Top { get; set; }
    public Point Button { get; set; }

    public void Clear()
    {
        Console.CursorLeft = Top.X;
        Console.CursorTop = Top.Y;
        int x = Button.X - Top.X;
        int y = Button.Y - Top.Y;
        for(int i = 0; i < y; i++)
        {
            for(int j = 0; j < x; j++)
            {
                Thread.Sleep(20);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.CursorLeft = Top.X;
        }
    }
/// <summary>
/// Enter , Tab, Esc, BackSpace tugmalarini yasash
/// </summary>
/// <param name="massage"></param>
    public string Input(string massage)
    {
        Console.CursorLeft = Top.X;
        Console.CursorTop = Top.Y;
        int x = Button.X - Top.X;
        int y = Button.Y - Top.Y;
        foreach (var i in massage.Chunk(x))
        {
            Console.Write(i); 
            Console.WriteLine();
            Console.CursorLeft = Top.X;
        }

        return "";
    }


}