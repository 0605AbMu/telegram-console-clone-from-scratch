using System.Text.Json;

namespace Telegram.Server.Service;

public partial class ServiceBase
{
    public List<T> Read<T>(string filePath)
    {
        List<T> result;
        if (!File.Exists(filePath))
        {
            throw new Exception("Bunday file yuq");
        }

        var content = File.ReadAllText(filePath);
        result = JsonSerializer.Deserialize<List<T>>(content);
        return result;
    }
}