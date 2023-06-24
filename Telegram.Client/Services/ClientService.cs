
using Telegram.Client;
using Telegram.Client.Domain;
using Telegram.Client.Services;

namespace TelegramChat.Service.Interface;

public class ClientService : ServiceBase<Client>, IClientService
{

    private ManagerService ManagerService { get; set; }

    private Client Client { get; set; }

    public ClientService(Client client, ManagerService managerService)
    {
        ManagerService = managerService;

        Client = client;
        _models = new List<Client>();

    }

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



    public void UpdateClient(Guid clientId, string? name = null, DateTime? birthDate = null,
        string? phoneNumber = null, string? password = null)
    {
        var client = this.FindModel(clientId);

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


        foreach (Client client1 in _models)
        {
            if (client1.Id == clientId)
            {
                client1.FullName = client.FullName;
                client1.BirthDate = client.BirthDate;
                client1.PhoneNumber = phoneNumber;
                client1.Password = client.Password;
                client1.Chats = client.Chats;
                client1.ClientStatus = client.ClientStatus;
            }
        }
    }

    public Client AddClient(Client data)
    {
        if (data is null)
            throw new Exception("AddClient metodiga null malumot kirib kelgan!!!");

        _models.Add(data);
        return data;
    }

    public List<Client> GetClientsList()
    {
        return _models;
    }

    public bool CreatChat(List<Client> clients, string chatName)
    {
        if (clients is null)
            throw new Exception("CreateChat methodiga null kirib keldi");


        List<Guid> clientIds = new List<Guid>();

        foreach (Client client in clients)
        {
            clientIds.Add(client.Id);
        }

        ManagerService.CreateChat(Client.Id, chatName, clients.Count == 1);

        return true;
    }

    public bool SendMassage(string _massage, Guid chatId, Guid massageId)
    {

        var chat = ManagerService.FindChat(chatId);

        if (chat == null)
            throw new Exception("Chat yaratilmagan!!");


        var message = ManagerService.FindChat(massageId);

        if (message == null)
            throw new Exception("Message yaratilmagan!!!");

        ManagerService.AddAMessageToChat(chatId, Client.Id, _massage);

        return true;
    }




}