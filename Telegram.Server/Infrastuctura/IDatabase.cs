using Telegram.Server.Models;

namespace Telegram.Server.Infrastuctura;

public interface IDatabase<T>
{
    Task DataWrite(SavedataModels<T> savedataModels, string path);
    public SavedataModels<T> DataRead(string path);
}
