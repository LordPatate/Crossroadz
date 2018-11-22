using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossroadz3
{
    class Tel
    {
        static void Messages(int i)
        {
            switch (i)
            {
                case 0:
                    Program.WriteWithColor(ConsoleColor.Black, ConsoleColor.Gray,
                        "  ________________________  \n");
                    Program.WriteWithColor(ConsoleColor.Black, ConsoleColor.Gray,
                        " |");
                    Program.WriteWithColor(ConsoleColor.DarkBlue, ConsoleColor.White,
                        ">> TÉLÉPHONER           ");
                    Program.WriteWithColor(ConsoleColor.Black, ConsoleColor.Gray,
                        "| \n" +
                        " |");
                    Program.WriteWithColor(ConsoleColor.DarkBlue, ConsoleColor.White,
                        ">> NUMÉROS COURANTS :   ");
                    Program.WriteWithColor(ConsoleColor.Black, ConsoleColor.Gray,
                        "| \n" +
                        " |");
                    Program.WriteWithColor(ConsoleColor.DarkBlue, ConsoleColor.White,
                        "     8294 : taxi        ");
                    Program.WriteWithColor(ConsoleColor.Black, ConsoleColor.Gray,
                        "| \n" +
                        " |");
                    Program.WriteWithColor(ConsoleColor.DarkBlue, ConsoleColor.White,
                        "     17   : police      ");
                    Program.WriteWithColor(ConsoleColor.Black, ConsoleColor.Gray,
                        "| \n" +
                        " |");
                    Program.WriteWithColor(ConsoleColor.DarkBlue, ConsoleColor.White,
                        "     (0   : fermer)     ");
                    Program.WriteWithColor(ConsoleColor.Black, ConsoleColor.Gray,
                        "|\n" +
                        " |");
                    Program.WriteWithColor(ConsoleColor.DarkBlue, ConsoleColor.White,
                        " >");
                    break;
                case 1:
                    Program.WriteWithColor(ConsoleColor.Black, ConsoleColor.Gray,
                        " |");
                    Program.WriteWithColor(ConsoleColor.DarkBlue, ConsoleColor.White,
                        " NUMÉRO NON RÉPERTORIÉ  ");
                    Program.WriteWithColor(ConsoleColor.Black, ConsoleColor.Gray,
                        "| \n");
                    break;
            }
        }
        
        static void _42()
        {
            Console.WriteLine(
                "Ha Ha Ha. Bon d'accord, c'est déjà une réponse.\n" +
                "Mais on vous demande un numéro.");
        }
        static void _8294()
        {
            Console.WriteLine(
                "\"Votre taxi est en route.\"\n" +
                "\"Veuillez patienter le temps qu'il arrive.\"\n" +
                "\"Cela ne devrait pas prendre plus de 30 secondes.\"\n" +
                "\"Merci d'utiliser notre service.\"");
            Program.Patienter(6);
            Console.WriteLine(
                "Le taxi est arrivé.");
            if (Program.GetPlayer().argent >= 0.01)
            {
                Console.WriteLine(
                    "Vous prenez le taxi pour traverser la rue.\n" +
                    "Vous le payez 0.01 euros.");
                Program.WriteWithColor(ConsoleColor.DarkGreen, ConsoleColor.White,
                    "[Exploit : \"Flemmardise a l'américaine\" accompli !]\n");
                Program.GetPlayer().argent -= 0.01f;
                Program.currentMenu = Program.gameOver;
            }
            else
                Console.WriteLine(
                    "Vous n'avez pas d'argent. Le taxi s'en va.");
        }
        static void _17()
        {
            Console.WriteLine(
                "Vous avez appelé la police.\n" +
                "Une voiture de police vous est envoyée en urgence.\n" +
                "Elle devrait arriver en quelques secondes.");
            Program.Patienter(2);
            if(Program.GetPlayer().pantalon)
            {
                Console.WriteLine(
                    "Comme vous les avez dérangé pour rien, les policiers sont franchement agacés.");
                if(Program.GetPlayer().argent >= 1000000)
                {
                    Console.WriteLine(
                        "L'un d'eux demande à voir si vos papiers sont en règle.\n" +
                        "Alors que vous sortez votre portefeuille, ils ouvrent de grands yeux en \n" +
                        "découvrant le nombre de billets de banque qu'il contient.\n" +
                        "\"Ça alors... on dirait bien qu'on a enfin trouvé celui qui a volé un million à " +
                        " la banque ce matin. Vous êtes en état d'arrestation !\"");
                    Program.currentMenu = Program.gameOver;
                }
                else
                    Program.currentMenu = Program.police;
            }
            else
            {
                Console.WriteLine(
                    "La police arrive, prête à l'action, et tombe sur... vous. Sans pantalon.\n" +
                    "\"Qu'est-ce que vous faites dans cette tenue ?! Venez, vous vous expliquerez" +
                    " au poste !\"\n" +
                    "Vous êtes en état d'arrestation.");
                Program.currentMenu = Program.gameOver;
            }
        }
        static void _666()
        {
            Program.WriteWithColor(ConsoleColor.DarkYellow, ConsoleColor.White,
                "[Accès au menu : \"God's busy. Can I help you ?\"]\n");
            Console.WriteLine(
                "\"Bienvenue. Ne quittez pas, un opérateur bienveillant va vous répondre.\"");
            Program.Patienter(1);
            Console.WriteLine(
                "\"Bonjour. Un instant je vous prie, je vérifie que vous avez de quoi... payer...\"" +
                "Vous sentez comme un souffle chaud traverser votre corps.");
            if (Program.GetPlayer().ame)
            {
                Console.WriteLine(
                    "\"Parfait ! Je vois que vous avez les moyens.\n" +
                    " Nous exauçons tous les voeux, ou presque...\"");
                Program.currentMenu = Program.diable;
            }
            else
            {
                Console.WriteLine(
                    "\"Oh... On dirait que vous n'avez plus d'âme à nous offrir... Dans ce cas...\"");
                Console.ReadKey();
                Console.Clear();
                Console.ReadKey();
                Console.Clear();
                Program.WriteWithColor(Console.BackgroundColor, ConsoleColor.DarkRed,
                    "Tu m'appartiens déjà.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(
                    "Vous avez l'impression de quitter votre corps.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(
                    "Vous avez l'impression de quitter votre corps.\n" +
                    "                                   Et d'être aspirés sous terre.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(
                    "Vous avez l'impression de quitter votre corps.\n" +
                    "                                   Et d'être aspirés sous terre.\n" +
                    "\n" +
                    "                Profond.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(
                    "Vous avez l'impression de quitter votre corps.\n" +
                    "                                   Et d'être aspirés sous terre.\n" +
                    "\n" +
                    "                Profond. Chaud.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(
                    "Vous avez l'impression de quitter votre corps.\n" +
                    "                                   Et d'être aspirés sous terre.\n" +
                    "\n" +
                    "                Profond. Chaud.\n" +
                    "                           Très\n" +
                    "                                chaud.");
                Console.ReadKey();
                Console.Clear();
                Program.currentMenu = Program.gameOver;
            }
        }
        static void _0()
        {
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

            //42
            dict.Add("42", _42);

            //taxi
            dict.Add("8294", _8294);

            //police
            dict.Add("17", _17);

            //diable
            dict.Add("666", _666);

            //fermer
            dict.Add("0", _0);
            dict.Add("fermer", _0);
            dict.Add("stop", _0);
            dict.Add("arreter", _0);
            dict.Add("ranger", _0);

            return new Menu(dict, Messages);
        }
    }
}
