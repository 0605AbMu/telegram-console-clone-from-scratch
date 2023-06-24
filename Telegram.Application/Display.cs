using System.Drawing;
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
    private Layout _layout;

    public Display()
    {
        _layout = new Layout(new Point(60,30),new Point(120,60));
        _managerService = new ManagerService();
        _clientService = new ClientService( _managerService);
        _contextChat = new ContextChat();
        _contextAuth = new Context();
        _contextClient = new ContextClient(_clientService,_managerService,_layout);
    }

    public void CurrentUserSingIn()
    {
        if (_clientService.Client is not null)
        {
            
        }
        else
        {
            
        }
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
                _contextClient.Start();
            }
        });
        threadClient.Start();
       
        Thread threadChat = new Thread(() =>
        {
            while (true)
            {
                 _contextChat.Start();
            }
        });
        threadChat.Start();
        
    }

    public void UpdateClirn()
    {
        Thread thread = new Thread(() =>
        {
            while (true)
            {
                CurrentUserSingIn();
            }
        }
        );
        
    }
    
}