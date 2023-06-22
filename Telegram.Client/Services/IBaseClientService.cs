using Telegram.Clent.Domain;


namespace Telegram.Clent;
public interface IBaseClientService<T>
{
   public List<T> models { get; set; }
   public T AddClient(T t);

   public T UpdateClientData(Guid id, int item,string change);

   public bool DeleteClient(Guid id);

   public T GetById(Guid guid);
}