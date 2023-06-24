using TelegramClient.Auth.UI;

namespace TelegregramRoot;

public class Display
{
    
    private Context _contextAuth ;

   // private ContextClient _contextClient;
    // shunqa uxshab 4 context ochish kerak tayor bulsa
    

    public Display()
    {
        this._contextAuth = new Context();
    }

    public void Start()
    {
        Thread threadForAuth = new Thread(() =>
        {
            while (true)
            {
                //this._context.ActiwView.Start();
            }
        });
        
        Thread threadForClient = new Thread(() =>
        {
            while (true)
            {
                //this._context.ActiwView.Start();
            }
        });
        
        Thread threadForChat = new Thread(() =>
        {
            while (true)
            {
                //this._context.ActiwView.Start();
            }
        });
    }
}