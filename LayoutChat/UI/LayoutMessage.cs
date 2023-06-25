using System.Drawing;
using TelegramChat.Domain;
using TelegramChat.Service;

namespace LayoutChat.UI;

public class LayoutMessage
{
    private readonly ClientService _clientService;
    private readonly ManagerService _managerService;
    public int RowCount { get; set; }

    public LayoutMessage(Point top, Point bottom, ClientService clientService, ManagerService managerService)
    {
        Top = top;
        Button = bottom;
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
        this.RowCount = 0;
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


    public void Write(Message message)
    {
        var x = Button.X - Top.X;
        var y = Button.Y - Top.Y;
        if(RowCount == y)
            return;
        Console.CursorLeft = Top.X + 1;
        Console.CursorTop = Top.Y + 1 + RowCount;
        Console.Write("{0}   {1}:{2}", 
            _clientService.FindModel(message.ClientId).FullName, 
            message.Time.Hour, 
            message.Time.Minute);
        this.RowCount++;
        foreach (var msgChunk in message.MessageClient.Chunk(x - 3))
        {
            Console.CursorTop = Top.Y + 1 + RowCount;
            Console.CursorLeft = Top.X + 1;
            Console.Write(message.MessageClient);
            this.RowCount++;
        }

        this.RowCount++;
        // var str = "";
        // int hour;
        // int minut;
        // IEnumerable<char[]> messageArray;
        // var messageClient = "";
        // var chunksClientName = messageClient.Chunk(x - 2);
        // IEnumerable<char[]> chunkMessage;
        //
        // var s = 0;
        // foreach (var message in _managerService.GetChatMessages(chatId))
        // {
        //     s += message.MessageClient.Chunk(x - 2).Count();
        //
        //     s += messageClient.Chunk(x - 1).Count();
        // }
        // Console.CursorLeft = Top.X + 1;
        // Console.CursorTop = Top.Y + 1;
        // foreach (var message in _managerService.GetChatMessages(chatId))
        // {
        //     hour = message.Time.Hour;
        //     minut = message.Time.Minute;
        //
        //     messageClient = $"{_clientService.FindModel(message.ClientId).FullName.
        //         PadRight(Button.X - Top.X - 9, ' ')} {hour}:{minut}\n";
        //
        //     chunkMessage = message.MessageClient.Chunk(x - 2);
        //
        //     chunksClientName = messageClient.Chunk(x - 1);
        //     foreach (var chars in chunksClientName)
        //     {
        //         Console.CursorLeft = Top.X + 1;
        //         Console.WriteLine(chars);
        //     }
        //
        //     foreach (var iteam in chunkMessage)
        //     {
        //         Console.CursorLeft = Top.X + 1;
        //         Console.WriteLine(iteam);
        //     }
        // }
        //Og'abek aka yozgan kodingizni bir boshidan yaxshilab ko'rib chiqish lozim. Juda murakkab bo'lib ketgan?
        //Murakkab qilishdan maqsad nima baribir ham ko'zlagan maqsadga olib bormasa
    }


    // public void Initial(int rowCount) Bu yerga rowCount nega kerak. Rowning ramkaga nima aloqasi bor
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