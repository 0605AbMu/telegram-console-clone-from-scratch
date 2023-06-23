using Telegram.Clent.Domain;
using TelegramChat.Domain;

namespace Telegram.Clent.Services
{
    public class ChatManager
    {
        private List<Chat> chats;

        public ChatManager()
        {
            chats = new List<Chat>();
        }

        public Guid CreateChat(Client client)
        {

        }

        public void AddMessage(Guid chatId, Message message)
        {
            var chat = chats.FirstOrDefault(c => c.Id == chatId);

            if (chat != null)
            {
                message.Id = Guid.NewGuid();
                chat.massageList.Add(message);
            }
            else
            {
                throw new ArgumentException("Invalid chatId");
            }
        }
    }

}
