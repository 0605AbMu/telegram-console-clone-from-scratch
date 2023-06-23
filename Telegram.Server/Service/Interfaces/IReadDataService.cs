namespace Telegram.Server.Service;

public interface IReadDataService
{
    public void LoadUserServiceData();
    public void LoadClientServiceData();
    public void LoadChatServiceData();
    public void LoadMessageServiceData();
}