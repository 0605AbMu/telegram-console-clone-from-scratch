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
    public void AddChat(string name,List<Guid>clienIdList) 
        => _chatService.Add(new Chat()
        {   Name = name,
            Id=new Guid(),
            clientIdList = clienIdList,
        });
    
    
    
    public void DeleteChat(Guid clientId) 
        => _chatService.Delete(_chatService.FindModel(clientId));
    
    
    
    public List<Chat> GetAllChatList() 
        => _chatService.GetAllModel();
    
    
    
    public Chat GetByIdChat(Guid chatId) 
        => _chatService.FindModel(chatId);
    

    
    
    public void AddRangeChat(List<Chat> chatlist) 
        => _chatService.AddRange(chatlist);
    
 // public void AddRangeChat(List<Chat> chatlist) 
 //   => _chatService.AddRange(chatlist);
// >>>>>>> 3fc20301f9fa2e0c8a003a839a7c6cbe546a225c:Telegram.Chat/Service/FactoryChatService.cs
//     
}