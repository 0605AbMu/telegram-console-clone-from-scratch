using TelegramChat.Service.ServiceClass;

namespace LayoutChat.UI;

public class ChatContext
{
    private Guid _chatId;
    private ClientService _clientService;

    public ChatContext(ClientService clientService)
    {
        _clientService = clientService;
    }

    public void Start()
    {
        this.Home();
    }

    protected virtual void Home()
    {
        Console.Clear();
        if (this._chatId != null)
            Console.WriteLine(_chatId);
        
    }
    
}