using System.Drawing;
using TelegramChat.Domain;
using TelegramChat.Service;
using TelegramChat.Service.Interface;

namespace LayoutChat.UI;

public class LayoutMessage
{
    public Point Top { get; set; }
    public Point Button { get; set; }
    private readonly ClientService _clientService;
    private readonly ManagerService _managerService;
    
    public LayoutMessage(Point top, Point left,ClientService clientService,ManagerService managerService)
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

    public void Clear()
    {
        Console.CursorLeft = Top.X;
        Console.CursorTop = Top.Y;
        int x = Button.X - Top.X;
        int y = Button.Y - Top.Y;
        for(int i = 0; i < y; i++)
        {
            Console.Write("".PadRight(x,'+'));
            Console.WriteLine();
            Console.CursorLeft = Top.X;
        }
    }


    public void Write(Guid chatId)
    {
        Console.CursorLeft = Top.X;
        Console.CursorTop = Top.Y;
        int x = Button.X - Top.X;
        int y = Button.Y - Top.Y;
        foreach (var message in _managerService.GetChatMessages(chatId))
        {
            
            
            
            
        }
        
        
        
        
    }
    
    
    
    
    public void Initial()
    {
        Console.CursorLeft = Top.X;
        Console.CursorTop = Top.Y;
        int x = Button.X - Top.X;
        int y = Button.Y - Top.Y;
        Console.WriteLine("".PadRight(x,'-'));
        Console.CursorLeft = Top.X;
        for (int i = 0; i < y; i++)
        {
            Console.WriteLine("|".PadRight(x-1)+"|");

            
            Console.CursorLeft = Top.X;
        }
        Console.WriteLine("".PadRight(x,'-'));
        
        
        
          
    }
    
    
}