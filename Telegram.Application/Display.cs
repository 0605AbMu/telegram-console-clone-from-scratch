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

    public volatile bool IsRunningChatThread = false;
    public volatile bool IsRunningClientThread = false;
    public volatile bool IsRunningAuthThread = false;

    public Display()
    {
        int winHeight = Console.LargestWindowHeight - 2;
        int winWidth = Console.LargestWindowWidth - 2;
        // Console.SetWindowSize(winWidth, winHeight);
        _layout = new Layout(new Point(2, 2), new Point(winWidth / 3, winHeight - 2));
        _contextAuth = new Context(new Point(2, 2), new Point(winWidth, winHeight - 2));
        _contextClient = new ContextClient(_layout);
        _contextChat = new ChatContext(new Point(winWidth / 3, 2), new Point(winWidth, winHeight - 2),
            _contextClient._clientService);
    }

    public bool IsUserSigned { get; set; }
    public void CurrentUserSingIn()
    {
        if (_contextAuth.User is not null && !IsUserSigned)
        {
            //User already signed
            //Forwarding to Client views;
            this.IsRunningAuthThread = false;
            _contextClient.SignedClient = _contextClient._clientService.FindModel(_contextAuth.User.ClientId);
            
            Console.Clear();
            this.IsRunningClientThread = true;
            this.IsUserSigned = true;
        }
        // if (_clientService.Client is not null)
        // {
        //     if (_contextAuth.User is not null)
        //     {
        //         //threadChat.Interrupt();
        //         // threadClient.Interrupt();
        //
        //         if (threadAuth.ThreadState != ThreadState.Running) threadAuth.Start();
        //         //todo  _contextAuth.ActiveView 
        //     }
        //     else
        //     {
        //         _clientService.Client = _clientService.GetClientsList()
        //             .Find(x => x.Id == _contextAuth.User.Id);
        //         // if (threadAuth.ThreadState == ThreadState.Running)
        //         // {
        //         //     threadAuth.Interrupt();
        //         //     threadClient.Start();
        //         //     threadChat.Start();
        //         // }
        //     }
        // }
        // // if (threadClient.ThreadState != ThreadState.Running)
        // // {
        // //     threadClient.Start();
        // // }
        // //
        // // if (threadChat.ThreadState == ThreadState.Stopped)
        // // {
        // //     threadChat.Start();
        // // }
        // //
        // // if (threadAuth.ThreadState == ThreadState.Running)
        // // {
        // //     threadAuth.Interrupt();
        // // }
        //Bunchalik murakkablashishi nega kerak edi. Menimcha charchaganlikdan hammasi
    }


    public void Start()
    {
        Console.Clear();
       
        //For test
        // this._contextAuth.Start();
        // this.CurrentUserSingIn();
        // this._contextClient.Start();
        // this._contextChat.Start();


        threadControlClientSignIn = new Thread(() =>
        {
            while (true)
            {
                CurrentUserSingIn();
            }
        });
        
        threadAuth = new Thread(() =>
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (this.IsRunningAuthThread)
                    _contextAuth.Start();
            }
        });
        
        threadClient = new Thread(() =>
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (this.IsRunningClientThread)
                {
                    _contextClient.Start();
                    _contextChat.Start();
                }
            }
        });

        threadControlClientSignIn.Start();
        threadClient.Start();
        threadAuth.Start();
        
        this.IsRunningAuthThread = true;
        
        threadControlClientSignIn.Join();
    }
}