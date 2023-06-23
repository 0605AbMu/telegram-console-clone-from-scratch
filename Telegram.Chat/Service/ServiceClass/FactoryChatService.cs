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
    public void AddChat(string chatName,bool isPrivate,Guid chatClientId ,List<Guid>clienIdList) 
        => _chatService.Add(new Chat()
        {   Name = chatName,
            clientId = chatClientId,
            isPrivate = isPrivate,
            Id=new Guid(),
            clientIdList = clienIdList,
        });
    
    
    
    public void DeleteChat(Guid clientId) 
        => _chatService.Delete(_chatService.FindModel(clientId));


    public void SetChat(List<Chat> chatList)
        => _chatService.SetModel(chatList);
    
    public List<Chat> GetAllChatList() 
        => _chatService.GetAllModel();

    public Chat GetByIdChat(Guid chatId) 
        => _chatService.FindModel(chatId);






    public void CreateChat(Guid ownerId, string name, bool isPrivate = true)
        => _chatService.CreateChat(ownerId, name, isPrivate = true);
    
    public void JoinChat(Guid chatId, Guid clientId)
        => _chatService.JoinChat(chatId, clientId);
    
    public void AddAMessageToChat(Guid chatId, Guid fromId, string message)
        => _chatService.AddAMessageToChat(chatId, fromId, message);




}