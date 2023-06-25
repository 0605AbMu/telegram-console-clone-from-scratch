using System.Drawing;
using LayoutChat.UI;

var top = new Point
{
    X = 10,
    Y = 10
};

var left = new Point
{
    X = 40,
    Y = 20
};

var layoutMessage = new LayoutMessage(new Point(41, 0), new Point(Console.WindowWidth, Console.WindowHeight - 2));
layoutMessage.Initial();
