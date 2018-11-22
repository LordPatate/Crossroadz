using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossroadz3
{
    class Menu
    {
        Dictionary<string, Action> acts;
        public Action<int> Messages { get; }
        public bool mode_alternatif { get; set; }

        public Menu(Dictionary<string, Action> acts, Action<int> Messages)
        {
            this.acts = acts;
            this.Messages = Messages;
            this.mode_alternatif = false;
        }
        public bool ReceiveCmd(string input)
        {
            if (acts.ContainsKey(input))
            {
                Console.WriteLine();
                Program.WriteWithColor(Console.BackgroundColor, ConsoleColor.Green,
                    " >> ");
                acts[input]();
                return true;
            }
            else
                return false;
        }
    }
}
