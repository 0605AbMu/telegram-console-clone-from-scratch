using TelegramClient.Auth.Domain;

namespace TelegramClient.Auth.Service.Interface;

public interface IAuthService
{
    public User Login(string phoneNumber, string password);
    public void Registration(string name, string password, string phoneNumber);
}