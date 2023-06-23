namespace Telegram.Server.Service;

public partial interface IServiceBase
{
    /// <summary>
    /// Tashqi xotiradan o'qiydi
    /// </summary>
    /// <param name="filePath">Resource ning tashqi xotiradagi manzili</param>
    public List<T> Read<T>(string filePath);
}