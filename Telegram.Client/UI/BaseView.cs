

namespace Telegram.Clent.UI;

public class BaseView
{
  
         protected readonly Context _context;
         protected int index = 1;

         public Client.Domain.Client SignedUser { get; set; }

         public BaseView(Context context)
         {
             _context = context;
         }

  

         public void Start()
         {
             this.Home(null);
         }

         public virtual void Home(string? message = null)

         {
             Console.Clear();
             if (message is not null)
                 Console.WriteLine(message);
         }

         public  void LogOut()
         {
             Console.WriteLine("Are you sure to log out?(Y/N)");
             if (Console.ReadKey().Key == ConsoleKey.Y)
             {
                 this._context.SignedUser = null;
                 return;
             }
             this.Home();
         } 
     }

    
    