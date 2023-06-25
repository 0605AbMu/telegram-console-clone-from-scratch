using Telegram.Client;
using Telegram.Client.Domain;
using Telegram.Client.Domain.Enums;
using Telegram.Client.Services;
using TelegramChat.Service;

public class ClientService : ServiceBase<Client>, IClientService
{
    public ClientService(ManagerService managerService)
    {
        ManagerService = managerService;

        _models = new List<Client>();
    }

    public ManagerService ManagerService { get; set; }

    public Client Client { get; set; } = new()
    {
        Id = Guid.Parse("6F8320E5-1D1B-4404-9FAA-4E70D4E0C96E"),
        Password = "123",
        BirthDate = DateTime.Now,
        ClientStatus = ClientStatus.Active,
        FullName = "",
        PhoneNumber = "+998939063651"
    };

    public void SetClientsList(List<Client> clients)
    {
        if (clients is not null)
            _models = clients;

        else
            throw new Exception("Client service dagi SetClientsList method iga kirib kelgan malumot null ga teng");
    }


    public void Delete(Client data)
    {
        if (data is not null)
            _models.Remove(data);

        else
            throw new Exception("Delete metodida xatolik. Client topilmmadi ");
    }

    public List<Client> GetClientsList()
    {
        return _models;
    }

    public bool CreatChat(List<Client> clients, string chatName)
    {
        if (clients is null)
            throw new Exception("CreateChat methodiga null kirib keldi");


        var clientIds = new List<Guid>();

        foreach (var client in clients) clientIds.Add(client.Id);

        ManagerService.CreateChat(Client.Id, chatName, clients.Count == 1);

        return true;
    }


    public bool SendMassage(string _massage, Guid chatId)
    {
        var chat = ManagerService.FindChat(chatId);

        if (chat == null)
            throw new Exception("Chat yaratilmagan!!");


        var message = ManagerService.FindChat(chatId);

        if (message == null)
            throw new Exception("Message yaratilmagan!!!");

        ManagerService.AddAMessageToChat(chatId, Client.Id, _massage);

        return true;
    }


    public void UpdateClient(Guid clientId, string? name = null, DateTime? birthDate = null,
        string? phoneNumber = null, string? password = null)
    {
        var client = FindModel(clientId);

        if (client is null)
            throw new Exception("UpdateClient metodida xatolik.Client topilmadi!!!");

        if (name is not null)
            client.FullName = name;

        if (birthDate.HasValue)
            client.BirthDate = birthDate.Value;

        if (name is not null)
            client.FullName = name;

        if (password is not null)
            client.Password = password;

        if (phoneNumber is not null)
            client.PhoneNumber = phoneNumber;


        foreach (var client1 in _models)
            if (client1.Id == clientId)
            {
                client1.FullName = client.FullName;
                client1.BirthDate = client.BirthDate;
                client1.PhoneNumber = phoneNumber;
                client1.Password = client.Password;
                client1.ChatsId = client.ChatsId;
                client1.ClientStatus = client.ClientStatus;
            }
    }

    public Client AddClient(Client data)
    {
        if (data is null)
            throw new Exception("AddClient metodiga null malumot kirib kelgan!!!");

        _models.Add(data);
        return data;
    }
}