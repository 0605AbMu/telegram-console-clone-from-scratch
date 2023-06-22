using System;
using System.Collections.Generic;
using TelegramChat.Domain;

namespace TelegramChat.Service;

public class FactoryChatService
{
    private ChatService _chatService;

    public FactoryChatService()
    {
        _chatService = new ChatService();
    }

    public void AddChat(List<Guid>clienIdList) => _chatService.Add(new Chat() { Id=new Guid(), clientIdList = clienIdList, });
    public void DeleteChat(Guid clientId) => _chatService.Delete(_chatService.FindModel(clientId));
    public List<Chat> GetAllModelChats() => _chatService.GetAllModel();
    public void FindModelChat(Guid chatId) => _chatService.FindModel(chatId);
    public void AddRangeChat(List<Chat> chatlist) => _chatService.AddRange(chatlist);
    
}