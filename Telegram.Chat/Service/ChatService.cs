using Telegram.Clent.Services;
using TelegramChat.Domain;
using TelegramChat.Service.Interface;

namespace TelegramChat.Service;

public class ChatService : ServiceBase<Chat>, IChatService
{
}