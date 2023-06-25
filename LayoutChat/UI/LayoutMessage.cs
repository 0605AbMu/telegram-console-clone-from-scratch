using System.Drawing;
using TelegramChat.Service;

namespace LayoutChat.UI;

public class LayoutMessage
{
    private readonly ClientService _clientService;
    private readonly ManagerService _managerService;

    public LayoutMessage(Point top, Point left, ClientService clientService, ManagerService managerService)
    {
        Top = top;
        Button = left;
        _clientService = clientService;
        _managerService = managerService;
    }

    public LayoutMessage(Point top, Point left)
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
        var x = Button.X - Top.X;
        var y = Button.Y - Top.Y;
        for (var i = 0; i < y; i++)
        {
            Console.Write("".PadRight(x, ' '));
            Console.WriteLine();
            Console.CursorLeft = Top.X;
        }
    }


    public void Write(Guid chatId)
    {
        Clear();
        var x = Button.X - Top.X;
        var y = Button.Y - Top.Y;
        var str = "";
        int hour;
        int minut;
        IEnumerable<char[]> messageArray;
        var messageClient = "";
        var chunksClientName = messageClient.Chunk(x - 2);
        IEnumerable<char[]> chunkMessage;

        var s = 0;
        foreach (var message in _managerService.GetChatMessages(chatId))
        {
            s += message.MessageClient.Chunk(x - 2).Count();

            s += messageClient.Chunk(x - 1).Count();
        }

        Initial(s);
        Console.CursorLeft = Top.X + 1;
        Console.CursorTop = Top.Y + 1;
        foreach (var message in _managerService.GetChatMessages(chatId))
        {
            hour = message.Time.Hour;
            minut = message.Time.Minute;

            messageClient = $"{_clientService.FindModel(message.ClientId).FullName.
                PadRight(Button.X - Top.X - 9, ' ')} {hour}:{minut}\n";

            chunkMessage = message.MessageClient.Chunk(x - 2);

            chunksClientName = messageClient.Chunk(x - 1);
            foreach (var chars in chunksClientName)
            {
                Console.CursorLeft = Top.X + 1;
                Console.WriteLine(chars);
            }

            foreach (var iteam in chunkMessage)
            {
                Console.CursorLeft = Top.X + 1;
                Console.WriteLine(iteam);
            }
        }
    }


    public void Initial(int rowCount)
    {
        Console.CursorLeft = Top.X;
        Console.CursorTop = Top.Y;
        var x = Button.X - Top.X;
        var y = rowCount;
        Console.WriteLine("".PadRight(x, '-'));
        Console.CursorLeft = Top.X;
        for (var i = 0; i < y; i++)
        {
            Console.WriteLine("|".PadRight(x - 1) + "|");
            Console.CursorLeft = Top.X;
        }

        Console.WriteLine("".PadRight(x, '-'));
    }
}