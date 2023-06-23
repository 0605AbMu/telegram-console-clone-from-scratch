using System.Runtime.CompilerServices;

using TelegramChat.Domain;
using TelegramChat.Service.Interface;

namespace TelegramChat.Service;

public class ChatService :  IChatService
{
    private List<Chat> _chatlist;

    public ChatService()
    {
        _chatlist = new List<Chat>();
    }

    public void Add(Chat data)
        => _chatlist.Add(data);

    public void Delete(Chat data)
        => _chatlist.Remove(data);

    public List<Chat> GetAllModel()
        => _chatlist;

    public Chat FindModel(Guid id)
        => _chatlist.Find(x => x.Id == id);

    public void AddRange(List<Chat> data)
        => _chatlist.AddRange(data);
}