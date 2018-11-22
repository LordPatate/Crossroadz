using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossroadz3
{
    class Magasin
    {
        static void Messages(int i)
        {
            switch (i)
            {
                case 0:
                    Console.WriteLine(
                        "\"Quelque chose vous intéresse ?\"\n" +
                        "Vous avez " + Program.GetPlayer().argent + " euros.\n" +
                        "Entrez le nom d'un objet ou tapez \"sortir\" pour quitter le magasin.");
                    break;
                case 1:
                    Console.WriteLine(
                        "\"Désolé, je n'ai pas de ça en stock. Je ne vois même pas de quoi vous voulez\n" +
                        " parler.\"");
                    break;
            }
        }

        static void Partir()
        {
            Console.WriteLine(
                "Vous sortez du magasin.");
            Program.currentMenu = Program.trottoir;
        }
        static void Regarder()
        {
            Console.WriteLine(
                "Vous parcourez les étagères du regard. Certains articles retiennent votre \n" +
                "attention :\n" +
                "  Pelle    ( 50 euros )\n" +
                "  Peinture ( 10 euros )\n" +
                "  Journal  (  2 euros )\n" +
                "  Pantalon ( 30 euros )");
        }
        static void Pelle()
        {
            if (Program.GetPlayer().pelle)
                Console.WriteLine(
                    "Vous avez déjà une pelle.");
            else
            {
                if (Program.GetPlayer().argent >= 50)
                {
                    Console.WriteLine(
                        "Vous achetez une pelle pour 50 euros.");
                    Program.GetPlayer().pelle = true;
                    Program.GetPlayer().argent -= 50;
                }
                else
                    Console.WriteLine(
                        "La pelle coûte 50 euros. Vous ne pouvez pas vous la payer.");
            }
        }
        static void Peinture()
        {
            if (Program.GetPlayer().peinture)
                Console.WriteLine(
                    "Vous avez déjà de la peinture.");
            else
            {
                if (Program.GetPlayer().argent >= 10)
                {
                    Console.WriteLine(
                        "Vous achetez de la peinture pour 10 euros.");
                    Program.GetPlayer().peinture = true;
                    Program.GetPlayer().argent -= 10;
                }
                else
                    Console.WriteLine(
                        "La peinture coûte 10 euros. Vous ne pouvez pas vous la payer.");
            }
        }
        static void Journal()
        {
            if (Program.GetPlayer().journal)
                Console.WriteLine(
                    "Vous avez déjà le journal.");
            else
            {
                if (Program.GetPlayer().argent >= 2)
                {
                    Console.WriteLine(
                        "Vous achetez le journal pour 2 euros.");
                    Program.GetPlayer().journal = true;
                    Program.GetPlayer().argent -= 2;
                }
                else
                    Console.WriteLine(
                        "Le journal coûte 2 euros. Vous ne pouvez pas vous le payer.");
            }
        }
        static void Pantalon()
        {
            if (Program.GetPlayer().pantalon)
                Console.WriteLine(
                    "Vous avez déjà un pantalon.");
            else
            {
                if (Program.GetPlayer().argent >= 30)
                {
                    Console.WriteLine(
                        "Vous achetez un pantalon pour 30 euros.");
                    Program.GetPlayer().pantalon = true;
                    Program.GetPlayer().argent -= 30;
                }
                else
                    Console.WriteLine(
                        "Le pantalon coûte 30 euros. Vous ne pouvez pas vous le payer.");
            }
        }

        public static Menu Init()
        {
            Dictionary<string, Action> dict = new Dictionary<string, Action>();
            //built-in
            dict.Add("recommencer", Program.Start);
            dict.Add("restart", Program.Start);
            dict.Add("clear", Console.Clear);
            dict.Add("effacer", Console.Clear);
            dict.Add("quitter", Program.Exit);
            dict.Add("fermer", Program.Exit);

            //partir
            dict.Add("partir", Partir);
            dict.Add("sortir", Partir);
            dict.Add("arreter", Partir);
            dict.Add("stop", Partir);

            //regarder
            dict.Add("regarder", Regarder);

            //pelle
            dict.Add("pelle", Pelle);
            dict.Add("acheterpelle", Pelle);

            //peinture
            dict.Add("peinture", Peinture);
            dict.Add("pinceau", Peinture);
            dict.Add("acheterpeinture", Peinture);
            dict.Add("acheterpinceau", Peinture);

            //journal
            dict.Add("journal", Journal);
            dict.Add("acheterjournal", Journal);

            //pantalon
            dict.Add("pantalon", Pantalon);
            dict.Add("acheterpantalon", Pantalon);

            return new Menu(dict, Messages);
        }
    }
}
