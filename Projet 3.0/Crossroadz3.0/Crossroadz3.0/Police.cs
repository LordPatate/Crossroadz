using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossroadz3
{
    class Police
    {
        static void Messages(int i)
        {
            switch (i)
            {
                case 0:
                    Console.WriteLine(
                        "Comment réagissez-vous face aux policiers ?");
                    break;
                case 1:
                    Console.WriteLine(
                        "Commande non reconnue (ou impossible quand on doit agir face à des policiers" +
                        "en colère).");
                    break;
                case 2:
                    Console.WriteLine(
                        "Vous avez très peu de temps avant que les policiers de reviennent à eux.\n" +
                        "Que faites-vous ?");
                    break;
            }
        }

        static void Frapper()
        {
            if (!Program.currentMenu.mode_alternatif)
            {
                if (Program.GetPlayer().pelle)
                {
                    Program.WriteWithColor(ConsoleColor.Blue, ConsoleColor.White,
                        "[Exploit : 'Brutalites policieres' accompli !]\n");
                    Console.WriteLine(
                        "Avec un grand coup de pelle circulaire, vous mettez à terre les deux policiers.\n" +
                        "Ils seront de nouveau sur pied et très énervés dans un instant, mais ces \n" +
                        "quelques secondes seront peut-être suffisantes...");
                    Program.currentMenu.mode_alternatif = true;
                }
                else
                {
                    Program.WriteWithColor(ConsoleColor.DarkRed, ConsoleColor.White,
                        "[Exploit : 'Brutalites policieres' accompli !]\n");
                    Console.WriteLine(
                        "Votre poing frappe la mâchoire du policier le plus proche de vous.\n" +
                        "Se remettant vite de leur surprise, ses collègues vous neutralisent rapidement.\n" +
                        "Vous êtes en état d'arrestation.");
                    Program.currentMenu = Program.gameOver;
                }
            }
            else
            {
                Console.WriteLine(
                    "On ne frappe pas un homme à terre.");
            }
        }
        static void Corrompre()
        {
            if(!Program.currentMenu.mode_alternatif)
            {
                if (Program.GetPlayer().argent >= 10)
                {
                    Console.WriteLine(
                        "Vous montrez votre argent aux policiers.\n" +
                        "\"Bon... On ferme les yeux sur cette fois. Mais ne vous avisez pas de recom-\n" +
                        " mencer !\"\n" +
                        "Vous leur avez donné tout votre argent.\n" +
                        "La brigade d'intervention s'en va.");
                    Program.GetPlayer().argent = 0;
                    Program.currentMenu = Program.trottoir;
                }
                else
                {
                    Console.WriteLine(
                        "\"Quoi ? C'est avec ça que tu comptes nous acheter ?\n" +
                        "\"Du calme, Roger. Vous, on vous arrête pour tentative de corruption.\"");
                    Program.currentMenu = Program.gameOver;
                }
            }
            else
            {
                Console.WriteLine(
                    "Peine perdue : vous n'aurez pas le temps de parler quand ils seront réveillés.\n" +
                    "La première chose qu'ils feront sera de vous arrêter. Trouvez autre chose.");
            }
        }
        static void Regarder()
        {
            if (!Program.currentMenu.mode_alternatif)
                Console.WriteLine(
                    "Vous êtes face-à-face avec une brigade spéciale d'intervention énervée.\n" +
                    "Leur voiture est garée, encore ouverte, juste à côté.\n" +
                    "Vos options sont limitées. Tenter de vous expliquer ne servira à rien.\n" +
                    "Vous devez trouver un moyen de les calmer ou de vous débarrasser d'eux... ou \n" +
                    "bien faire quelque chose d'à la fois stupide et spectaculaire.");
            else
                Console.WriteLine(
                    "La brigade spéciale d'intervention est assommée à vos pieds.\n" +
                    "L'effet n'est que temporaire et les choses vont bientôt mal tourner.\n" +
                    "Si vous aviez un plan, il a intérêt à être bon...");
        }
        static void VolerVoiture()
        {
            if (Program.currentMenu.mode_alternatif)
            {
                Console.WriteLine(
                    "Vous profitez de l'égarement comateux des policiers pour sauter dans leur\n" +
                    "voiture. Vous démarrez au quart de tour et...\n" +
                    "Bravo ! Vous avez traversé la rue. Vous allez probablement mourir, mais ce\n" +
                    "n'est pas l'important, n'est-ce pas ?");
                Program.WriteWithColor(ConsoleColor.Red, ConsoleColor.Yellow,
                    "[Exploit légendaire : \"Je vous l'emprunte\" accompli !]\n");
                Program.currentMenu = Program.gameOver;
            }
            else
            {
                Console.WriteLine(
                    "Vous avez beau être rapide, les policiers ne se laissent pas voler leur\n" +
                    "voiture si facilement. Vous êtes en état d'arrestation, bien entendu.\n" +
                    "La prochaine fois, arrangez-vous pour qu'ils ne puissent pas vous en empêcher.");
                Program.currentMenu = Program.gameOver;
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

            //frapper
            dict.Add("frapper", Frapper);
            dict.Add("attaquer", Frapper);
            dict.Add("taper", Frapper);
            dict.Add("cogner", Frapper);
            dict.Add("frapperpolicier", Frapper);
            dict.Add("attaquerpolicier", Frapper);
            dict.Add("taperpolicier", Frapper);
            dict.Add("cognerpolicier", Frapper);
            dict.Add("frapperpoliciers", Frapper);
            dict.Add("attaquerpoliciers", Frapper);
            dict.Add("taperpoliciers", Frapper);
            dict.Add("cognerpoliciers", Frapper);
            dict.Add("fucklapolice", Frapper);

            //corrompre
            dict.Add("corrompre", Corrompre);
            dict.Add("acheter", Corrompre);
            dict.Add("corromprepolicier", Corrompre);
            dict.Add("acheterpolicier", Corrompre);
            dict.Add("corromprepoliciers", Corrompre);
            dict.Add("acheterpoliciers", Corrompre);
            dict.Add("donnerargent", Corrompre);
            dict.Add("offrirargent", Corrompre);
            dict.Add("argent", Corrompre);
            dict.Add("donner", Corrompre);

            //regarder
            dict.Add("regarder", Regarder);
            dict.Add("regarderpoliciers", Regarder);
            dict.Add("regarderpolicier", Regarder);

            //voler voiture
            dict.Add("volervoiture", VolerVoiture);
            dict.Add("prendrevoiture", VolerVoiture);
            dict.Add("utiliservoiture", VolerVoiture);
            dict.Add("conduirevoiture", VolerVoiture);
            dict.Add("monterdansvoiture", VolerVoiture);

            return new Menu(dict, Messages);
        }
    }
}
