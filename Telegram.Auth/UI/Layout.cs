using System.Drawing;

namespace ConsoleApp1;

public  partial class Layout
{
    public Layout(Point toppoint, Point left)
    {
        Toppoint = toppoint;
     
        BottoPoint = left;
        
    }
    
    
    public Point Toppoint { get; set; }
    public Point BottoPoint { get; set; }

    public void Ramka()
    {
        Console.CursorLeft = Toppoint.X;
        Console.CursorTop = Toppoint.Y;
        Console.WriteLine("".PadRight(BottoPoint.X - Toppoint.X, '*'));
        for (int i = 0; i < BottoPoint.Y-Toppoint.Y; i++)
        {
        Console.CursorLeft = Toppoint.X;
     
            
        Console.WriteLine("|".PadRight(BottoPoint.X-Toppoint.X-1,' ')+"|");
        }Console.CursorLeft = Toppoint.X;
        Console.WriteLine("".PadRight(BottoPoint.X - Toppoint.X, '*'));

        // Console.CursorLeft = Toppoint.X + Toppoint.X;
        // Console.CursorTop = Toppoint.Y+Toppoint.Y;
        // foreach (var VARIABLE in message.Chunk(BottoPoint.X))
        // {
        //     Console.WriteLine(VARIABLE);
        // }

    }

    public void Write(string mesage)
    {
        Console.CursorTop =   BottoPoint.Y-Toppoint.Y / 2-5;
        int lenght = BottoPoint.X - Toppoint.X;
        int middile = lenght - mesage.Length / 2+Toppoint.X/2;
        Console.WriteLine(lenght);
        Console.CursorLeft =middile;
        Console.WriteLine(mesage);
    }

    public string Read()
    {
       
       
          Console.CursorTop =   BottoPoint.Y-Toppoint.Y / 2-2;
          int lenght = BottoPoint.X - Toppoint.X;
          int middile =Toppoint.X+lenght/4;
          Console.CursorLeft =middile;
          string content=Console.ReadLine();
       
      
     return content;
    }
   
}
