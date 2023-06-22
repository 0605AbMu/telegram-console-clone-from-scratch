using Telegram.Clent.Domain;

namespace Telegram.Clent;

public interface IClientService<T>:IBaseClientService<T>
{

    public  void SetClients(List<T> clients);
    public  List<T> GetList();

    public bool CreatChat();
}