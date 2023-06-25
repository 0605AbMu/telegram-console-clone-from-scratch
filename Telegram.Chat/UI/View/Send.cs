using System.Drawing;

namespace TelegramChat.UI.View;

public partial class Send
{
    public Send(Point top, Point left)
    {
        Top = top;
        Button = left;
    }

    public Point Top { get; set; }
    public Point Button { get; set; }
}