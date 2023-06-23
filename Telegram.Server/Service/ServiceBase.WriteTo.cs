using System.Text.Json;

namespace Telegram.Server.Service
{
    public partial class ServiceBase
    {

        public void WriteTo(object data, string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Create(filePath);
            }
            var json = JsonSerializer.Serialize(data);
            File.AppendAllText(filePath, json);
        }
    }
}
