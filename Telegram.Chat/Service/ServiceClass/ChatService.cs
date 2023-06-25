using TelegramChat.Domain;
using TelegramChat.Service.Interface;

namespace TelegramChat.Service.ServiceClass;

public class ChatService : IChatService
{
    public readonly MessageService _messageService;
    private List<Chat> _chatlist;

    public ChatService()
    {
        _chatlist = new List<Chat>()
        {
            new Chat()
            {
                isPrivate = true,
                Id = Guid.Parse("66401350-8A02-48BF-A105-2493A35ECD41"),
                Name = "G1 Team Group",
                clientId = Guid.Parse("6F8320E5-1D1B-4404-9FAA-4E70D4E0C96E"),
            }
        };
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
        // return _messageService.GetAllModel().Select(x => { return x.ChatId == chatId ? x : null; });
        // Bu noto'g'ri yozilibdi. Ko'rib chiqish lozim
        return _messageService.GetAllModel().Where(x => x.ChatId == chatId);
    }
}