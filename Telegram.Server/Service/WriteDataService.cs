using Telegram.Client;
using Telegram.Server.Models;
using TelegramChat.Service.Interface;
using TelegramClient.Auth.Auth;

namespace Telegram.Server.Service;

public class WriteDataService : IWriteDataService
{
    private readonly SaveDataModels<IChatService> _chatServiceSaveData;
    private readonly SaveDataModels<IClientService> _clientServiceSaveData;
    private readonly SaveDataModels<IMessageService> _messageServiceSaveData;
    private readonly IServiceBase _serviceBase;
    private readonly SaveDataModels<IUserService> _userServiceSaveData;


    public WriteDataService(
        //Bu save data model telegram.Client dagi user lar uchun
        SaveDataModels<IClientService> clientServiceSaveData,
        //Bu save data model Telegram.Auth dagi user lar uchun
        SaveDataModels<IUserService> userServiceSaveData,
        //Bu save data model Telegram.Chat dagi user lar uchun
        SaveDataModels<IChatService> chatServiceSaveData,
        //Bu save data model Telegram.Chat dagi message lar uchun
        SaveDataModels<IMessageService> messageServiceSaveData,
        IServiceBase serviceBase)
    {
        _clientServiceSaveData = clientServiceSaveData;
        _userServiceSaveData = userServiceSaveData;
        _chatServiceSaveData = chatServiceSaveData;
        _messageServiceSaveData = messageServiceSaveData;
        _serviceBase = serviceBase;
    }

    /// <summary>
    ///     Bu metod client service dagi ma'lumotlarni saqlash uchun
    /// </summary>
    public void SaveClientServiceData()
    {
        _serviceBase.WriteTo(_clientServiceSaveData.Service.GetAllModel(), _clientServiceSaveData.FilePath);
    }

    /// <summary>
    ///     Bu methodning vazifasi user service dagi ma'lumotlarni saqlash
    /// </summary>
    public void SaveUserServiceData()
    {
        _serviceBase.WriteTo(_userServiceSaveData.Service.GetAllModel(), _userServiceSaveData.FilePath);
    }

    /// <summary>
    ///     Bu metodning vazifasi chat service dagi malumotlarni saqlash
    /// </summary>
    public void SaveChatServiceData()
    {
        _serviceBase.WriteTo(_chatServiceSaveData.Service.GetAllModel(), _chatServiceSaveData.FilePath);
    }

    /// <summary>
    ///     Bu metodning vazifasi message service dagi malumotlarni saqlash
    /// </summary>
    public void SaveMessageServiceData()
    {
        _serviceBase.WriteTo(_messageServiceSaveData.Service.GetAllModel(), _messageServiceSaveData.FilePath);
    }
}