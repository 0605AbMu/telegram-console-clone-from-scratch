using TelegramClient.Auth.Domain;

namespace TelegramClient.Auth.Auth;

public interface IService
{
     Guid Logins(string ponenumber, string password);
     User Registration(string name, string password, string phonenumber);
}