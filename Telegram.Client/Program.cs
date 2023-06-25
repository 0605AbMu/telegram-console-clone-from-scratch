// Console.WriteLine("Hello, World!");

using System.Drawing;
using Telegram.Clent.UI;

// new ContextClient(new Layout(new Point(10,0), new Point(20, 20))).Start();
Layout layout = new Layout(new Point(0,0), new Point(30, 10));
layout.Initial();
layout.Write(new ViewModel()
{
    ClientName = "adasd",
    LastMessage = "dsfsdfsdf",
    MessageDate = DateTime.Now
});

Thread.Sleep(2000);
layout.Clear();

Console.ReadKey();