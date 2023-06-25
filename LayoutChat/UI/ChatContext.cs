using System.Drawing;
using LayoutChat.UI.ChatView;

namespace LayoutChat.UI;

public class ChatContext
{
    private readonly MessageChatView _messageChatView;

    public ChatContext(Point top, Point left, ClientService clientService)
    {
        _messageChatView = new MessageChatView(top, left, clientService);
    }

    private Guid ActiveId { get; }

    public void Start()
    {
        Home();
    }

    public void Home()
    {
        Console.Clear();
        if (ActiveId == null) Console.WriteLine("Client Not Find");
        _messageChatView.PrintMessage(ActiveId);
    }
}