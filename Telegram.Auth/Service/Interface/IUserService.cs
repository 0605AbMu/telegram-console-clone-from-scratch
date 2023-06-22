using TelegramClient.Auth.Domain;

namespace TelegramClient.Auth.Auth;

public interface IUserService
{
    void AddUser(string name, string phoneNumber, string password);
    List<User> GetAllUser();
    void RemoveUser(Guid id, string phoneNumber);
   // void UpDate(Guid id, string? name , string? phoneNumber);
}