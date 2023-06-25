using System.Drawing;
using LayoutChat.UI.ChatView;

namespace LayoutChat.UI;

public class ChatContext
{
    private readonly MessageChatView _messageChatView;

    public ChatContext(Point top, Point left, ClientService clientService)
    {
        _messageChatView = new MessageChatView(top, left, clientService);
        ActiveChatId = Guid.Parse("66401350-8A02-48BF-A105-2493A35ECD41"); //Test
    }

    private Guid? ActiveChatId { get; }

    public void Start()
    {
        Home();
    }

    public void Home()
    {
        // Console.Clear();Nega kerak bu
        if (ActiveChatId is not null)
            _messageChatView.PrintMessage(ActiveChatId.Value);
    }
}