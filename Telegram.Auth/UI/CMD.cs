using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramClient.Auth.UI
{
    public abstract class CMD
    {
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
        protected void CursorSenterTop()
        {
            Console.CursorLeft = 51;
            Console.CursorTop = 6;
        }
        protected void CursorSenterTop(int x, int y)
        {
            Console.CursorLeft = 51 + x;
            Console.CursorTop = 6 + y;
        }
        protected void CursorSenterDown()
        {
            Console.CursorLeft = 49;
            Console.CursorTop = 20;
        }
        protected void CursorSenterDown(int x, int y)
        {
            Console.CursorLeft = 49 + x;
            Console.CursorTop = 20 + y;
        }
    }
}
