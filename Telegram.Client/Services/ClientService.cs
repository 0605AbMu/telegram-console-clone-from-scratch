


using System.Linq.Expressions;
using System.Text.RegularExpressions;
using Telegram.Clent;
using Telegram.Clent.Domain;
// using TelegramClient.Auth.Domain;
// using TelegramClientChatsChoynakningQapqogi;
// using TelegramClientChatsChoynakningQapqogi.TelegramCilentChatsChoynakningQapqogi_Servic;

public class ClientService : IClientService
{
  //  private readonly ChatServic _chatServic;
    public override List<Client> Clients { get; set; }

    //
    // public ClientService(ChatServic chatServic)
    // {
    //     _chatServic = chatServic;
    //     Clients=new List<Client>();
    // }

    public Client AddClient(string fullname, DateTime brithDate, string phoneNumber)
    {
        //yangi client yaratish
        var regex = Regex.IsMatch(phoneNumber,  @"^\+998(90|91|93|94|95|97|98)\d{7}$");

        var res = Clients.Find(client => client.FullName == fullname && client.PhoneNumber == phoneNumber);
        
        if (res!=null )
            return null;
        
        if (fullname != null && brithDate < DateTime.Now && phoneNumber!=null &&
            brithDate>new DateTime(1900,1,1,0,0,0,0)&& regex )
        {
            var client = new Client()
            {
                GuidId = Guid.Empty,
                FullName = fullname,
                BrithDate = brithDate,
                PhoneNumber = phoneNumber,
                Password = "",
                Chats = new List<Guid>()
            };
            Clients.Add(client);
            return client;
        }

        throw new Exception("Client malumotlari noto'g'ri!!!");
    }

    public override List<Client> GetList()
    {
        return Clients;
    }

    public override void SetClients(List<Client> clients)
    {
      if(clients!=null){
        this.Clients = clients;
       }
    }

    public Client GetById(Guid guid)
    {
        //berilgan id li clientni qaytarish

        var client = Clients.Find(client => client.GuidId == guid);
        
        if (client!=null)
        {
            return client;
        }

        throw new Exception("Clietn topilmadi");
    }

    
    public bool UpdateClientData(Guid id, int item,string change )
    {
        //client malumotlarini yangilash
        var client = GetById(id);

        if (client != null&&change != null)
        {
            switch (item)
            {
                case 1:
                {
                   //full name update
                   if (change.ToString().Length > 1)
                   {
                       Clients.Find(client => client.GuidId == id).FullName = change;
                   }

                   else
                       throw new Exception("Name formati xato");
                   
                       break;
                }

                case 2:
                {
                    // brithDate update
                    var dateTime = new DateTime();

                    bool b = DateTime.TryParse(change, out dateTime);

                    if (b)
                    {
                        Clients.Find(client => client.GuidId == id).BrithDate = dateTime;
                    }

                    else
                        throw new Exception("DateTime formati xato kiritilgan!!!");
                    
                    break;
                }
                case 3:
                {
                    //passwordni update qilish 
                    if (change.ToString().Length >= 6 && change.ToString().Length < 16)
                    {
                        Clients.Find(client => client.GuidId == id).Password = change;
                    }

                    else
                        throw new Exception("Password noto'g'ri formatda!!!");
                 
                    break;
                }
                case 4:
                {
                    //phone number ni update qilish
                    
                    var res = Regex.IsMatch(change.ToString(),  @"^\+998(90|91|93|94|95|97|98)\d{7}$");

                    if (res)
                    {
                        Clients.Find(client => client.GuidId == id).PhoneNumber = change;
                    }

                    else
                        throw new Exception("Phone number formati xato ");

                    break;
                }
                
            }
            
        }
        
        throw new Exception("Berilgan malumotlarda xatoli bor yoki user topilmadi!!!");
    }


    public bool DeleteClient(Guid guid)
    {
        //clientni o'chirish

        var client = GetById(guid);
        
        if (client!=null)
            return Clients.Remove(client);

        throw new Exception("User topilmadi!!!");
    }

    public override bool CreatChat()
    {
       // this._chatServic.
        
        //chat service ga chatni  yaratuvchilarini berib yuboradi va va chat id sini qaytarib oladi
        return true;
    }

}