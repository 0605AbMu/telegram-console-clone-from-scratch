using System;
using System.Collections.Generic;

namespace TelegramChat.Domain;

public class Chat:ModelBase
{
    public List<Guid> clientIdList { get; set; }
    public List<Message> massageList { get; set; }

    public Chat()
    {
        clientIdList = new List<Guid>();
        massageList = new List<Message>();
    }
}