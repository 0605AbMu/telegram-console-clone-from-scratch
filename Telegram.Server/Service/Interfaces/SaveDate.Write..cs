using System.Text.Json;
using Telegram.Server.Models;

namespace Telegram.Server.Service.Interfaces
{
    public partial class SaveDate : ISaveData
    {
        public async Task WriteData<T>(SaveDataModels<T> data, string path)
        {
            WriteData<T> result;
            if (File.Exists(path))
            {
                File.Create(path);

                using (StreamWriter writer = new StreamWriter(path))
                {
                    var json = JsonSerializer.Serialize(data);
                    writer.Write(json);
                }
            }
        }
    }
}
