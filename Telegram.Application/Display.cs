using System.Drawing;
using LayoutChat.UI;
using Telegram.Clent.UI;
using TelegramChat.Service;
using TelegramClient.Auth.UI;

namespace Telegram.Application;

public class Display
{
    private readonly ClientService _clientService;
    private readonly Context _contextAuth;
    private readonly ChatContext _contextChat;
    private readonly ContextClient _contextClient;
    private readonly Layout _layout;
    private readonly ManagerService _managerService;
    private Thread threadAuth;
    private Thread threadChat;
    private Thread threadClient;
    private Thread threadControlClientSignIn;

    public Display()
    {
        _layout = new Layout(new Point(0, 0), new Point(40, Console.WindowHeight));
        _managerService = new ManagerService();
        _clientService = new ClientService(_managerService);
        _contextChat = new ChatContext(new Point(41, 0), new Point(Console.WindowWidth, Console.WindowHeight),
            _clientService);
        _contextAuth = new Context(new Point(40, 0), new Point(80, Console.WindowHeight));
        _contextClient = new ContextClient(_clientService, _managerService, _layout);
    }

    public void CurrentUserSingIn()
    {
        if (_clientService.Client is not null)
        {
            if (_contextAuth.User is not null)
            {
                //threadChat.Interrupt();
                // threadClient.Interrupt();

                if (threadAuth.ThreadState != ThreadState.Running) threadAuth.Start();
                //todo  _contextAuth.ActiveView 
            }
            else
            {
                _clientService.Client = _clientService.GetClientsList()
                    .Find(x => x.Id == _contextAuth.User.Id);
                // if (threadAuth.ThreadState == ThreadState.Running)
                // {
                //     threadAuth.Interrupt();
                //     threadClient.Start();
                //     threadChat.Start();
                // }
            }
        }
        // if (threadClient.ThreadState != ThreadState.Running)
        // {
        //     threadClient.Start();
        // }
        //
        // if (threadChat.ThreadState == ThreadState.Stopped)
        // {
        //     threadChat.Start();
        // }
        //
        // if (threadAuth.ThreadState == ThreadState.Running)
        // {
        //     threadAuth.Interrupt();
        // }
    }


    public void Start()
    {
        threadControlClientSignIn = new Thread(() =>
            {
                while (true) CurrentUserSingIn();
            }
        );
        threadAuth = new Thread(() =>
        {
            while (_contextAuth.User is null && _contextClient._clientService.Client is null) _contextAuth.Start();
        });


        threadClient = new Thread(() =>
        {
            while (_contextClient._clientService.Client is not null)
            {
                _contextClient.Start();
                Thread.Sleep(1000);
            }
        });


        threadChat = new Thread(() =>
        {
            while (_contextClient._clientService.ManagerService is not null)
                try
                {
                    _contextChat.Start();
                }
                catch (Exception e)
                {
                    // Console.WriteLine(e);
                    // throw;
                }
        });

        // if (_contextAuth.User != null)
        // {
        //     threadClient.Start();
        //     threadChat.Start();
        // }

        threadClient.Start();
        threadChat.Start();
        threadAuth.Start();
    }
}