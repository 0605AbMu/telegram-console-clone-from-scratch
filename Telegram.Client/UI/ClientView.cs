
using TelegramChat.Service.Interface;

namespace Telegram.Clent.UI;

public class ClientView:BaseView
{
    private ClientService ClientService { get; set; }
    private Layout Layout { get; set; }
    public ClientView(ClientService service,ContextClient context,Layout layout) : base(context)
    {
        Layout = layout;
        ClientService = service;
    }

    public ClientView(ClientService clientService, ContextClient context) : base(context)
    {
        throw new NotImplementedException();
    }


    public override void Home(string? message = null)
    {
        Console.Clear();
        if (message is not null)
            Console.WriteLine(message);
        
        
    }


    public void GetChats(Client.Domain.Client client)
    {
        Layout.Write(client.Chats);
    }
    
    
}