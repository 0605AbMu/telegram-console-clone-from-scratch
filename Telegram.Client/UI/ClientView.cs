
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

  


    public override void Home(string? message = null)
    {
        Console.Clear();
        if (message is not null)
            Console.WriteLine(message);
        
        
    }


    public void GetChats(ViewModel viewModel)
    {
        Layout.Write(viewModel);
    }
     
    
}