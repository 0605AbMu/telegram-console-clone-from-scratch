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
        =>_messageService.Add(new Message()
        {
            ChatId = chatId,
            ClientId = clientId,
            Id=Guid.NewGuid(),
            MessageClient = message,
             Time = DateTime.Now
        });
    

    public void DeleteMessage(Guid messageId) 
        => _messageService.Delete(_messageService.FindModel(messageId));
    

    public Message GetByIdMessage(Guid messageId) 
        => _messageService.FindModel(messageId);

    
    public List<Message> GetAllMessage(Guid chatId)
        => (List<Message>)_messageService.GetAllModel()
            .Select(x => { return x.ChatId == chatId ? x : null; });

    
    public void AddRangeMessage(List<Message> messageList)
        => _messageService.AddRange(messageList);

}