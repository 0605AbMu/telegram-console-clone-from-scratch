using TelegramChat.Domain;

namespace TelegramClient.Auth.Domain;

public class User : ModelBase
{
    public string Name { get; set; }
    public string Password { get; set; }
    public string Phonenumber { get; set; }
    public Guid ClientId { get; set; }
}