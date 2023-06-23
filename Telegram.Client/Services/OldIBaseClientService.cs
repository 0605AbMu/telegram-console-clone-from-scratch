using Telegram.Clent.Domain;



namespace Telegram.Clent;
public interface IBaseClientService<T>
{
    public List<T> models { get; set; }
    public T AddClient(T t);

    /// <summary>
    /// id client idsi
    /// item o'zgarish turi
    /// change o'zgarish
    /// </summary>
    /// <param name="id"></param>
    /// <param name="item"></param>
    /// <param name="change"></param>
    /// <returns></returns>
    public T UpdateClientData(Guid id ,int item,string change);

    public bool DeleteClient(Guid id);
    public Client GetById(Guid guid);

}