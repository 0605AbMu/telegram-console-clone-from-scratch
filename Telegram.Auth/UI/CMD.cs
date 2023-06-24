namespace TelegramClient.Auth.UI
{
    public abstract class CMD
    {
        protected void CursorSenter(string message)
        {
            Console.CursorLeft = 50;
            Console.CursorTop = 13;
            Console.Write(message);
        }
        protected void CursorSenter()
        {
            Console.CursorLeft = 50;
            Console.CursorTop = 13;
        }
        protected void CursorSenter(int x, int y)
        {
            Console.CursorLeft = 50 + x;
            Console.CursorTop = 13 + y;
        }
        protected void CursorSenter(int x, int y, string message)
        {
            Console.CursorLeft = 50 + x;
            Console.CursorTop = 13 + y;
            Console.Write(message);
        }
        protected void CursorSenterTop(string message)
        {
            Console.CursorLeft = 51;
            Console.CursorTop = 6;
            Console.Write(message);

        }
        protected void CursorSenterTop(int x, int y, string message)
        {
            Console.CursorLeft = 51 + x;
            Console.CursorTop = 6 + y;
            Console.Write(message);
        }
        protected void CursorSenterDown(string message)
        {
            Console.CursorLeft = 49;
            Console.CursorTop = 20;
            Console.Write(message);
        }
        protected void CursorSenterDown(int x, int y, string message)
        {
            Console.CursorLeft = 49 + x;
            Console.CursorTop = 20 + y;
            Console.Write(message);
        }
    }
}
