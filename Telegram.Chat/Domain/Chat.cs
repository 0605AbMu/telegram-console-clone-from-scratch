namespace TelegramChat.Domain;

public class Chat : ModelBase
{
    public Chat()
    {
        clientIdList = new List<Guid>();
        massageList = new List<Message>();
    }

    public string Name { get; set; }
    
    public Guid clientId { get; set; }
    public List<Guid> clientIdList { get; set; }
    public List<Message> massageList { get; set; }
    public bool isPrivate { get; set; }
    
}