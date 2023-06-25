using TelegramChat.Domain;
using TelegramChat.Service.Interface;

namespace TelegramChat.Service.ServiceClass;

public class ChatService : IChatService
{
    public readonly MessageService _messageService;
    private List<Chat> _chatlist;

    public ChatService()
    {
        _chatlist = new List<Chat>();
        _messageService = new MessageService();
    }

    public void Add(Chat data)
    {
        _chatlist.Add(data);
    }

    public void Delete(Chat data)
    {
        _chatlist.Remove(data);
    }

    public List<Chat> GetAllModel()
    {
        return _chatlist;
    }

    public Chat FindModel(Guid id)
    {
        return _chatlist.Find(x => x.Id == id);
    }

    public void SetModel(List<Chat> data)
    {
        if (data is null)
            return;
        _chatlist = data;
    }

    public void CreateChat(Guid ownerId, string name, bool isPrivate = true)
    {
        Add(new Chat
        {
            clientId = ownerId,
            Name = name,
            isPrivate = isPrivate
        });
    }


    public void JoinChat(Guid chatId, Guid clientId)
    {
        _chatlist.Find(x => x.Id == chatId).clientIdList.Add(clientId);
    }

    public void AddAMessageToChat(Guid chatId, Guid clientId, string message)
    {
        _messageService.Add(new Message
        {
            ChatId = chatId,
            ClientId = clientId,
            MessageClient = message,
            Id = Guid.NewGuid(),
            Time = DateTime.Now
        });
    }

    public IEnumerable<Message?> GetChatMessages(Guid chatId)
    {
        return _messageService.GetAllModel().Select(x => { return x.ChatId == chatId ? x : null; });
    }
}