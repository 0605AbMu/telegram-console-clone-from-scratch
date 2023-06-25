namespace Telegram.Clent.UI;

public class ClientView : BaseView
{
    public ClientView(ClientService service, ContextClient context, Layout layout) : base(context)
    {
        Layout = layout;
        this.context = context;
        ClientService = service;
    }

    private ClientService ClientService { get; }
    private Layout Layout { get; }
    public ContextClient context { get; set; }


    public override void Home(string? message = null)
    {
        // Console.Clear(); Nega bu yerda Console ni butunla tozalab tashlandi. Bu boshqa layout larga ham zarar berib qo'yadiku.
        // if (message is not null)
        //     Console.WriteLine(message); Bu client View uchun nega kerak. Bu yerda faqatgina Client bilan bog'liq jarayonlar amalga oshiriladi
        Layout.Clear();
        Layout.Initial();
        var i = 0;
        foreach (var chatId in ClientService.Client.ChatsId)
        {
            // var massage =
            //     context._clientService.ManagerService.GetLastMessage(context._clientService.Client.ChatsId.Last());
            //Bu kod nima ni o'ylab yozilgan bilmadim. Menimcha kecha charchaganida yozib qo'ygan
            var chatMessage = this.context._managerService.GetLastMessage(chatId);
            var model = new ViewModel
            {
                ClientName = this.context._managerService.FindChat(chatId).Name,
                LastMessage = chatMessage.MessageClient,
                MessageDate = chatMessage.Time
            };
            Layout.Write(model);
        }
    }


    public void GetChats(ViewModel viewModel)
    {
        Layout.Write(viewModel);
    }
}