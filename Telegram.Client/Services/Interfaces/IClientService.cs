using TelegramChat.Service.Interface;

namespace Telegram.Client;

public interface IClientService : IServiceBase<Domain.Client>
{
    public void SetClientsList(List<Domain.Client> clients);


    public List<Domain.Client> GetClientsList();

    public bool CreatChat(List<Domain.Client> clients, string chatName);

    public bool SendMassage(string massage, Guid chatId, Guid massageId);
}