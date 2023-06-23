using Telegram.Clent.Services;
using TelegramChat.Domain;
using TelegramChat.Service.Interface;

namespace TelegramChat.Service;

public class ChatService : ServiceBase<Chat>, IChatService
{
    private readonly IMessageService _messageService;

    public ChatService(IMessageService messageService)
    {
        _messageService = messageService;
    }
    public void CreateChat(Guid ownerId, string name, bool isPrivate = true)
    {
        throw new NotImplementedException();
    }

    public void JoinChat(Guid chatId, Guid clientId)
    {
        throw new NotImplementedException();
    }

    public void AddAMessageToChat(Guid chatId, Guid fromId, string message)
    {
        throw new NotImplementedException();
    }
}