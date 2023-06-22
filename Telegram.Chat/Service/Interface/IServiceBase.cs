using TelegramChat.Domain;

namespace TelegramChat.Service.Interface;

public interface IServiceBase<T>where T:ModelBase
{
    public void Add(T data);
    public void Delete(T data);
    public List<T> GetAllModel();
    public T FindModel(Guid id);
    public void AddRange(List<T> data);
  
}