using TelegramChat.Service;

namespace LayoutChat.Service;

public class ServiceBase
{
    private ServiceBase(ClientService _clientService, ManagerService _managerService)
    {
    }

    public ClientService _clientService { get; set; }
    public ManagerService _ManagerService { get; set; }
}