using System.Drawing;
using Telegram.Clent.UI;
using TelegramChat.Service;
using TelegramChat.UI;
using TelegramClient.Auth.UI;

namespace Telegram.Application;

public class Display
{
    private Thread threadControlClientSignIn;
    private Thread threadChat;
    private Thread threadClient;
    private Thread threadAuth;
    private ContextClient _contextClient;
    private Context _contextAuth;
    private ContextChat _contextChat;
    private ClientService _clientService;
    private ManagerService _managerService;
    private Layout _layout;

    public Display()
    {
        _layout = new Layout(new Point(60, 30), new Point(120, 60));
        _managerService = new ManagerService();
        _clientService = new ClientService(_managerService);
        _contextChat = new ContextChat();
        _contextAuth = new Context();
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

                if (threadAuth.ThreadState != ThreadState.Running)
                {
                    threadAuth.Start();
                }
                //todo  _contextAuth.ActiveView 
                
            }
            else
            {
                _clientService.Client = _clientService.GetClientsList()
                    .Find(x => x.Id == _contextAuth.User.Id);
                if (threadAuth.ThreadState == ThreadState.Running)
                {
                    threadAuth.Interrupt();
                }
            }
        }
        else
        {
            if (threadClient.ThreadState != ThreadState.Running)
            {
                threadClient.Start();
            }

            if (threadChat.ThreadState != ThreadState.Running)
            {
                threadChat.Start();
            }

            if (threadAuth.ThreadState == ThreadState.Running)
            {
                threadAuth.Interrupt();
            }

        }
    }

    public void Start()
    {
        _contextChat.Start();
    }
    public void Start2()
    {
        threadControlClientSignIn = new Thread(() =>
            {
                while (true)
                {
                    CurrentUserSingIn();
                }
            }
        );
        threadAuth = new Thread(() =>
        {
            while (true)
            {
                _contextAuth.Start();
            }
        });


        threadClient = new Thread(() =>
        {
            while (true)
            {
                _contextClient.Start();
            }
        });


        threadChat = new Thread(() =>
        {
            while (true)
            {
                _contextChat.Start();
            }
        });

        threadControlClientSignIn.Start();
        
        threadClient.Start();
        threadChat.Start();
        threadAuth.Start();
        threadControlClientSignIn.Join();

    }
}

    