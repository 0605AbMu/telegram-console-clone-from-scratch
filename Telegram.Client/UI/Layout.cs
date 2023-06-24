
using System.Drawing;
using TelegramChat.Domain;


public class Layout
{
    public Layout(Point top, Point left)
    {
        Top = top;
        Button = left;
    }

    public Point Top { get; set; }
    public Point Button { get; set; }




//        Console.WriteLine($"+{"-".PadRight(data[0].ToString().Length - 2, '-')}+");


    public void Clear()
      {
          Console.CursorLeft = Top.X;
          Console.CursorTop = Top.Y;
          int x = Button.X - Top.X;
          int y = Button.Y - Top.Y;
          for(int i = 0; i < y; i++)
          {
              for(int j = 0; j < x; j++)
              {
                  Console.Write(" ");
              }
              Console.WriteLine();
              Console.CursorLeft = Top.X;
          }
      }
  
      public void Write(List<Chat> chats)
      {
      
              Console.CursorLeft = Top.X;
              Console.CursorTop = Top.Y;
              int x = Button.X - Top.X;
              int y = Button.Y - Top.Y;
              string str = "";
              int hour;
              int minut;
              foreach (var chat in chats)
              {
                 
                  hour = chat.massageList[chat.massageList.Count - 1].Time.Hour;
                  minut = chat.massageList[chat.massageList.Count - 1].Time.Minute;
       
                  Console.Write($"{chat.Name.PadRight(43, ' ')} {hour}:{minut}\n");

                  Console.CursorLeft = Top.X;
                  Console.Write($"{chat.massageList[chat.massageList.Count - 1].MessageClient.PadRight(49, ' ')}\n");

                  Console.CursorLeft = Top.X;
                  Console.Write("+-------------------------------------------------+");
                  Console.WriteLine();
                  Console.CursorLeft = Top.X;

              }
      }
      
      public void Initial()
      {
          
      }
}