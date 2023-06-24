using System.Drawing;

namespace LayoutChat.UI;

public class LayoutChat
{
    public Point Top { get; set; }
    public Point Button { get; set; }
    
    public LayoutChat(Point top, Point left)
    {
        Top = top;
        Button = left;
    }

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
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.CursorLeft = Top.X;
        }
    }
    
    
    
    
    
    
}