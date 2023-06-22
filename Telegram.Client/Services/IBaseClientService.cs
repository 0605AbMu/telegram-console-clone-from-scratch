using Telegram.Clent.Domain;


namespace Telegram.Clent;
public class IBaseClientService
{
    public bool AddClient()
    {
        //yangi client yaratish
        return true;
    }
    
    public bool UpdateClientData()
    {
        //client malumotlarini yangilash
        return true;
    }
    
    public bool DeleteClient()
    {
        //clientni o'chirish
        return true;
    }

    public Client GetById(Guid guid)
    {
        //berilgan id li clientni qaytarish
        return null;
    }
}