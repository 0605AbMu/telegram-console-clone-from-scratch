using System;
using System.Collections.Generic;
using TelegramChat.Domain;
using TelegramChat.Service.Interface;
namespace TelegramChat.Service;
public class ChatService:IChatService
{
    private List<Chat> _chatList;
    public ChatService()
    {
        _chatList = new List<Chat>();
    }
    public void Add(Chat data) => _chatList.Add(data);
    public void Delete(Chat data) => _chatList.Remove(data);
    public List<Chat> GetAllModel() => _chatList;
    public Chat FindModel(Guid id) => _chatList.Find(x => x.Id == id);
    public void AddRange(List<Chat> data) => _chatList.AddRange(data);
}