using Telegram.Client;
using TelegramChat.Service;
using TelegramChat.Service.Interface;

namespace LayoutChat.Service;

public class ServiceBase
{
    ServiceBase(ClientService _clientService, ManagerService _managerService)
    {
        
    }

    public ClientService _clientService { get; set; }
    public ManagerService _ManagerService { get; set; }




}