using TelegramChat.Domain;
using TelegramChat.Service.Interface;

namespace Telegram.Client.Services;

public abstract class ServiceBase<T> : IServiceBase<T> where T : ModelBase
{
    private readonly List<T> _models;

    public ServiceBase()
    {
        _models = new List<T>();
    }

    public void Add(T data)
    {
        _models.Add(data);
    }

    public void Delete(T data)
    {
        _models.Remove(data);
    }

    public List<T> GetAllModel()
    {
        return _models;
    }

    public T FindModel(Guid id)
    {
        return _models.Find(x => x.Id == id);
    }

    public void AddRange(List<T> data)
    {
    }
}