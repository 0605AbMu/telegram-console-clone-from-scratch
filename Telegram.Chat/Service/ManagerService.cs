using TelegramChat.Domain;

namespace TelegramChat.Service;

public class ManagerService
{
    private readonly ChatService _chatService;

    public ManagerService()
    {
        _chatService = new ChatService();
    }

/// <summary>
/// Add Chart 
/// </summary>
/// <param name="clientIdList"></param>
/// <returns></returns>
    public Guid AddCht(List<Guid> clientIdList)
    {
        Guid chatId=Guid.NewGuid();
        Chat chat = new Chat()
        {
            clientIdList = clientIdList,
            Id=chatId,
            massageList = new List<Message>()
            {
            }
        };
        return chatId;
    }
    
/// <summary>
/// Chat creat and massange Add
/// </summary>
/// <param name="clientIdList"></param>
/// <param name="clientId"></param>
/// <param name="massage"></param>
/// <returns></returns>
    public Guid AddChatAndAddMassage(List<Guid> clientIdList, Guid clientId, string massage)
    {
        Guid chatId = Guid.NewGuid();
        Message _massage = new Message()
        {
            MessageClient = massage,
            Id =  Guid.NewGuid(),
            Time = DateTime.Now,
            ClientId = clientId
        };
        Chat chat = new Chat()
        {
            clientIdList = clientIdList,
            Id=chatId,
            massageList = new List<Message>()
            {
                _massage
            }
        };

        return chatId;
    }

/// <summary>
    /// Chat Delete
    /// </summary>
    /// <param name="chatId"></param>
    public void DaleteChat(Guid chatId)=>_chatService.Delete(_chatService.FindModel(chatId));

        /// <summary>
/// Chat List
/// </summary>
/// <returns></returns>
    public List<Chat> GetAllChat() => _chatService.GetAllModel();
    
/// <summary>
/// Chat Find
/// </summary>
/// <param name="chatId"></param>
/// <returns></returns>
public Chat FindChat(Guid chatId) => _chatService.FindModel(chatId);
    public void AddChatToClient(Guid chatId, Guid clientId) =>
        _chatService.FindModel(chatId).clientIdList.Add(clientId);

    /// <summary>
    /// Massage Add
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="clientId"></param>
    /// <param name="massage"></param>
    public void AddMassageToChat(Guid chatId, Guid clientId, string massage) => _chatService.FindModel(chatId)
        .massageList.Add(new Message()
        {
            ClientId = clientId,
            MessageClient = massage,
            Time = DateTime.Now,
            Id = Guid.NewGuid()
        });
    
    /// <summary>
    ///  Chat To Massage delete
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="massage"></param>
    public void DeleteMassage(Guid chatId, Message massage)
    {
        Chat chat = _chatService.FindModel(chatId);
        if(chat==null)
            return;
        chat.massageList.Remove(massage);
    }
    
    /// <summary>
    /// Chat of Massage list
    /// </summary>
    /// <param name="chatId"></param>
    /// <returns></returns>
    public List<Message> GetAllMassageList(Guid chatId) => _chatService.FindModel(chatId).massageList;
    
    
    /// <summary>
    /// Chat of Massage Find
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="masssgeId"></param>
    /// <returns></returns>
    public Message FindMassage(Guid chatId, Guid masssgeId) =>
        _chatService.FindModel(chatId).massageList.Find(x=>x.Id==masssgeId);

/// <summary>
/// Chat of client list
/// </summary>
/// <param name="ChatId"></param>
/// <returns></returns>
    public List<Guid> ChatOfClientId(Guid ChatId) => _chatService.FindModel(ChatId).clientIdList;

}