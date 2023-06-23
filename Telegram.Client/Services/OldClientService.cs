


using System.Linq.Expressions;
using System.Text.RegularExpressions;
using Telegram.Clent;
using Telegram.Clent.Domain;
 //using 
public class ClientService : IClientService<Client>
{
    /*
    private readonly 
   
    
    public ClientService(ChatServic chatServic)
     {
         _chatServic = chatServic;
         Clients=new List<Client>();
    }
    */

    
    
    public List<Client> models { get; set; }

    
    
    public Client AddClient(Client client)
    {
        //yangi client yaratish
        var regex = Regex.IsMatch(client.PhoneNumber,  @"^\+998(90|91|93|94|95|97|98)\d{7}$");

        var res = models.Find(client => client.FullName == client.FullName && client.PhoneNumber == client.PhoneNumber);
        
        if (res!=null )
            return null;
        
        if (client.FullName != null && client.BrithDate < DateTime.Now && client.PhoneNumber!=null &&
            client.BrithDate>new DateTime(1900,1,1,0,0,0,0)&& regex )
        {
            
            models.Add(client);
            return client;
        }

        throw new Exception("Client malumotlari noto'g'ri!!!");
    }

    public  List<Client> GetList()
    {
        return models;
    }

    public  void SetClients(List<Client> clients)
    {
      if(clients!=null){
          
        this.models = clients;
       }
    }

    public Client GetById(Guid guid)
    {
        //berilgan id li clientni qaytarish

        var client = models.Find(client => client.GuidId == guid);
        
        if (client!=null)
        {
            return client;
        }

        throw new Exception("Clietn topilmadi");
    }


    

  

    public Client UpdateClientData(Guid id, int item,string change )
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
                       models.Find(client => client.GuidId == id).FullName = change;
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
                        models.Find(client => client.GuidId == id).BrithDate = dateTime;
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
                        models.Find(client => client.GuidId == id).Password = change;
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
                        models.Find(client => client.GuidId == id).PhoneNumber = change;
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
            return models.Remove(client);

        throw new Exception("User topilmadi!!!");
    }

    public void SetlientsList(List<Client> clients)
    {
        throw new NotImplementedException();
    }

    public void SetClientsList(List<Client> clients)
    {
        throw new NotImplementedException();
    }

    public List<Client> GetClientsList()
    {
        throw new NotImplementedException();
    }

    public  bool CreatChat()
    {
       // this._chatServic.
        
        //chat service ga chatni  yaratuvchilarini berib yuboradi va va chat id sini qaytarib oladi
        return true;
    }

    public bool SendMassage(string massage, Guid chatId, Guid massageId)
    {
        throw new NotImplementedException();
    }
}