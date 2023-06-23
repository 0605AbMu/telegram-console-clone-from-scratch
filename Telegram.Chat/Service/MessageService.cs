using TelegramChat.Domain;
using TelegramChat.Service.Interface;

namespace TelegramChat.Service;

public class MessageService : IMessageService
{
    private readonly List<Message> _massageList;

    public MessageService()
    {
        _massageList = new List<Message>();
    }

    public void Add(Message data)
    {
        _massageList.Add(data);
    }

    public void Delete(Message data)
    {
        _massageList.Remove(data);
    }

    public List<Message> GetAllModel()
    {
        return _massageList;
    }

    public Message FindModel(Guid id)
    {
        return _massageList.Find(x => x.Id == id);
    }

    public void AddRange(List<Message> data)
    {
        _massageList.AddRange(data);
    }
}