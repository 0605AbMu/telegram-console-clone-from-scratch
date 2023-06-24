using Telegram.Clent.UI;
using TelegramChat.Service;
using TelegramChat.UI;
using TelegramClient.Auth.UI;

namespace Telegram.Application;

public class Display
{
    private ContextClient _contextClient;
    private Context _contextAuth;
    private ContextChat _contextChat;
    private ClientService _clientService;
    private ManagerService _managerService;

    public Display()
    {
        _managerService = new ManagerService();
        _clientService = new ClientService(null , _managerService);
        _contextChat = new ContextChat();
        _contextAuth = new Context();
        _contextClient = new ContextClient(_clientService,null,_managerService);
    }

    public void Start()
    {
        Thread threadAuth = new Thread(() =>
        {
            while (true)
            {
                // _contextAuth.Start();
            }
        });
        threadAuth.Start();
        Thread threadClient = new Thread(() =>
        {
            while (true)
            {
               // _contextClient.Start();
            }
        });
        threadClient.Start();
       
        Thread threadChat = new Thread(() =>
        {
            while (true)
            {
                // _contextChat.Start();
            }
        });
        threadChat.Start();
        
    }
}