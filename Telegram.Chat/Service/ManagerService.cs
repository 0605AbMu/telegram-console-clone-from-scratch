using TelegramChat.Domain;

namespace TelegramChat.Service;

public class ManagerService
{
    private readonly FactoryChatService _factoryChatService;
    private readonly FartoryMessageservice _fartoryMessageservice;

    public ManagerService()
    {
        _factoryChatService = new FactoryChatService();
        _fartoryMessageservice = new FartoryMessageservice();
    }

    #region chat

    public void AddChat(List<Guid> clientIdList) 
        => _factoryChatService.AddChat(clientIdList);

    public void DeleteChat(Guid chatId) 
        => _factoryChatService.DeleteChat(chatId);

    public Chat GetByIdChat(Guid chatId)
        => _factoryChatService.GetByIdChat(chatId);

    public void AddRangeChat(List<Chat> chatList)
        => _factoryChatService.AddRangeChat(chatList);

    public List<Chat> GetAllChat()
        => _factoryChatService.GetAllChatList();

    #endregion


    #region message

    public void AddMessage(Guid chatId, Guid clientId, string message)
        => _fartoryMessageservice.AddMessage(chatId, clientId, message);

    public void DeleteMessage(Guid messageId)
        => _fartoryMessageservice.DeleteMessage(messageId);

    public void AddRangeMessage(List<Message> messageList)
        => _fartoryMessageservice.AddRangeMessage(messageList);

    public Message GetByIdMessage(Guid messageId)
        => _fartoryMessageservice.GetByIdMessage(messageId);

    public List<Message> GetAllMessageList(Guid chatId)
        => _fartoryMessageservice.GetAllMessage(chatId);


    #endregion







}