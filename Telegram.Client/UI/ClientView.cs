
using TelegramClient.Auth.UI;

namespace Telegram.Clent.UI;

public class ClientView:BaseView
{
   private ClientService ClientService { get; set; }
    private Layout Layout { get; set; }
    public ContextClient context { get; set; }
    public ClientView(ClientService service,ContextClient context,Layout layout) : base(context)
    {
        Layout = layout;
        this.context = context;
        ClientService = service;
    }
    


    public override void Home(string? message = null)
    {
        Console.Clear();
        if (message is not null)
            Console.WriteLine(message);
        
        Layout.Initial();
        Thread.Sleep(4000);
        int i = 0;
        
        foreach (var chatId in ClientService.Client.ChatsId)
        {
            var massage = context._clientService.ManagerService.GetLastMessage(context._clientService.Client.ChatsId.Last());
            ViewModel model = new ViewModel()
            {
                ClientName =   ClientService.Client.FullName,
                LastMessage = massage.MessageClient,
                MessageDate = massage.Time
            };  
            Layout.Initial();
            Thread.Sleep(3000);
            Layout.Write(model);
            Thread.Sleep(3000);
        }
       
      
        

    }


    public void GetChats(ViewModel viewModel)
    {
        Layout.Write(viewModel);
    }
     
    
}