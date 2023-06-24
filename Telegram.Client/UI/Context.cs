using TelegramChat.Service;

namespace Telegram.Clent.UI;

public class ContextClient
{
    internal Client.Domain.Client SignedUser { get; set; }
    private ClientService _clientService { get; set; }
    private ClientView ClientView { get; set; }

    public ContextClient(ClientService clientService, Client.Domain.Client client,ManagerService managerService)
    {
        SignedUser = client;
        _clientService = new ClientService(client, managerService);
        ClientView = new ClientView(clientService,this);
    }
    
}