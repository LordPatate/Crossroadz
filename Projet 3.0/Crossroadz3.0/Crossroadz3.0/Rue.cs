using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossroadz3
{
    class Rue
    {
        static void Messages(int i)
        {
            switch(i)
            {
                case 0:
                    Console.WriteLine(
                        "Vous êtes en danger. Que faites-vous ?");
                    break;
                case 1:
                    Console.WriteLine(
                        "Commande non reconnue (ou impossible quand on est au milieu de la chaussée et en" +
                        "danger de mort).");
                    break;
            }
        }

        static void Regarder()
        {
            Console.WriteLine(
                "Vous êtes au beau milieu de la rue.\n" +
                "Une voiture arrive.\n" +
                "Vous êtes sur le point de vous faire écraser.");
        }
        static void Reculer()
        {
            Console.WriteLine(
                "Vous reculez et revenez sur le trottoir.");
            Program.currentMenu = Program.trottoir;
        }
        static void Avancer()
        {
            Console.WriteLine(
                "Vous avancez, mais pas assez vite. La voiture vous renverse.\n" +
                "Vous mourez sans avoir traversé la rue. Vous avez perdu.");
            Program.currentMenu = Program.gameOver;
        }
        static void Rien()
        {
            Console.WriteLine(
                "La voiture vous renverse.\n" +
                "Vous mourez sans avoir traversé la rue. Vous avez perdu.");
            Program.currentMenu = Program.gameOver;
        }
        static void StopperVoiture()
        {
            Console.WriteLine(
                "Les deux mains tendues en avant, le corps arc-bouté, vous vous tenez prêt à\n" +
                "arrêter une voiture lancée à 50 km/h.\n" +
                "Malgré votre détermination, la tentative reste désespérée.\n" +
                "Vous avez eu la classe jusqu'à ce que la voiture vous percute, vous réduisant\n" +
                "en bouillie informe.\n" +
                "");
            Program.WriteWithColor(ConsoleColor.DarkRed, ConsoleColor.White,
                "[Exploit : \"Lois de la mécanique\" accompli !]\n");
            Console.WriteLine(
                "Vous n'êtes plus en état de traverser la rue. Vous avez perdu.");
            Program.currentMenu = Program.gameOver;
        }
        static void Courir()
        {
            Console.WriteLine(
                "Vous décidez de courir, mais dans votre précipitation, vous trébuchez et tombez\n" +
                "à plat ventre sur la route.\n" +
                "La voiture vous roule dessus avant que vous n'ayez le temps de vous relever.\n" +
                "\n" +
                "Vous n'êtes plus en état de traverser la rue. Vous avez perdu.");
            Program.currentMenu = Program.gameOver;
        }
        static void Trottiner()
        {
            Console.WriteLine(
                "Vous accélerez le pas en trottinant, juste ce qu'il faut pour traverser avant\n" +
                "que la voiture ne vous percute.\n" +
                "Bravo ! Vous avez traversé la rue.\n" +
                "");
            Program.WriteWithColor(ConsoleColor.DarkGreen, ConsoleColor.White,
                "[Exploit : \"Le bon timing\" accompli !]");
            Program.currentMenu = Program.gameOver;
        }
        static void Sauter()
        {
            Console.WriteLine(
                "Vous réalisez un saut groupé sur place et la voiture passe sous vos pieds.\n" +
                "C'était spectaculaire, mais vous êtes toujours au milieu de la rue et une autre\n" +
                "voiture arrive.\n" +
                "Vous êtes toujours dans la même situation délicate.\n" +
                "");
            Program.WriteWithColor(ConsoleColor.Blue, ConsoleColor.White,
                "[Exploit : \"Pour le style !\" accompli !]");
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

            //regarder
            dict.Add("regarder", Regarder);
            dict.Add("regarderrue", Regarder);
            dict.Add("regardervoiture", Regarder);
            dict.Add("regarderroute", Regarder);

            //reculer
            dict.Add("reculer", Reculer);
            dict.Add("revenirenarriere", Reculer);
            dict.Add("revenirarriere", Reculer);

            //avancer
            dict.Add("avancer", Avancer);
            dict.Add("traverser", Avancer);
            dict.Add("marcher", Avancer);
            dict.Add("passer", Avancer);

            //rien
            dict.Add("rien", Rien);
            dict.Add("nerienfaire", Rien);
            dict.Add("rienfaire", Rien);
            dict.Add("nepasbouger", Rien);
            dict.Add("pasbouger", Rien);
            dict.Add("pleurer", Rien);
            dict.Add("attendre", Rien);
            dict.Add("patienter", Rien);

            //stopper voiture
            dict.Add("arretervoiture", StopperVoiture);
            dict.Add("stoppervoiture", StopperVoiture);
            dict.Add("stopervoiture", StopperVoiture);
            dict.Add("resister", StopperVoiture);

            //courir
            dict.Add("courir", Courir);
            dict.Add("foncer", Courir);
            dict.Add("rush", Courir);
            dict.Add("rusher", Courir);
            dict.Add("seprecipiter", Courir);
            dict.Add("sedepecher", Courir);
            dict.Add("sehater", Courir);

            //trottiner
            dict.Add("avancervite", Trottiner);
            dict.Add("trottiner", Trottiner);
            dict.Add("marchervite", Trottiner);
            dict.Add("courirlentement", Trottiner);
            dict.Add("courirdoucement", Trottiner);
            dict.Add("accelererdoucement", Trottiner);
            dict.Add("accelerer", Trottiner);
            dict.Add("marcherplusvite", Trottiner);

            //sauter
            dict.Add("sauter", Sauter);
            dict.Add("sautersurvoiture", Sauter);
            dict.Add("sauterpardessusvoiture", Sauter);
            dict.Add("sauterpardessus", Sauter);
            dict.Add("esquiver", Sauter);
            dict.Add("esquivervoiture", Sauter);
            dict.Add("eviter", Sauter);
            dict.Add("evitervoiture", Sauter);

            return new Menu(dict, Messages);
        }
    }
}
