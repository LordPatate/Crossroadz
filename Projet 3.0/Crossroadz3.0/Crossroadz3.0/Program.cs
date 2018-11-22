using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossroadz3
{
    class Program
    {
        static bool endGame;
        public static Menu currentMenu { get; set; }
        public static Menu gameOver { get; set; }
        public static Menu trottoir { get; set; }
        public static Menu rue { get; set; }
        public static Menu en_mendiant { get; set; }
        public static Menu tel { get; set; }
        public static Menu police { get; set; }
        public static Menu diable { get; set; }
        public static Menu magasin { get; set; }

        static Player player;
        public static Player GetPlayer() { return player; }
        static void Main(string[] args)
        {
            gameOver = GameOver.Init();
            trottoir = Trottoir.Init();
            rue = Rue.Init();
            en_mendiant = En_mendiant.Init();
            tel = Tel.Init();
            police = Police.Init();
            diable = Diable.Init();
            magasin = Magasin.Init();

            Start();
            while (!endGame)
            {
                Console.WriteLine();
                if (!currentMenu.mode_alternatif)
                    currentMenu.Messages(0);
                else
                    currentMenu.Messages(2);
                if (!PlayStep(currentMenu))
                {
                    WriteWithColor(Console.BackgroundColor, ConsoleColor.Red,
                        " >> ");
                    currentMenu.Messages(1);
                }
            }
            
        }
        public static void Start()
        {
            currentMenu = trottoir;
            endGame = false;
            en_mendiant.mode_alternatif = false;
            police.mode_alternatif = false;
            Console.Clear();
            player = new Player();
            Console.WriteLine(
"le texte est trop PETIT ? Essayez cette séquence : [clic droit] (sur le titre de la fenêtre) > Propriétés > Police. Vous pourrez y définir la façon dont le texte s'affichera. Format de fenêtre conseillé : 25 lignes - 80 colonnes.\n"+
"\n" +
"                         ----------------------\n" +
"                               CROSSROADZ\n" +
"                         ----------------------\n" +
"But du jeu : traverser la rue.\n" +
"Comment jouer :\n" +
" - Entrez des commandes et appuyez sur entrée.\n" +
" - Si une commande ne marche pas, essayez une autre facon de décrire votre\n" +
"   action. Allez à l'essentiel et ne faites pas de fautes !\n" +
" - N'utilisez pas de déterminants ou de mots de liaisons que vous jugez inutiles"+
"   comme \"le\", \"de\", \"sur\"...\n" +
" - Si vous ne savez pas quoi faire, essayer d'utiliser la commande \"regarder\".\n" +
"   Notez que vous pouvez préciser la commande pour avoir une information plus\n" +
"   précise : par exemple \"regarder feu\".\n" +
"Tapez 'recommencer' ou 'restart' pour recommencer.\n" +
"Tapez 'effacer' ou 'clear' pour effacer l'historique.");
        }
        public static void Exit() { endGame = true; }

        static bool PlayStep(Menu menu)
        {
            string input = Console.ReadLine();
            string cmd = "";
            foreach(char c in input)
                switch(c)
                {
                    case 'é':
                    case 'è':
                    case 'ê':
                        cmd += 'e';
                        break;
                    case 'à':
                    case 'â':
                        cmd += 'a';
                        break;
                    case 'ù':
                    case 'û':
                        cmd += 'u';
                        break;
                    case 'ô':
                        cmd += 'o';
                        break;
                    case 'ç':
                        cmd += 'c';
                        break;
                    case ' ':
                        break;
                    default:
                        cmd += c;
                        break;
                }
            return menu.ReceiveCmd(cmd);
        }

        public static void WriteWithColor(ConsoleColor bkg, ConsoleColor frg, string s)
        {
            ConsoleColor def_bkg = Console.BackgroundColor;
            ConsoleColor def_frg = Console.ForegroundColor;
            Console.BackgroundColor = bkg;
            Console.ForegroundColor = frg;
            Console.Write(s);
            Console.BackgroundColor = def_bkg;
            Console.ForegroundColor = def_frg;
        }
        public static void Patienter(int n)
        {
            string s;
            Console.WriteLine(
                "Merci de patienter autant de fois que nécessaire.");
            for (int i = 0; i < n; i++)
            {
                do
                { s = Console.ReadLine(); }
                while (s != "patienter" && s != "attendre");
                player.time += 5;
                Console.WriteLine(
                    "Vous patientez 5 secondes.");
            }
        }
    }
}
