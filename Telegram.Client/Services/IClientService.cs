using Telegram.Clent.Domain;

namespace Telegram.Clent;

public interface IClientService<T>:IBaseClientService<T>
{

    public  void SetClientsList(List<T> clients);

    public List<T> GetClientsList();

    public bool CreatChat();

    public bool SendMassage(string massage,Guid chatId,Guid massageId );
}