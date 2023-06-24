using System.Drawing;
using Telegram.Clent.UI;

ViewModel view = new ViewModel()
{
    ClientName  = "zuxriddin",
    LastMessage = "salom",
    MessageDate = DateTime.Now
};
ViewModel view1 = new ViewModel()
{
    ClientName  = "Feruz",
    LastMessage = "salom dunyo",
    MessageDate = DateTime.Now.AddMinutes(5)
};
ViewModel view2 = new ViewModel()
{
    ClientName  = "zarifov",
    LastMessage = "salom asd",
    MessageDate = DateTime.Now.AddHours(1)
};
Point top = new Point(10,10);
Point button = new Point(60,40);
Layout layout = new Layout(top,button);
layout.Initial();
layout.Write(view);
layout.Write(view1);
layout.Write(view2);
