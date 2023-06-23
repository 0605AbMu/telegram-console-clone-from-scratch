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
        throw new NotImplementedException();
    }

    public void Registration(string name, string password, string phoneNumber)
    {
        throw new NotImplementedException();
    }
}