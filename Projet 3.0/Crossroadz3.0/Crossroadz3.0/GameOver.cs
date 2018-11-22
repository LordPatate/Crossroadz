using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossroadz3
{
    class GameOver
    {
        static void Messages(int i)
        {
            int time = Program.GetPlayer().time;
            switch (i)
            {
                case 0:
                    Console.WriteLine(
                        "Vous avez trouvé une fin du jeu.\n" +
                        "Vous avez cherché comment traverser pendant " + time / 3600 + " h " + time % 3600 / 60 + " min " + time % 3600 % 60 + " s.\n" +
                        "Il vous reste " + Program.GetPlayer().argent + " euros.\n");
                    if (!Program.GetPlayer().ame)
                        Console.WriteLine(
                            "Vous n'avez plus d'âme.");
                    Console.WriteLine(
                        "Voulez-vous recommencer ?");
                    break;
                case 1:
                    Console.Write("");
                    break;
            }
        }
        

        public static Menu Init()
        {
            Dictionary<string, Action> dict = new Dictionary<string, Action>();
            dict.Add("rejouer", Program.Start);
            dict.Add("restart", Program.Start);
            dict.Add("continuer", Program.Start);
            dict.Add("jouer", Program.Start);
            dict.Add("oui", Program.Start);

            dict.Add("clear", Console.Clear);
            dict.Add("effacer", Console.Clear);

            dict.Add("non", Program.Exit);
            dict.Add("quitter", Program.Exit);
            dict.Add("fermer", Program.Exit);

            return new Menu(dict, Messages);
        }
    }
}
