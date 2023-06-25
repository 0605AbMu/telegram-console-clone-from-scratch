using TelegramChat.Domain;
using TelegramChat.Service.ServiceClass;

namespace TelegramChat.Service;

public class ManagerService
{
    private readonly ChatService _chatService;

    public void CreateChat(Guid ownerId, string name, bool isPrivate = true)
    {
        _chatService.CreateChat(ownerId, name, isPrivate);
    }

    public void DeleteChat(Guid chatId)
    {
        _chatService.Delete(_chatService.FindModel(chatId));
    }

    public List<Chat> GetAllChats()
    {
        return _chatService.GetAllModel();
    }

    public List<Chat> GetAllchatClient(Guid clientId)
    {
        return (List<Chat>)_chatService.GetAllModel().Select(x => { return x.clientId == clientId ? x : null; });
    }

    public Chat FindChat(Guid chatId)
    {
        return _chatService.FindModel(chatId);
    }

    public void JoinChat(Guid chatId, Guid clientId)
    {
        _chatService.JoinChat(chatId, clientId);
    }

    public void AddAMessageToChat(Guid chatId, Guid clientId, string message)
    {
        _chatService.AddAMessageToChat(chatId, clientId, message);
    }

    public IEnumerable<Message?> GetChatMessages(Guid chatId)
    {
        return _chatService.GetChatMessages(chatId);
    }

    public Message FindMessage(Guid messageId)
    {
        return _chatService._messageService.FindModel(messageId);
    }

    public void DeleteMessage(Guid messageId)
    {
        _chatService._messageService.Delete(_chatService._messageService.FindModel(messageId));
    }

    public void SetChat(List<Chat> chats)
    {
        _chatService.SetModel(chats);
    }

    public void SetMessage(List<Message> messages)
    {
        _chatService._messageService.SetModel(messages);
    }

    public Message GetLastMessage(Guid ChatId)
    {
        return _chatService.FindModel(ChatId).massageList.Last();
    }
}