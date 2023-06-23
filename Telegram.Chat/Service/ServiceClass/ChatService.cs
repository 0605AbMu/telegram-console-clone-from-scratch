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

    public void SetModel(List<Chat> data)
    {
        if(data is null)
            return;
        _chatlist = data;
    }

    

    
    
    
    
    public void CreateChat(Guid ownerId, string name, bool isPrivate = true)
        => _chatlist.Add(new Chat()
        {
            clientId = ownerId,
            Name = name,
            isPrivate = isPrivate
        });
    

    public void JoinChat(Guid chatId, Guid clientId)
        => _chatlist.Find(x => x.Id == chatId).clientIdList.Add(clientId);

    
    public void AddAMessageToChat(Guid chatId, Guid fromId, string message)
        => _chatlist.Find(x => x.Id == chatId).massageList.Add(new Message()
        {
            ChatId = chatId,
            ClientId = fromId,
            MessageClient = message,
            Time = DateTime.Now,
            Id=Guid.NewGuid()
        });
}