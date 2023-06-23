using TelegramChat.Domain;
using TelegramChat.Service.Interface;

namespace Telegram.Clent.Services;

public abstract class ServiceBase<T>: IServiceBase<T> where T : ModelBase
{
    private readonly List<T> _models;
    public ServiceBase()
    {
        this._models = new List<T>();
    }
    public void Add(T data)
    {
        this._models.Add(data);
    }

    public void Delete(T data)
    {
        this._models.Remove(data);
    }

    public List<T> GetAllModel()
    {
        return this._models;
    }

    public T FindModel(Guid id)
    {
        return this._models.Find(x => x.Id == id);
    }

    public void AddRange(List<T> data)
    {
        
    }
}