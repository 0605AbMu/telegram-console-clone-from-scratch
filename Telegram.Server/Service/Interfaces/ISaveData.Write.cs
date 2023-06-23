using Telegram.Server.Models;

namespace Telegram.Server.Service.Interfaces
{
    internal partial interface ISaveData
    {
        Task<T> WriteData<T>(SaveDataModels<T> data, string path);


    }
}
