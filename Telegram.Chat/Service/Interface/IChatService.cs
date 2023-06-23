using TelegramChat.Domain;

namespace TelegramChat.Service.Interface;

public interface IChatService : IServiceBase<Chat>
{
    /// <summary>
    /// Create a chat
    /// </summary>
    /// <param name="ownerId">Chat owner Id</param>
    /// <param name="name">Chat name</param>
    /// <param name="isPrivate">is private chat?</param>
    public void CreateChat(Guid ownerId, string name, bool isPrivate = true);
    /// <summary>
    /// Join to any chat
    /// </summary>
    /// <param name="chatId">chat id</param>
    /// <param name="clientId">joining client id</param>
    public void JoinChat(Guid chatId, Guid clientId);
    /// <summary>
    /// Add(write) any message
    /// </summary>
    /// <param name="chatId">Chat id</param>
    /// <param name="fromId">Sender client id</param>
    /// <param name="message">any message</param>
    public void AddAMessageToChat(Guid chatId, Guid fromId, string message);
}