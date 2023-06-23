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

    public void AddChat(string chatName, bool isPrivate,Guid chatClientId, List<Guid> clientIdList)
        => _factoryChatService.AddChat(chatName,isPrivate, chatClientId, clientIdList);
    public void DeleteChat(Guid chatId) 
        => _factoryChatService.DeleteChat(chatId);

    public Chat GetByIdChat(Guid chatId)
        => _factoryChatService.GetByIdChat(chatId);


    public void SetChat(List<Chat> chatList)
        => _factoryChatService.SetChat(chatList);
    
    public List<Chat> GetAllChat()
        => _factoryChatService.GetAllChatList();

    
    
    
    
    public void CreateChat(Guid ownerId, string name, bool isPrivate = true)
        => _factoryChatService.CreateChat(ownerId, name, isPrivate);
    
    
    public void JoinChat(Guid chatId, Guid clientId)
        => _factoryChatService.JoinChat(chatId, clientId);
    
    public void AddAMessageToChat(Guid chatId, Guid fromId, string message)
        => _factoryChatService.AddAMessageToChat(chatId, fromId, message);


    
    
    
    
    
    
    
    
    #endregion


    #region message

    public void AddMessage(Guid chatId, Guid clientId, string message)
        => _fartoryMessageservice.AddMessage(chatId, clientId, message);

    public void DeleteMessage(Guid messageId)
        => _fartoryMessageservice.DeleteMessage(messageId);

   
    public Message GetByIdMessage(Guid messageId)
        => _fartoryMessageservice.GetByIdMessage(messageId);

    public List<Message> GetAllMessageList(Guid chatId)
        => _fartoryMessageservice.GetAllMessage(chatId);


    public void SetMessage(List<Message> messageList)
        => _fartoryMessageservice.SetMessage(messageList);

    #endregion







}