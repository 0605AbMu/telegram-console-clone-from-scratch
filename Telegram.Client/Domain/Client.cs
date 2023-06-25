using Telegram.Client.Domain.Enums;
using TelegramChat.Domain;

namespace Telegram.Client.Domain;

public class Client : ModelBase
{
    public string FullName { get; set; }
    public DateTime BirthDate { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    //Nega chatsId default Initialization qilinmagan. Default holatda chatlari bo'lmaydiku
    public List<Guid> ChatsId { get; set; }
    public ClientStatus ClientStatus { get; set; }

    public Client()
    {
        this.ChatsId = new List<Guid>();
    }
}