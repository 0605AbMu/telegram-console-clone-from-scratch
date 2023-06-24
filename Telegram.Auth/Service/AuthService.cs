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
        _userService.Add(new User()
        {
            ClientId = Guid.Parse("6F8320E5-1D1B-4404-9FAA-4E70D4E0C96E"),
            Id = Guid.NewGuid(),
            Password = "123",
            Phonenumber = "123",
            Name = "Olim"
        });
    }

    public User Login(string phoneNumber, string password)
    {
        var user = this._userService.GetAllModel().Find(x => x.Phonenumber == phoneNumber && x.Password == password);
        if (user == null)
            return new User();
        return user;
    }

    public void Registration(string name, string password, string phoneNumber, Guid clientId)
    {

        var userPhoneNumber = this._userService.GetAllModel().Find(x => x.Phonenumber == phoneNumber);
        if (userPhoneNumber == null)
        {
            this._userService.Add(new User()
            {
                Name = name,
                Password = password,
                Phonenumber = phoneNumber,
                ClientId = clientId,
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