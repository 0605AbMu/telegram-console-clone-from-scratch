namespace Telegram.Server.UI
{
    public partial class SendView
    {
        public delegate void Keys();
        public Keys KeysEscape;
        /// <summary>
        ///  KeysEscape: Chatlar oynasiga o'tish.
        /// </summary>
        public Keys KeysTab;
        /// <summary>
        ///  KeysTab: oynadan oynaga o'tish.
        /// </summary>
        public Keys KeysEnter;
        /// <summary>
        ///  KeysEnter: yozilgan massage ni yuborish.
        /// </summary>
        public Keys KeysBackSpace;
        /// <summary>
        ///  KeysBackSpace: yozilgan massage ni o'chirish.
        /// </summary>
        public void Delegate()
        {
            while (true)
            {
                var key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.Escape:
                        this.KeysEscape();
                        break;
                    case ConsoleKey.Tab:
                        this.KeysTab();
                        break;
                    case ConsoleKey.Enter:
                        this.KeysEnter();
                        break;
                    case ConsoleKey.Backspace:
                        this.KeysBackSpace();
                        break;
                }
            }
        }
    }
}
