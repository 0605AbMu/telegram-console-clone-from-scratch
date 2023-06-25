using TelegramChat.Domain;
using TelegramChat.Service.Interface;

namespace TelegramChat.Service.ServiceClass;

public class MessageService : IMessageService
{
    private List<Message> _messageList;

    public MessageService()
    {
        _messageList = new List<Message>();
        _messageList.Add(new Message()
        {
            Id = Guid.NewGuid(),
            Time = DateTime.Now,
            ChatId = Guid.Parse("66401350-8A02-48BF-A105-2493A35ECD41"),
            ClientId = Guid.Parse("6F8320E5-1D1B-4404-9FAA-4E70D4E0C96E"),
            MessageClient = "This is test message"
        });
    }


    public void Add(Message data)
    {
        _messageList.Add(data);
    }

    public void Delete(Message data)
    {
        _messageList.Remove(data);
    }

    public List<Message> GetAllModel()
    {
        return _messageList;
    }

    public Message FindModel(Guid id)
    {
        return _messageList.Find(x => x.Id == id);
    }

    public void SetModel(List<Message> data)
    {
        if (data is null)
            return;
        _messageList = data;
    }
}