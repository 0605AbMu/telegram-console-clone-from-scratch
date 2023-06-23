using TelegramChat.Service.Interface;

namespace Telegram.Client;

public interface IClientService : IServiceBase<Client>
{
    public void SetClientsList(List<Client> clients);


    public List<Client> GetClientsList();

    public bool CreatChat(List<Client> clients, string chatName);

    public bool SendMassage(string massage, Guid chatId, Guid massageId);
}