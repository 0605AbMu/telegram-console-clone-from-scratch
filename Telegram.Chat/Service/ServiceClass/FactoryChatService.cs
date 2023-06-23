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
    
<<<<<<< HEAD
<<<<<<< HEAD

    
    
    public void AddRangeChat(List<Chat> chatlist) 
        => _chatService.AddRange(chatlist);
    
 // public void AddRangeChat(List<Chat> chatlist) 
 //   => _chatService.AddRange(chatlist);
// >>>>>>> 3fc20301f9fa2e0c8a003a839a7c6cbe546a225c:Telegram.Chat/Service/FactoryChatService.cs
//     
=======
    
    
   



>>>>>>> 0096d3581603363f8a94c06b489edc27d924df9b
=======
<<<<<<< HEAD:Telegram.Chat/Service/ServiceClass/FactoryChatService.cs
    
    
    public void AddRangeChat(List<Chat> chatlist) 
        => _chatService.AddRange(chatlist);
=======
 //   public void AddRangeChat(List<Chat> chatlist) 
 //     => _chatService.AddRange(chatlist);
>>>>>>> 3fc20301f9fa2e0c8a003a839a7c6cbe546a225c:Telegram.Chat/Service/FactoryChatService.cs
    
>>>>>>> dc00ec782064e07066b8c76ecf67b08c24bfc200
}