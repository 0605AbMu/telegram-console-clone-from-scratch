using TelegramClient.Auth.Domain;

namespace TelegramClient.Auth.Auth;

public class Service : IService , IUserService
{
    
    public  List<User> Users { get; set; }

    public Service()
    {
        Users = new List<User>();
    }
    
    public void Logins(string ponenumber, string password, Guid guid)
    {
        var userid =this.Users.Find(x => x.Phonenumber == ponenumber && x.Password == password);
        userid.Guid = guid;
    }

    public User Registration(string name, string password, string phonenumber)
    {
       var user = new User()
        {
            Name = name,
            Password = password,
            Phonenumber = phonenumber, 
            Guid = Guid.NewGuid(),
            ID = Guid.NewGuid()
        };
       Users.Add(user);
       return user;
    }

    //CRUD
    public void AddUser(string name, string phoneNumber, string password)
    {
        User user = new User()
        {
            Name = name,
            Phonenumber = phoneNumber,
            Password = password,
            Guid = Guid.NewGuid(),
            ID = Guid.NewGuid(),
        };
        this.Users.Add(user);
    }

    public List<User> GetAllUser()
    {
        return this.Users;
    }

    public void RemoveUser(Guid id, string phoneNumber)
    {
        foreach (User user in this.Users)
        {
            if (user.ID == id && user.Phonenumber == phoneNumber)
            {
                this.Users.Remove(user);
            }
        }
    }

    

    //UPDATE
    /*public void UpDate(Guid id, string? name, string? phoneNumber)
    {
        foreach (var user in this.Users)     
        {
            if (user.ID == id && (user.Name == name || user.Phonenumber == phoneNumber))
            {
                User user1 = new User()
                {
                    Name = name,
                    
                }
            }
        }
    }*/
}
