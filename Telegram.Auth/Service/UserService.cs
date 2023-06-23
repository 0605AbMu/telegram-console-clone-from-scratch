using Telegram.Clent.Services;
using TelegramClient.Auth.Domain;

namespace TelegramClient.Auth.Auth;

public class UserService : ServiceBase<User>, IUserService
{

    // public User Registration(string name, string password, string phonenumber)
    // {
    //     if (null != users)
    //     {
    //         foreach (var user in users)
    //         {
    //             if (user != null)
    //             {
    //                 if (user.Phonenumber == phonenumber)
    //                 {
    //                     throw new Exception("bunaqa odam mabjud\nva qowilmadi");
    //                     return null;
    //                 }
    //             }
    //         }
    //     }
    //
    //     var regUser = new User()
    //     {
    //         Name = name,
    //         Password = password,
    //         Phonenumber = phonenumber,
    //         Guid = Guid.NewGuid(),
    //         ID = Guid.NewGuid()
    //     };
    //     users.Add(regUser);
    //     return regUser;
    // }
    //
    // //CRUD
    // public void AddUser(string name, string phoneNumber, string password)
    // {
    //     User user = new User()
    //     {
    //         Name = name,
    //         Phonenumber = phoneNumber,
    //         Password = password,
    //         Guid = Guid.NewGuid(),
    //         ID = Guid.NewGuid(),
    //     };
    //     this.users.Add(user);
    // }
    //
    // public List<User> GetAllUser()
    // {
    //     return this.users;
    // }
    //
    // public void RemoveUser(Guid id, string phoneNumber)
    // {
    //     if (users != null)
    //     {
    //         foreach (User user in this.users)
    //         {
    //             if (user != null)
    //             {
    //                 if (user.Id == id && user.Phonenumber == phoneNumber)
    //                 {
    //                     this.users.Remove(user);
    //                 }
    //             }
    //         }
    //     }
    // }
    //
    //
    // //UPDATE
    // /*public void UpDate(Guid id, string? name, string? phoneNumber)
    // {
    //     foreach (var user in this.Users)     
    //     {
    //         if (user.ID == id && (user.Name == name || user.Phonenumber == phoneNumber))
    //         {
    //             User user1 = new User()
    //             {
    //                 Name = name,
    //                 
    //             }
    //         }
    //     }
    // }*/
}