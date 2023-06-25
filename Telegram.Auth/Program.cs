using System.Drawing;
using TelegramClient.Auth.UI;

internal class Program
{
    public static void Main()
    {
        new Context(new Point(10, 0), new Point(30, 10)).Start();
    }
}