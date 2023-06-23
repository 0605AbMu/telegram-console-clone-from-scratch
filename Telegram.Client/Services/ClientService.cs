using Telegram.Clent;
using Telegram.Clent.Domain;
using Telegram.Clent.Services;

namespace TelegramChat.Service.Interface;

public class ClientService : ServiceBase<Client>, IClientService
{
    TelegramChat.Service.ChatService ChatService { get; set; }
    ManagerService ManagerService { get; set; }


    private Client Client { get; set; }

    public List<Client> Clients { get; set; }

    public ClientService(Client client, ChatService chatService)
    {
        ChatService = chatService;
        Client = client;
        Clients = new List<Client>();
        ChatService = chatService;
        ManagerService = new ManagerService();
    }

    public void SetClientsList(List<Client> clients)
    {
        if (clients is not null)
            Clients = clients;

        throw new Exception("Client service dagi SetClientsList method iga kirib kelgan malumot null ga teng");
    }

    public Client FindModel(Guid id)
    {
        return Clients.Find(client => client.Id == id);
    }

    public List<Client> GetAllModel()
    {
        return Clients;
    }

    public void AddRange(List<Client> data)
    {
        if (data is not null)
            Clients.AddRange(data);

        else
            throw new Exception("AddRange metodida xato.Qiymat null ga teng");
    }

    public void Delete(Client data)
    {
        if (data is not null)
            Clients.Remove(data);

        else
            throw new Exception("Delete metodida xatolik. Client topilmmadi ");
    }



    public Client UpdateClient(Guid clientId, string? name = null, DateTime? birthDate = null,
        string? phoneNumber = null, string password = null)
    {

        var client = this.FindModel(clientId);

        if (name is not null)
            client.FullName = name;

        if (birthDate.HasValue)
            client.BrithDate = birthDate.Value;

        if (name is not null)
            client.FullName = name;

        if (password is not null)
            client.Password = password;

        if (phoneNumber is not null)
            client.PhoneNumber = phoneNumber;

        return client;
    }

    public Client AddClient(Client data)
    {
        if (data is null)
            throw new Exception("AddClient metodiga null malumot kirib kelgan!!!");

        Clients.Add(data);
        return data;
    }

    public List<Client> GetClientsList()
    {
        return Clients;
    }



    public bool CreatChat(List<Client> clients)
    {
        if (clients is null)
            throw new Exception("CreateChat methodiga null kirib keldi");


        List<Guid> clientIds = new List<Guid>();

        foreach (Client client in clients)
        {
            clientIds.Add(client.Id);
        }

        clientIds.Add(Client.Id);

        ManagerService.AddChat(clientIds);

        return true;
    }

    public bool SendMassage(string massage, Guid chatId, Guid massageId)
    {
        var chat = ManagerService.GetByIdChat(chatId);
        if (chat == null)
            throw new Exception("Chat yaratilmagan!!");


        var message = ManagerService.GetByIdMessage(massageId);

        if (message == null)
            throw new Exception("Message yaratilmagan!!!");

        ManagerService.AddMessage(chatId, Client.Id, massage);

        return true;
    }
}