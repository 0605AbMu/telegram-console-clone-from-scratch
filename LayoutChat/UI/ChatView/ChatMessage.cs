namespace LayoutChat.UI.ChatView
{
    public class ChatMessage
    {

        private ClientService _clientService;
        public Guid _chatId { get; set; }
        public ChatMessage(ClientService clientService)
        {
            this._clientService = clientService;
        }
        public void Start()
        {
            this.Home();
        }
        protected virtual void Home()
        {
            Console.Clear();
            if (this._chatId != null)
                Console.WriteLine(_chatId);
        }
    }
}
