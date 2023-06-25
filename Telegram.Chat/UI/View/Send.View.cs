namespace TelegramChat.UI.View;

/// <summary>
///     Send class ChatView ning UI qismi uchun view tayyorlab beradi
/// </summary>
public partial class Send
{
    public void LayOut()
    {
        Console.CursorLeft = Top.X;
        Console.CursorTop = Top.Y;
        var x = Button.X - Top.X;
        var y = Button.Y - Top.Y;
        Console.Write("".PadRight(x, '+'));
        for (var i = 0; i < y; i++)
        {
            Console.WriteLine();
            Console.Write("|" + "".PadRight(Button.X - Top.X - 2, ' ') + "|");

            Console.CursorLeft = Top.X;
        }

        Console.Write("".PadRight(x, '+'));
    }
}