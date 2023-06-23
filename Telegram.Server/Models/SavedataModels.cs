namespace Telegram.Server.Models;

public class SaveDataModels<T>
{
    public DateTime SaveDateTime { get; set; }
    public T  Service { get; set; }
    public string FilePath { get; set; }
}
