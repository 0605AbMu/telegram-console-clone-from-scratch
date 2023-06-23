namespace TelegramChat.Domain;

public class Chat : ModelBase
{
    public Chat()
    {
        clientIdList = new List<Guid>();
        massageList = new List<Message>();
    }

    public string Name { get; set; }
    public List<Guid> clientIdList { get; set; }
    public List<Message> massageList { get; set; }
}