using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossroadz3
{
    class Trottoir
    {
        static void Messages(int i)
        {
            switch (i)
            {
                case 0:
                    Console.WriteLine(
                        "Vous êtes sur le trottoir.\n" +
                        "Que voulez-vous faire ?");
                    break;
                case 1:
                    Console.WriteLine(
                        "Commande impossible ou non reconnue.");
                    break;
            }
        }
        
        static void Gagner()
        {
            Console.WriteLine(
                "Petit chenapan. Ce serait trop facile s'il suffisait de demander.");
        }
        static void Regarder()
        {
            Console.WriteLine(
                "Vous etes sur le trottoir. Devant vous, la rue.\n"+
                "De l'autre cote, l'autre trottoir. Il y a un feu.\n"+
                "Derrière vous, un magasin général.\n" +
                "Vous avez une veste.");
            if (Program.GetPlayer().pantalon)
                Console.WriteLine(
                    "Vous avez un pantalon.");
            else
                Console.WriteLine(
                    "Vous n'avez pas de pantalon.");
            if (Program.GetPlayer().time >= 14400) //14400 = 4* 3600
                Console.WriteLine(
                    "Une migration de poulets gêne la circulation des voitures.");
        }
        static void Regarder_feu()
        {
            Player.couleurFeu couleur = Program.GetPlayer().GetCouleurFeu();
            switch (couleur)
            {
                case Player.couleurFeu.Bouton_éteint_feu_rouge:
                    Console.WriteLine(
                        "Le feu est rouge pour pietons. Il y a un bouton.");
                    break;
                case Player.couleurFeu.Bouton_éteint_feu_vert:
                    Console.WriteLine(
                        "Le feu est vert pour pietons. Le bouton est parti.");
                    break;
                case Player.couleurFeu.Bouton_allumé_feu_rouge:
                    Console.WriteLine(
                        "Le feu est rouge pour pietons. Il y a un bouton. Le bouton est allume.");
                    break;
                case Player.couleurFeu.Bouton_allumé_feu_vert:
                    Console.WriteLine(
                        "Le feu est vert pour pietons. Le bouton est parti.");
                    break;
                case Player.couleurFeu.Feu_peint:
                    Console.WriteLine(
                        "Le feu est vert pour pietons. Le bouton ne comprend pas. Pauvre bouton.");
                    break;
            }
        }
        static void Regarder_bouton()
        {
            Player.couleurFeu couleur = Program.GetPlayer().GetCouleurFeu();
            switch (couleur)
            {
                case Player.couleurFeu.Bouton_éteint_feu_rouge:
                    Console.WriteLine(
                        "Le bouton est là. Le bouton est éteint.");
                    break;
                case Player.couleurFeu.Bouton_allumé_feu_rouge:
                    Console.WriteLine(
                        "Le bouton est là. Le bouton est allumé.");
                    break;
                case Player.couleurFeu.Bouton_allumé_feu_vert:
                case Player.couleurFeu.Bouton_éteint_feu_vert:
                    Console.WriteLine(
                        "Le bouton est parti ailleurs accomplir sa destinée.");
                    break;
                case Player.couleurFeu.Feu_peint:
                    Console.WriteLine(
                        "Le bouton est là. Il ne sait pas quoi faire. Il panique.");
                    break;
            }
        }
        static void Regarder_pantalon()
        {
            if (Program.GetPlayer().pantalon)
                Console.WriteLine(
                    "Vous remarquez que vous portez un pantalon.");
            else
                Console.WriteLine(
                    "Vous n'avez pas de pantalon. Vous avez les fesses à l'air.");
        }
        static void Regarder_veste()
        {
            Console.WriteLine(
                "Vous avez une veste avec des poches.");
        }
        static void Regarder_poches()
        {
            Console.WriteLine(
                "Vous avez un portable et " + Program.GetPlayer().argent + " euros.");
        }
        static void Argent()
        {
            Console.WriteLine(
                "Vous avez " + Program.GetPlayer().argent + " euros.");
        }
        static void Regarder_tel()
        {
            Console.WriteLine(
                "Ça ressemble à un portable. Vous pouvez l'utiliser.");
        }
        static void Regarder_ame()
        {
            if (Program.GetPlayer().ame)
                Console.WriteLine(
                    "Vous avez une âme.");
            else
                Console.WriteLine(
                    "Vous n'avez pas d'ame.Gagnez votre redemption pour en avoir une.\n" +
                    "La rédemption peut s'obtenir en faisant preuve de générosité.");
        }
        static void Heure()
        {
            int heure = Program.GetPlayer().time;
            Console.WriteLine(
                "Il est " + (heure / 3600 + 12) + 'h'+ (heure%3600/60) +".\n" +
                "Vous cherchez un moyen de traverser depuis midi,\n" +
                "cela fait maintenant " + heure + " secondes.");
        }
        static void Illuminati()
        {
            Program.WriteWithColor(ConsoleColor.Red, ConsoleColor.Yellow,
                "[Exploit legendaire: \"La verite\" accompli !]\n");
            Console.ReadKey();
            Console.Clear();
            Console.Write(
                "Vous saviez ?");
            Console.ReadKey();
            Console.Clear();
            Console.Write(
                "Non... Comment ?...");
            Console.ReadKey();
            Console.Clear();
            Console.Write(
                "Vous en avez trop vu");
            Console.ReadKey();
            Program.Exit();
        }
        static void Reflechir()
        {
            Console.WriteLine(
                "Vous essayez vraiment, mais c'est au-dessus de vos forces.\n" +
                "Vous vous écroulez sur le sol sous l'effort et vous dormez une demi-heure.");
            Program.GetPlayer().time += 1800;
        }
        static void Lire_journal()
        {
            if (Program.GetPlayer().journal)
            {
                Program.WriteWithColor(ConsoleColor.Blue, ConsoleColor.White,
                        "[Exploit: \"S'informer\" accompli !]\n");
                Console.WriteLine(
                    "\n" +
                    "Vous lisez le journal.");
                Program.WriteWithColor(ConsoleColor.Gray, ConsoleColor.Black,
                    "| ------------------------------------ |\n" +
                    "|       * LA GAZETTE DU PIÉTON *       |\n" +
                    "| ------------------------------------ |\n" +
                    "| La banque mise à sac !               |\n" +
                    "|  > Un malfrat cagoulé a réussi à     |\n" +
                    "|    s'échaper avec 1 million d'euros. |\n" +
                    "|    La police est à cran... (voir p2) |\n" +
                    "|                                      |\n" +
                    "| Gare aux poulets !                   |\n" +
                    "|  > Une inexplicable migration de     |\n" +
                    "|    poulets gênera la circulation     |\n" +
                    "|    en ville vers 16h. L'avis des     |\n" +
                    "|    experts en page 6.                |\n" +
                    "|                                      |\n" +
                    "| Sauvez vos âmes                      |\n" +
                    "|  > De plus en plus de gens perdent   |\n" +
                    "|    leur âme lors d'arnaques télé-    |\n" +
                    "|    phoniques. Ne cédez pas à la      |\n" +
                    "|    tentation : n'appelez pas le 666  |\n" +
                    "|                                      |\n");
                if (Program.GetPlayer().mendiant >= 1500)
                    Program.WriteWithColor(ConsoleColor.Gray, ConsoleColor.Black,
                    "|  /!\\ Dernière nouvelle          /!\\  |\n" +
                    "|  > De nombreux témoins affirment     |\n" +
                    "|    avoir vu un SDF qui avait pour    |\n" +
                    "|    habitude de mendier dans le       |\n" +
                    "|    quartier partir soudainement en   |\n" +
                    "|    direction de l'aéroport, marmon-  |\n" +
                    "|    nant, paraît-il, \"j'ai toujours   |\n" +
                    "|    voulu aller à Las Vegas...\"       |\n" +
                    "|                                      |\n");
                Program.WriteWithColor(ConsoleColor.Gray, ConsoleColor.Black,
                    "|_______________page_1_________________|\n");
            }
            else
                Console.WriteLine(
                    "Vous n'avez pas le journal. Il faut l'acheter.");
        }
        static void Acheter_journal()
        {
            if (Program.GetPlayer().journal)
                Console.WriteLine(
                    "Vous avez déjà le journal. Essayez de le lire.");
            else
            {
                if (Program.GetPlayer().argent >= 2)
                {
                    Program.GetPlayer().journal = true;
                    Program.GetPlayer().argent -= 2;
                    Console.WriteLine(
                        "Vous achetez le journal. Cela vous a coûté 2 euros.");
                }
                else
                    Console.WriteLine(
                        "Le journal coûte 2 euros. Vous n'avez pas assez d'argent.");
            }
        }
        static void Traverser()
        {
            Player.couleurFeu couleur = Program.GetPlayer().GetCouleurFeu();
            if (couleur == Player.couleurFeu.Bouton_éteint_feu_rouge || couleur == Player.couleurFeu.Bouton_allumé_feu_rouge)
            {
                Program.WriteWithColor(ConsoleColor.DarkYellow, ConsoleColor.White,
                    "[Accès au menu : \"Jean-Michel pas le temps\"]\n");
                Console.WriteLine(
                    "Vous avancez jusqu'au milieu de la rue.\n" +
                    "Une voiture arrive.");
                Program.currentMenu = Program.rue;
            }
            else
            {
                Console.WriteLine(
                    "Vous traversez la rue.");
                switch (couleur)
                {
                    case Player.couleurFeu.Bouton_éteint_feu_vert:
                        Program.WriteWithColor(ConsoleColor.DarkGreen, ConsoleColor.White,
                            "[Exploit : \"La legalite la plus totale\" accompli !]\n");
                        Program.currentMenu = Program.gameOver;
                        break;
                    case Player.couleurFeu.Bouton_allumé_feu_vert:
                        Program.WriteWithColor(ConsoleColor.DarkGreen, ConsoleColor.White,
                            "[Exploit : \"La legalite la plus totale, version abrégée\" accompli !]\n");
                        Program.currentMenu = Program.gameOver;
                        break;
                    case Player.couleurFeu.Feu_peint:
                        Program.WriteWithColor(ConsoleColor.Red, ConsoleColor.Yellow,
                            "[Exploit legendaire : \"Bien sur que si, c'est vert\" accompli ! ]\n");
                        Program.currentMenu = Program.gameOver;
                        break;
                }
            }
        }
        static void Attendre()
        {
            Console.WriteLine(
                "Vous attendez 5 secondes.");
            Program.GetPlayer().time += 5;
        }
        static void Attendre2()
        {
            Console.WriteLine(
                "Vous attendez 10 longues secondes.");
            Program.GetPlayer().time += 10;
        }
        static void Attendre3()
        {
            Console.WriteLine(
                "Une heure passe.");
            Program.GetPlayer().time += 3600;
        }
        static void Mendier()
        {
            Console.WriteLine(
                "Vous vous asseyez pour mendier.");
            Program.WriteWithColor(ConsoleColor.DarkYellow, ConsoleColor.White,
                "[Accès au menu : \"Une petite piece ?\"]\n");
            Console.WriteLine(
                "(Tapez \"arrêter\" ou \"stop\" pour arrêter de mendier.)");
            Program.currentMenu = Program.en_mendiant;
        }
        static void Appuyer()
        {
            if (Program.GetPlayer().bouton)
                Console.WriteLine(
                    "Le bouton est déjà allumé.");
            else
            {
                Console.WriteLine(
                    "Vous appuyez sur le bouton.");
                Program.WriteWithColor(ConsoleColor.Blue, ConsoleColor.White,
                    "[Exploit : \"Please, don't touch anything\" accompli ! ]\n");
                Program.GetPlayer().bouton = true;
            }
        }
        static void Creuser()
        {
            if (Program.GetPlayer().pelle && Program.GetPlayer().trou < 4)
            {
                switch (Program.GetPlayer().trou)
                {
                    case 0:
                        Console.WriteLine(
                            "Vous commencez à creuser un tunnel.\n" +
                            "Vous prenez une pause. Une heure a passé.\n" +
                            "Le tunnel est encore loin d'être fini.");
                        break;
                    case 1:
                        Console.WriteLine(
                            "Vous poursuivez votre oeuvre.\n" +
                            "Vous prenez une nouvelle pause au bout d'une heure de plus.\n" +
                            "Le tunnel avance bien.");
                        break;
                    case 2:
                        Console.WriteLine(
                            "Vous vous remettez à la tâche.\n" +
                            "Une nouvelle heure, une nouvelle pause.\n" +
                            "Le tunnel est bientôt fini.");
                        break;
                    case 3:
                        Console.WriteLine(
                            "Digging intensifies.\n" +
                            "Vous avez encore passé une heure à creuser.\n" +
                            "Le tunnel est terminé.");
                        break;
                }
                Program.GetPlayer().time += 3600;
                Program.GetPlayer().trou++;
            }
            else
            {
                if (Program.GetPlayer().pelle)
                    UtiliserTunnel();
                else
                    Console.WriteLine(
                        "Vous n'avez pas de pelle pour creuser.");
            }

        }
        static void UtiliserTunnel()
        {
            if (Program.GetPlayer().trou >= 4)
            {
                Console.WriteLine(
                    "Vous émergez du tunnel, de l'autre côté de la rue.");
                Program.WriteWithColor(ConsoleColor.Red, ConsoleColor.Yellow,
                    "[Exploit légendaire : \"C'est trois nains qui vont a la mine...\" accompli !]\n");
                Program.currentMenu = Program.gameOver;
            }
            else
            {
                Console.WriteLine(
                    "Le tunnel n'est pas encore fini.");
            }
        }
        static void RetirerPantalon()
        {
            Console.WriteLine(
                "Vous retirez votre pantalon.");
            Program.GetPlayer().pantalon = false;
        }
        static void Appeler()
        {
            Console.WriteLine(
                "Vous sortez votre portable.");
            Program.WriteWithColor(ConsoleColor.DarkYellow, ConsoleColor.White,
                "[Accès au menu : \"Numérotation en cours\"]\n");
            Program.currentMenu = Program.tel;
        }
        static void Peindre()
        {
            if(Program.GetPlayer().peinture)
            {
                Console.WriteLine(
                    "Vous repeignez le feu des voitures en rouge.\n" +
                    "Plus aucune voiture ne passe.");
                Program.WriteWithColor(ConsoleColor.Blue, ConsoleColor.White,
                    "[Exploit : \"L'artiste en herbe\" accompli !]\n");
                Program.GetPlayer().feu_peint = true;
            }
            else
                Console.WriteLine(
                    "Vous n'avez pas de peinture");
        }
        static void Don()
        {
            if (Program.GetPlayer().mendiant < 1500)
            {
                Console.WriteLine(
                    "Combien d'argent donnez-vous au mendiant ?");
                string s;
                float x = -1;
                while (x < 0)
                {
                    s = Console.ReadLine();
                    try { x = (float)Convert.ToDouble(s); }
                    catch
                    {
                        x = -1;
                        Console.WriteLine(
                            "Don impossible. Entrez une valeur numérique réelle positive ou nulle.");
                    }
                }
                if (Program.GetPlayer().argent < x)
                    Console.WriteLine(
                        "Vous n'avez pas assez d'argent.");
                else
                {
                    Console.WriteLine(
                        "Vous donnez " + x + " euros au mendiant.");
                    if (x >= 500)
                    {
                        Console.WriteLine(
                            "Votre don est très généreux. De quoi gagner sa rédemption !");
                        Program.GetPlayer().ame = true;
                    }
                    Program.GetPlayer().argent -= x;
                    Program.GetPlayer().mendiant += x;
                }
            }
            else
            {
                Console.WriteLine(
                    "Il n'y a plus de mendiant.");
            }
            if(Program.GetPlayer().mendiant >= 1500)
            {
                Console.WriteLine(
                    "Le mendiant est devenu riche.\n" +
                    "Manifestement très heureux, il est parti en taxi à l'aéroport.");
                Program.WriteWithColor(ConsoleColor.Red, ConsoleColor.Yellow,
                    "[Exploit legendaire : \"Slumdog millionaire\" accompli !]\n");
            }            
        }
        static void Decret()
        {
            if (Program.GetPlayer().domination)
            {
                Console.WriteLine(
                    "Vous decretez que le feu est vert pour pietons et rouge pour voiture.\n" +
                    "Le monde vous obéit.");
                Program.WriteWithColor(ConsoleColor.Red, ConsoleColor.Yellow,
                    "[Exploit legendaire: \"Par decret... (1/2)\" accompli !]\n");
                Program.GetPlayer().feu_peint = true;
            }
            else
                Console.WriteLine(
                    "Vous n'ête pas le roi du monde.\n" +
                    "Personne ne vous écoute.");
        }
        static void InterdireVoitures()
        {
            if (Program.GetPlayer().domination)
            {
                Console.WriteLine(
                    "Vous interdisez aux voitures de circuler.\n" +
                    "Le monde vous obéit.");
                Program.WriteWithColor(ConsoleColor.Red, ConsoleColor.Yellow,
                    "[Exploit legendaire: \"Par decret... (2/2)\" accompli !]\n");
                Program.GetPlayer().feu_peint = true;
            }
            else
                Console.WriteLine(
                    "Vous n'ête pas le roi du monde.\n" +
                    "Personne ne vous écoute.");
        }
        static void Magasin()
        {
            Console.WriteLine(
                "Vous entrez au magasin général.\n" +
                "\"Bienvenue. Prenez le temps de tout regarder, je vous en prie.\"");
            Program.currentMenu = Program.magasin;
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

            //gagner
            dict.Add("gagner", Gagner);

            //regarder et ses compléments
            dict.Add("regarder", Regarder);
            dict.Add("regarderfeu", Regarder_feu);
            dict.Add("regardercouleurfeu", Regarder_feu);
            dict.Add("regarderbouton", Regarder_bouton);
            dict.Add("regarderpantalon", Regarder_pantalon);
            dict.Add("regarderveste", Regarder_veste);
            dict.Add("regarderpoches", Regarder_poches);
            dict.Add("regarderpoche", Regarder_poches);
            dict.Add("poches", Regarder_poches);
            dict.Add("poche", Regarder_poches);
            dict.Add("regarderargent", Argent);
            dict.Add("regarderportefeuille", Argent);
            dict.Add("regarderporte-monnaie", Argent);
            dict.Add("regarderportemonnaie", Argent);
            dict.Add("argent", Argent);
            dict.Add("regarderame", Regarder_ame);
            dict.Add("ame", Regarder_ame);
            dict.Add("heure", Heure);
            dict.Add("regarderheure", Heure);
            dict.Add("regardertemps", Heure);
            dict.Add("temps", Heure);
            dict.Add("tempspasse", Heure);

            //illuminati
            dict.Add("illuminati", Illuminati);
            dict.Add("toutestlie", Illuminati);
            dict.Add("jesaistout", Illuminati);
            dict.Add("c'estuncomplot", Illuminati);
            dict.Add("complot", Illuminati);

            //réfléchir
            dict.Add("reflechir", Reflechir);
            dict.Add("penser", Reflechir);
            dict.Add("utilisercerveau", Reflechir);

            //journal
            dict.Add("lirejournal", Lire_journal);
            dict.Add("journal", Lire_journal);
            dict.Add("news", Lire_journal);
            dict.Add("s'informer", Lire_journal);
            dict.Add("acheterjournal", Acheter_journal);
            dict.Add("obtenirjournal", Acheter_journal);
            dict.Add("prendrejournal", Acheter_journal);

            //traverser
            dict.Add("avancer", Traverser);
            dict.Add("traverser", Traverser);
            dict.Add("marcher", Traverser);
            dict.Add("passer", Traverser);

            //attendre
            dict.Add("attendre", Attendre);
            dict.Add("patienter", Attendre);
            dict.Add("attendreplus", Attendre2);
            dict.Add("patienterplus", Attendre2);
            dict.Add("attendrelongtemps", Attendre2);
            dict.Add("patienterlongtemps", Attendre2);
            dict.Add("attendrepluslongtemps", Attendre3);
            dict.Add("patienterpluslongtemps", Attendre3);
            dict.Add("attendretreslongtemps", Attendre3);
            dict.Add("patientertreslongtemps", Attendre3);
            dict.Add("attendre1h", Attendre3);
            dict.Add("patienter1h", Attendre3);
            dict.Add("dormir", Attendre3);

            //mendier
            dict.Add("mendier", Mendier);

            //appuyer sur le bouton
            dict.Add("appuyer", Appuyer);
            dict.Add("appuyerbouton", Appuyer);
            dict.Add("appuyersurbouton", Appuyer);
            dict.Add("bouton", Appuyer);

            //creuser
            dict.Add("creuser", Creuser);
            dict.Add("fairetrou", Creuser);
            dict.Add("creusertrou", Creuser);
            dict.Add("fairetunnel", Creuser);
            dict.Add("creusertunnel", Creuser);
            //utiliser tunnel
            dict.Add("passerpartrou", UtiliserTunnel);
            dict.Add("tunnel", UtiliserTunnel);
            dict.Add("utilisertunnel", UtiliserTunnel);
            dict.Add("passerpartunnel", UtiliserTunnel);

            //retirer pantalon
            dict.Add("retirerpantalon", RetirerPantalon);
            dict.Add("enleverpantalon", RetirerPantalon);

            //appeler
            dict.Add("portable", Appeler);
            dict.Add("utiliserportable", Appeler);
            dict.Add("sortirportable", Appeler);
            dict.Add("appeler", Appeler);
            dict.Add("telephone", Appeler);
            dict.Add("composernumero", Appeler);
            dict.Add("tel", Appeler);
            dict.Add("utilisertelephone", Appeler);
            dict.Add("telephoner", Appeler);

            //peindre feu
            dict.Add("peindrefeu",Peindre);
            dict.Add("peindre", Peindre);
            dict.Add("repeindrefeu", Peindre);

            //don
            dict.Add("don", Don);
            dict.Add("donner", Don);
            dict.Add("fairedon", Don);
            dict.Add("donneramendiant", Don);
            dict.Add("donnermendiant", Don);
            dict.Add("donnerargent", Don);

            //décret
            dict.Add("decret", Decret);
            dict.Add("decreterfeuvert", Decret);
            dict.Add("decreterfeurouge", Decret);
            dict.Add("feuvert", Decret);
            dict.Add("feurouge", Decret);

            //interdire voitures
            dict.Add("interdirevoitures", InterdireVoitures);
            dict.Add("stoppervoitures", InterdireVoitures);
            dict.Add("interdirecirculation", InterdireVoitures);
            dict.Add("interromprecirculation", InterdireVoitures);
            dict.Add("arretercirculation", InterdireVoitures);
            dict.Add("arretervoitures", InterdireVoitures);

            //magasin
            dict.Add("magasin", Magasin);
            dict.Add("acheter", Magasin);
            dict.Add("entrerdansmagasin", Magasin);
            dict.Add("alleraumagasin", Magasin);

            return new Menu(dict, Messages);
        }
    }
}
