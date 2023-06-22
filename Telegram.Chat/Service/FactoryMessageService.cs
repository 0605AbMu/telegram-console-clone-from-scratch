using System;
using System.Collections.Generic;
using TelegramChat.Domain;

namespace TelegramChat.Service;

public class FactoryMessageService
{
    private readonly MessageService _messageService;

    public FactoryMessageService()
    {
        _messageService = new MessageService();
    }

    public void AddMessage(Guid chatId, Guid clientId, string Message) => _messageService.Add(new Message()
    {
        ChatId = chatId,
        ClientId = clientId,
        Time = DateTime.Now,
        MessageClient = Message,
        Id = Guid.NewGuid()
    });

    public Message GetById(Guid messageId) => _messageService.FindModel(messageId);

    public List<Message> GetAllModel(Guid chatId) => _messageService.GetAllModel();

    public void Dalete(Guid massegeId) => _messageService.Delete(_messageService.FindModel(massegeId));

    public void AddRangeMessage(List<Message> messageList) => _messageService.AddRange(messageList);


}