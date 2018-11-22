using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossroadz3
{
    class Diable
    {
        static void Messages(int i)
        {
            switch (i)
            {
                case 0:
                    Console.WriteLine(
                        "\"Que désirez-vous ?\"");
                    break;
                case 1:
                    Console.WriteLine(
                        "\"Je dois mal comprendre, ce que vous dites n'a aucun sens...\"");
                    break;
            }
        }

        static void Argent()
        {
            Console.WriteLine(
                "\"Ha Ha Ha ! Ces humains, tous les mêmes !\"\n" +
                "Vous ne savez pas trop comment, mais vous savez que vous venez de gagner un \n" +
                "million d'euros. ");
            Program.WriteWithColor(ConsoleColor.Blue, ConsoleColor.White,
                "[Exploit : \"L'argent des abonnés\" accompli !]\n");
            Console.WriteLine(
                "En revanche, vous vous sentez étonnament vide, comme si toute joie vous quit-\n" +
                "tait. Vous avez la lucidité de raccrocher avant que ça ne devienne douloureux.");
            Program.GetPlayer().argent += 1000000;
            Program.GetPlayer().ame = false;
            Program.currentMenu = Program.trottoir;
        }
        static void Dominer()
        {
            if(Program.GetPlayer().domination)
                Console.WriteLine(
                    "\"Excusez-moi, mais au dernières nouvelles, vous êtes déjà le roi du monde.\"");
            else
            {
                Console.WriteLine(
                    "\"Pathétique... l'orgueil des humains m'amusera toujours.\"\n" +
                    "Vous êtes désormais le roi du monde.");
                Program.WriteWithColor(ConsoleColor.Blue, ConsoleColor.White,
                    "[Exploit : 'Mégalomanie' accompli !]\n");
                Console.WriteLine(
                    "En revanche, vous vous sentez étonnament vide, comme si toute joie vous quit-\n" +
                    "tait. Vous avez la lucidité de raccrocher avant que ça ne devienne douloureux.");
                Program.GetPlayer().domination = true;
                Program.GetPlayer().ame = false;
                Program.currentMenu = Program.trottoir;
            }
        }
        static void Reset()
        {
            Console.WriteLine(
                "\"Ah, ce voeu-ci est plus rare. Très intéressant, comme choix.\"\n" +
                "Vous regardez votre montre : il est midi à nouveau, le soleil est revenu\n" +
                "à sa position culminante dans le ciel, pourtant rien d'autre n'a changé.\n" +
                "\"Passez une bonne deuxième après-midi ! Ha Ha Ha !\"\n" +
                "L'heure, et tout les éléments qui en dépendent, ont été réinitialisés.");
            Program.WriteWithColor(ConsoleColor.Blue, ConsoleColor.White,
                "[Exploit : 'No time to explain' accompli !]\n");
            Console.WriteLine(
                "En revanche, vous vous sentez étonnament vide, comme si toute joie vous quit-\n" +
                "tait. Vous avez la lucidité de raccrocher avant que ça ne devienne douloureux.");
            Program.GetPlayer().time = 0;
            Program.GetPlayer().ame = false;
            Program.currentMenu = Program.trottoir;
        }
        static void Traverser()
        {
            Console.WriteLine(
                "\"Hum. Inattendu, mais pourquoi pas. Tous les humains ne sont pas tous \n" +
                " pareils, finalement. Il y en a de plus stupides que d'autres.\n" +
                " En plus, vous avez oublié de préciser dans quel état vous voulez arriver.\"\n" +
                "Vous ne comprenez pas la suite, car votre interlocuteur est pris de fou rire.\n" +
                "Vous avez à peine le temps d'avoir un mauvais pressentiment avant d'être\n" +
                "violemment propulsé en avant. Votre corps est comme un pantin tiré par une \n" +
                "ficelle invisible qui vous tracte vers le trottoir d'en face. Au passage, \n" +
                "vous percutez tous les objets solides qui vous séparent de votre destination.\n" +
                "Vous arrivez de l'autre côté, méconnaissable et plus très vivant.\n" +
                "Vous n'avez plus d'âme non plus, c'était votre moyen de paiement.\n" +
                "");
            Program.WriteWithColor(ConsoleColor.DarkGreen, ConsoleColor.White,
                "[Exploit : \"Il suffit de demander\" accompli !]\n");
            Console.WriteLine(
                "Félicitations ! Vous avez traversé la rue !");
            Program.GetPlayer().ame = false;
            Program.currentMenu = Program.gameOver;
        }
        static void TP()
        {
            Console.WriteLine(
                "\"Tiens, voilà un voeu bien précis. Peut-être que j'ai affaire à un connais-\n" +
                " seur ?\"\n" +
                "Vous êtes téléporté sur le trottoir d'en face, bien vivant.");
            Program.WriteWithColor(ConsoleColor.Red, ConsoleColor.Yellow,
                "[Exploit legendaire : 'La securite avant tout' accompli !]\n");
            Console.WriteLine(
                "En revanche, vous vous sentez étonnament vide, comme si toute joie vous quit-\n" +
                "tait. Vous avez la lucidité de raccrocher avant que ça ne devienne douloureux.\n" +
                "\n" +
                "Mais ça, c'est du détail. L'important, c'est que vous avez traversé la rue !");
            Program.GetPlayer().ame = false;
            Program.currentMenu = Program.gameOver;
        }
        static void Rien()
        {
            Console.WriteLine(
                "\"Quel dommage... rappelez quand vous voulez ! Notre service est ouvert jour\n" +
                " et nuit. Au revoir !\"");
            Program.currentMenu = Program.trottoir;
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

            //argent
            dict.Add("argent", Argent);
            dict.Add("riche", Argent);
            dict.Add("etreriche", Argent);
            dict.Add("devenirriche", Argent);
            dict.Add("del'argent", Argent);
            dict.Add("gagnerargent", Argent);

            //dominer
            dict.Add("dominer", Dominer);
            dict.Add("dominermonde", Dominer);
            dict.Add("roidumonde", Dominer);
            dict.Add("roimonde", Dominer);
            dict.Add("regnermonde", Dominer);
            dict.Add("regnersurmonde", Dominer);
            dict.Add("etreroidumonde", Dominer);
            dict.Add("etreroimonde", Dominer);

            //reset
            dict.Add("remontertemps", Reset);
            dict.Add("temps", Reset);
            dict.Add("reinitialiser", Reset);
            dict.Add("reinitialisertemps", Reset);
            dict.Add("heure", Reset);
            dict.Add("reinitialiserheure", Reset);

            //traverser
            dict.Add("traverser", Traverser);
            dict.Add("traverserrue", Traverser);

            //tp
            dict.Add("setp", TP);
            dict.Add("tp", TP);
            dict.Add("etredel'autrecote", TP);
            dict.Add("atteindrel'autrecote", TP);
            dict.Add("etredeautrecote", TP);
            dict.Add("atteindreautrecote", TP);
            dict.Add("atteindretrottoird'enface", TP);
            dict.Add("traverservivant", TP);
            dict.Add("traversersansmourir", TP);

            //rien
            dict.Add("rien", Rien);
            dict.Add("nerienfaire", Rien);
            dict.Add("stop", Rien);
            dict.Add("raccrocher", Rien);
            dict.Add("arreter", Rien);

            return new Menu(dict, Messages);
        }
    }
}
