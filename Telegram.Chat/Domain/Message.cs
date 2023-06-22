namespace TelegramChat.Domain;

public class Message:ModelBase
{
    public string MessageClient { get; set; }
    
    public DateTime Time { get; set; }
    public Guid ClientId { get; set; }
}