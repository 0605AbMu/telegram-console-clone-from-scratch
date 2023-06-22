using System.Security.AccessControl;

namespace TelegramClient.Auth.Domain;

public class User
{
    public string Name { get; set; }
    public string Password { get; set; }
    public string Phonenumber { get; set; }
    public Guid Guid { get; set; }
    public Guid ID { get; set; } 
}