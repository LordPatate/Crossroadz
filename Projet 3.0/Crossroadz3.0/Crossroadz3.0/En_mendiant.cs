using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossroadz3
{
    class En_mendiant
    {
        static void Messages(int i)
        {
            switch (i)
            {
                case 0:
                    Console.WriteLine(
                        "Vous êtes en train de mendier.\n" +
                        "Vos gains dépendront de votre patience et de votre charisme.");
                    break;
                case 1:
                    Console.WriteLine(
                        "Commande non reconnue ou impossible en mendiant.");
                    break;
                case 2:
                    Console.WriteLine(
                        "Vous êtes en train de chanter et danser pendant que vous mendiez.\n" +
                        "Vos gains sont doublés mais il faut toujours être patient.");
                    break;
            }
        }

        static void Attendre()
        {
            Random rand = new Random();
            int x = rand.Next(1, 3) * (Program.currentMenu.mode_alternatif ? 2 : 1);
            Console.WriteLine(
                "Vous attendez une minute.\n" +
                "Vous gagnez " + x + " euros.");
            Program.GetPlayer().argent += x;
            Program.GetPlayer().time += 60;
        }
        static void Attendre2()
        {
            Random rand = new Random();
            int x = rand.Next(25, 75) * (Program.currentMenu.mode_alternatif ? 2 : 1);
            Console.WriteLine(
                "Vous attendez une heure.\n" +
                "Vous gagnez " + x + " euros.");
            Program.GetPlayer().argent += x;
            Program.GetPlayer().time += 3600;
        }
        static void Chanter()
        {
            Console.WriteLine(
                "Vous vous mettez à chanter et à danser.\n" +
                "Vous attirez davantage l'attention.");
            Program.WriteWithColor(ConsoleColor.Blue, ConsoleColor.White,
                "[Exploit : \"Spectacle de rue\" accompli !]");
            Program.currentMenu.mode_alternatif = true;
        }
        static void Arreter_chant()
        {
            if (Program.currentMenu.mode_alternatif)
            {
                Console.WriteLine(
                    "Vous arrêtez de danser et de chanter.");
                Program.currentMenu.mode_alternatif = false;
            }
            else
                Console.WriteLine(
                    "Vous n'étiez pas en train de chanter ou de danser.");
        }
        static void Arreter()
        {
            if (Program.currentMenu.mode_alternatif)
            {
                Console.WriteLine(
                    "Vous arrêtez de danser et de chanter.");
                Program.currentMenu.mode_alternatif = false;
            }
            Console.WriteLine(
                "Vous arrêtez de mendier.");
            Program.currentMenu = Program.trottoir;
        }
        static void Regarder_argent()
        {
            Console.WriteLine(
                "Vous avez " + Program.GetPlayer().argent + " euros.");
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

            //arrêter
            dict.Add("arreter", Arreter);
            dict.Add("stop", Arreter);

            //attendre
            dict.Add("attendre", Attendre);
            dict.Add("patienter", Attendre);
            dict.Add("attendreplus", Attendre2);
            dict.Add("patienterplus", Attendre2);
            dict.Add("attendrelongtemps", Attendre2);
            dict.Add("patienterlongtemps", Attendre2);
            dict.Add("attendrepluslongtemps", Attendre2);
            dict.Add("patienterpluslongtemps", Attendre2);
            dict.Add("attendre1h", Attendre2);
            dict.Add("patienter1h", Attendre2);

            //chanter
            dict.Add("chanter", Chanter);
            dict.Add("danser", Chanter);

            //arrêter de chanter
            dict.Add("stopchant", Arreter_chant);
            dict.Add("stopchanter", Arreter_chant);
            dict.Add("arreterchant", Arreter_chant);
            dict.Add("arreterchanter", Arreter_chant);
            dict.Add("stopdanser", Arreter_chant);
            dict.Add("arreterdanser", Arreter_chant);

            //regarder
            dict.Add("regarder", Regarder_argent);
            dict.Add("regarderargent", Regarder_argent);
            dict.Add("argent", Regarder_argent);

            return new Menu(dict, Messages);
        }
    }
}
