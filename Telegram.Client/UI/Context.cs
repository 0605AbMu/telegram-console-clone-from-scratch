using TelegramChat.Service;

namespace Telegram.Clent.UI;

public class ContextClient
{
   
    private ClientService _clientService { get; set; }
    private ClientView ClientView { get; set; }
    public Layout Layout { get; set; }
    public ContextClient(ClientService clientService,ManagerService managerService,Layout layout)
    {
        Layout = layout;
        _clientService = new ClientService( managerService);
        ClientView = new ClientView(clientService,this,layout);
    }

    public void Start()
    {
        ClientView.Home();
    }
    
}