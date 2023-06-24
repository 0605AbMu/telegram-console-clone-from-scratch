using System.Drawing;

namespace Telegram.Server.UI;
/// <summary>
/// Send class ChatView ning UI qismi uchun view tayyorlab beradi
/// </summary>
public partial class SendView
{
    public  SendView(Point top, Point left)
    {
        Top = top;
        Button = left;
    }
    
    public Point Top { get; set; }
    public Point Button { get; set; }

    public void LayOut()
    {
        Console.CursorLeft = Top.X;
        Console.CursorTop = Top.Y;
        int x = Button.X - Top.X;
        int y = Button.Y - Top.Y;
        for(int i = 0; i < y; i++)
        {
            for(int j = 0; j < x; j++)
            {
                if (i == 0 || i == y - 1 || j < x || j == x - 1)
                {
                    Console.Write("+");
                }
            }
            Console.WriteLine("\n");
            Console.CursorLeft = Top.X;
        }
    }
}
    


