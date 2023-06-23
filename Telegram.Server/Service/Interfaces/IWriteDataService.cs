namespace Telegram.Server.Service;

public interface IWriteDataService
{
    public void SaveClientServiceData();
    public void SaveUserServiceData();
    public void SaveChatServiceData();
    public void SaveMessageServiceData();
}