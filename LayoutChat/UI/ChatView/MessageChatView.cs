using System.Drawing;
using TelegramChat.Service;

namespace LayoutChat.UI.ChatView;

public class MessageChatView : ChatContext
{
    public MessageChatView(ClientService clientService) : base(clientService)
    {
        
    }
    
}