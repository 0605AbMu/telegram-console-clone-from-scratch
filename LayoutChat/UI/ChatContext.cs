using System.Drawing;
using LayoutChat.UI.ChatView;
using TelegramChat.Domain;
using TelegramChat.Service.ServiceClass;

namespace LayoutChat.UI;

public class ChatContext
{
    private Guid ActiveId { get; set; }
    private MessageChatView _messageChatView;
    
    public ChatContext(Point top,Point left,ClientService clientService)
    {
        _messageChatView = new MessageChatView(top, left, clientService);
    }

    public void Start()
    {
        this.Home();
    }

    public void Home()
    {
        Console.Clear();
        if (ActiveId == null)
        {
            Console.WriteLine("Client Not Find");
        }
        _messageChatView.PrintMessage(ActiveId);
    }
    
}