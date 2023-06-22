using System.Text.Json;
using Telegram.Server.Models;

namespace Telegram.Server.Infrastuctura;
public class Database<T> : IDatabase<T> where T : class
{
    public SavedataModels<T> DataRead(string path)
    {
        string content = File.ReadAllText(path);
        return DeSerializa(content);
    }
    public SavedataModels<T> DeSerializa(string content) => JsonSerializer.Deserialize<SavedataModels<T>>(content);

    public async Task DataWrite(SavedataModels<T> savedataModels, string path)
    {
        File.WriteAllText(path,Serialize(savedataModels));
    }
    public string Serialize(SavedataModels<T> savedataModels) => JsonSerializer.Serialize(savedataModels);
}
