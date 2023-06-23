using System.Collections.Generic;
using Telegram.Clent.Domain;
using TelegramChat.Service.Interface;

namespace Telegram.Clent;

public interface IClientService: IServiceBase<Client>
{

    // public  void SetClientsList(List<T> clients);
    //
    // public List<T> GetClientsList();
    //
    // public bool CreatChat();
    //
    // public bool SendMassage(string massage,Guid chatId,Guid massageId );
}