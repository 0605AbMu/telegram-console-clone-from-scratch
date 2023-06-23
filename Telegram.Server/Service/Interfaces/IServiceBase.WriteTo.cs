namespace Telegram.Server.Service;

public partial interface IServiceBase
{
    /// <summary>
    ///     Tashqi xotiraga yozadi
    /// </summary>
    /// <param name="data">tashqi xotiraga yozilishi kerak bo'lgan biror service ning ma'lumotlari</param>
    public void WriteTo(object data, string filePath);
}