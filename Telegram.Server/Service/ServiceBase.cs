namespace Telegram.Server.Service;

public abstract class ServiceBase : IServiceBase
{
    public List<T> Read<T>(string fiePath)
    {
        throw new NotImplementedException();
    }

    public void WriteTo(object data, string filePath)
    {
        throw new NotImplementedException();
    }
}