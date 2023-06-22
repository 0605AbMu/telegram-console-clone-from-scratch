using Telegram.Clent.Domain;

namespace Telegram.Clent;

public abstract class IClientService
{
    public abstract List<Client> Clients { get; set; }

    public virtual void SetClients(List<Client> clients)
    {
        this.Clients = clients;
    }

    public virtual List<Client> GetList()
    {
        return Clients;
    }

    public virtual bool CreatChat()
    {
        //chat service ga chatni  yaratuvchilarini berib yuboradi va va chat id sini qaytarib oladi
        return true;
    }
}