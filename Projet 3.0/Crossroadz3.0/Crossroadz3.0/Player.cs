using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossroadz3
{
    class Player
    {
        //booléennes
        public bool jeu { get; set; }
        public bool pantalon { get; set; }
        public bool bouton { get; set; }
        public bool pelle { get; set; }
        public bool ame { get; set; }
        public bool peinture { get; set; }
        public bool feu_peint { get; set; }
        public bool journal { get; set; }
        public bool domination { get; set; }

        //numériques
        public float argent { get; set; }
        public int time { get; set; }
        public float mendiant { get; set; }
        public int trou { get; set; }

        public enum couleurFeu { Bouton_éteint_feu_rouge, Bouton_éteint_feu_vert, Bouton_allumé_feu_rouge, Bouton_allumé_feu_vert, Feu_peint };

        public Player()
        {
            jeu = true;
            pantalon = true;
            bouton = false;
            pelle = false;
            ame = true;
            peinture = false;
            feu_peint = false;
            journal = false;
            domination = false;

            argent = 20;
            time = 0;
            mendiant = 0;
            trou = 0;
        }

        public couleurFeu GetCouleurFeu()
        {
            if (feu_peint)
                return couleurFeu.Feu_peint;
            else
            {
                if (bouton)
                {
                    if (time % 30 <= 15 && time < 14400)
                        return couleurFeu.Bouton_allumé_feu_rouge;
                    else
                        return couleurFeu.Bouton_allumé_feu_vert;
                }
                else
                {
                    if (time % 60 <= 30 && time < 14400)
                        return couleurFeu.Bouton_éteint_feu_rouge;
                    else
                        return couleurFeu.Bouton_éteint_feu_vert;
                }
            }
        
        }
    }
}
