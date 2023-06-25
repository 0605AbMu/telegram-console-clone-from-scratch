namespace TelegramChat.UI.View;

public partial class Send
{
    public string Imput()
    {
        Console.CursorLeft = Top.X + 1;
        Console.CursorTop = Top.Y + 1;
        var x = Button.X - Top.X;
        var result = "";
        while (true)
        {
            Clear();
            if (result != "")
                Console.Write(Write(result, x));
            if (Console.CursorLeft == x - 1)
                Clear();

            var key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.Enter:
                    if (result == "")
                        return null;
                    return result;
                case ConsoleKey.Backspace:
                    if (result.Length > 0)
                        result = result.Substring(0, result.Length - 1);
                    break;
                default:
                    result += key.KeyChar.ToString();
                    break;
            }
        }
    }

    private string Write(string message, int x)
    {
        var resualt = new char[x - 2];
        foreach (var str in message.Chunk(x - 2)) resualt = str;

        return new string(resualt);
    }

    private void Clear()
    {
        Console.CursorLeft = Top.X + 1;
        Console.CursorTop = Top.Y + 1;
        var x = Button.X - Top.X;
        var y = Button.Y - Top.Y;
        for (var i = 0; i < x - 2; i++) Console.Write(" ");

        Console.CursorLeft = Top.X + 1;
        Console.CursorTop = Top.Y + 1;
    }
}