using TelegramChat.Service;

namespace Telegram.Clent.UI;

public class ContextClient
{
    public Client.Domain.Client? SignedClient { get; set; }
    public ClientService _clientService { get; set; }
    private ClientView ClientView { get; set; }
    public readonly Layout _layout;
    public readonly ManagerService _managerService;
    public ContextClient(
        // ClientService clientService, Nega client Service o'ziniki bo'lib turib tashqaridan so'raldi
        // ManagerService managerService, Nega Manager service Client ning bolasi bo'lib turib tashqaridan so'raldi
        Layout layout)
    {
        this._layout = layout;
        this._managerService = new ManagerService();
        this._clientService = new ClientService(this._managerService);
        ClientView = new ClientView(this._clientService, this, this._layout);
    }
    
    public void Start()
    {
        if (this.SignedClient is not null)
            ClientView.Home();
    }
}