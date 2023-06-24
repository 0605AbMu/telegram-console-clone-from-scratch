using System.Drawing;

namespace ConsoleApp1;

public  partial class Layout
{ int write = -5;
    private int read = 3;
    public Layout(Point toppoint, Point left)
    {
        Toppoint = toppoint;
     
        BottoPoint = left;
     write = -5;
     read = -3;
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
        Console.CursorTop =   BottoPoint.Y-Toppoint.Y / 2+write;
        int lenght = BottoPoint.X - Toppoint.X;
        int middile = lenght - mesage.Length / 2+Toppoint.X/2;
        //sgdsdgConsole.WriteLine(lenght);
        Console.CursorLeft =middile;
        Console.WriteLine(mesage);
        write =+ 2;
    }

    public string Read()
    {
       
       
          Console.CursorTop =   BottoPoint.Y-Toppoint.Y / 2-read;
          int lenght = BottoPoint.X - Toppoint.X;
          int middile =Toppoint.X+lenght/4;
          Console.CursorLeft =middile;
          string content=Console.ReadLine();

          read =+ 2;
     return content;
    }
  
   
}
