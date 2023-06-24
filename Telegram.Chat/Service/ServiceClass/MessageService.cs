using TelegramChat.Domain;
using TelegramChat.Service.Interface;

namespace TelegramChat.Service.ServiceClass;

public class MessageService :  IMessageService
{
    private List<Message> _messageList;

    public MessageService()
    {
        _messageList = new List<Message>();
    }

   
    public void Add(Message data)
        => _messageList.Add(data);

    public void Delete(Message data)
        => _messageList.Remove(data);

    public List<Message> GetAllModel()
        => _messageList;

    public Message FindModel(Guid id)
        => _messageList.Find(x => x.Id == id);

    public void SetModel(List<Message> data)
    {
        if(data is null)
            return;
        _messageList = data;
    }
    
    



}