using System.Drawing;

namespace ConsoleApp1;

public class Layout
{
    public int RowCount { get; set; } = -5;

    public Layout(Point topPoint, Point bottomPoint)
    {
        Toppoint = topPoint;
        BottoPoint = bottomPoint;
    }


    public Point Toppoint { get; set; }
    public Point BottoPoint { get; set; }

    public void Ramka()
    {
        Console.CursorLeft = Toppoint.X;
        Console.CursorTop = Toppoint.Y;
        Console.WriteLine("".PadRight(BottoPoint.X - Toppoint.X, '*'));
        for (var i = 0; i < BottoPoint.Y - Toppoint.Y; i++)
        {
            Console.CursorLeft = Toppoint.X;


            Console.WriteLine("|".PadRight(BottoPoint.X - Toppoint.X - 1, ' ') + "|");
        }

        Console.CursorLeft = Toppoint.X;
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
        // Console.CursorTop = BottoPoint.Y - Toppoint.Y / 2; Bo'lish va Ko'paytirish qolganlariga qaraganda avvalroq bajariladi.
        // Shu sababdan yozuv tagiga chiqib qolavergan
        Console.CursorTop = (BottoPoint.Y - Toppoint.Y) / 2 + RowCount;
        var lenght = BottoPoint.X - Toppoint.X;
        var middile = lenght / 2 - mesage.Length / 2 + Toppoint.X;
        Console.CursorLeft = middile;
        Console.Write(mesage);
        this.RowCount++;
    }

    public string Read()
    {
        // Console.CursorTop = BottoPoint.Y - Toppoint.Y / 2; Bo'lish va Ko'paytirish qolganlariga qaraganda avvalroq bajariladi.
        // Shu sababdan yozuv tagiga chiqib qolavergan
        Console.CursorTop = (BottoPoint.Y - Toppoint.Y) / 2 + RowCount;
        var lenght = BottoPoint.X - Toppoint.X;
        var middile = Toppoint.X + lenght / 4;
        Console.CursorLeft = middile;
        var content = Console.ReadLine();
        this.RowCount++;
        return content;
    }
}