namespace LayoutChat.UI.ChatView;

public class ChatMessage
{
    private ClientService _clientService;

    public ChatMessage(ClientService clientService)
    {
        _clientService = clientService;
    }

    public Guid _chatId { get; set; }

    public void Start()
    {
        Home();
    }

    protected virtual void Home()
    {
        Console.Clear();
        if (_chatId != null)
            Console.WriteLine(_chatId);
    }
}