using TelegramChat.Domain;

namespace TelegramChat.Service;

public class FartoryMessageservice
{
    private readonly MessageService _messageService;

    public FartoryMessageservice()
    {
        _messageService = new MessageService();
    }

    public void AddMessage(Guid chatId,Guid clientId,string message)
    {
        _messageService.Add(new Message()
        {
            ChatId = chatId,
            ClientId = clientId,
            Id=Guid.NewGuid(),
            MessageClient = message,
             Time = DateTime.Now
        });
    }




}