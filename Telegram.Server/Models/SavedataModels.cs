namespace Telegram.Server.Models;

public class SavedataModels<T>
{
    public DateTime SaveDateTime { get; set; }
    public T  Service { get; set; }
    public string FilePath { get; set; }
}
