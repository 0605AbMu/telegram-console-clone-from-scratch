using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Domain;
using TelegramClient.Auth.Service.Interface;

namespace TelegramClient.Auth.Service;

public class AuthService : IAuthService
{
    private readonly IUserService _userService;

    public AuthService(IUserService userService)
    {
        _userService = userService;
    }

    public User Login(string phoneNumber, string password)
    {
        var user = this._userService.GetAllModel().Find(x => x.Phonenumber == phoneNumber && x.Password == password);
        if (user == null)
            return new User();
        return user;
    }

    public void Registration(string name, string password, string phoneNumber)
    {

        var userPhoneNumber = this._userService.GetAllModel().Find(x => x.Phonenumber == phoneNumber);
        if (userPhoneNumber == null)
        {
            this._userService.Add(new User()
            {
                Name = name,
                Password = password,
                Phonenumber = phoneNumber,
                ClientId = Guid.NewGuid(),
                Id = Guid.NewGuid(),
            });
            return;
        }
        else
        {
            throw new Exception("This nummber is already exits");
        }

    }
}