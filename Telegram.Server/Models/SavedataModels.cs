namespace Telegram.Server.Models;

public class SavedataModels<T>
{
    public DateTime SaveDateTime { get; set; }
    public List<T> SavedList { get; set; }
}
