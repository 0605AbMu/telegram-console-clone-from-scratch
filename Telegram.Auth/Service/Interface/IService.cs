using TelegramClient.Auth.Domain;

namespace TelegramClient.Auth.Auth;

public interface IService
{
     void Logins(string ponenumber, string password, Guid guid);
     User Registration(string name, string password, string phonenumber);
}