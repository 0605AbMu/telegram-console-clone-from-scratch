using System;
using System.Collections.Generic;
using TelegramChat.Domain;

namespace TelegramChat.Service;

public class ManagerService
{
    private readonly FactoryMessageService _factoryMessageService;

    public ManagerService()
    {
        _factoryMessageService = new FactoryMessageService();
    }

    public void AddMessage(Guid chatId, Guid clientId, string message) =>
        _factoryMessageService.AddMessage(chatId, clientId, message);

    public Message GetByIdMessage(Guid clientid) => _factoryMessageService.GetById(clientid);

    public List<Message> GetAllMessage(Guid chatId) => _factoryMessageService.GetAllModel(chatId);

    public void DaleteMessage(Guid MessageId) => _factoryMessageService.Dalete(MessageId);

    public void AddRangeMessage(List<Message> messageList) => _factoryMessageService.AddRangeMessage(messageList);
    
    






}