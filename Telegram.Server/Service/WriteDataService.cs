using Telegram.Clent;
using Telegram.Clent.Domain;
using TelegramChat.Domain;
using TelegramChat.Service;

namespace Telegram.Server.Service;

public class WriteDataService
{
    private readonly IClientService _iclientService;
    private readonly ChatService _chatService;
    private readonly MessageService _messageService;

    public WriteDataService(IClientService IclientService, ChatService chatService,
                           MessageService messageService)
    {
        _iclientService = IclientService;
        _chatService = chatService;
        _messageService = messageService;
    }   
    
    void WriteClient()
    {
        
    }

    void WriteChat()
    {
        
    }

    void WriteMessage()
    {
            
    }
}