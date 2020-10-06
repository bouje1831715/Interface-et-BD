using System;
using System.Collections.Generic;
using System.Text;

namespace retour_POO
{
    class Roue
    {
        private int largeur;
        private int pourcentageHauteur;
        private int diametreJante;
        private int indiceCharge;
        private char indiceVitesse;
        public int pression { get; set; }
        private string type;

        public Roue(int largeur_, int pourcentageHauteur_, int diametreJante_, int indiceCharge_, char indiceVitesse_, int pression_, string type_)
        {
            largeur = largeur_;
            pourcentageHauteur = pourcentageHauteur_;
            diametreJante = diametreJante_;
            indiceCharge = indiceCharge_;
            indiceVitesse = indiceVitesse_;
            pression = pression_;
            type = type_;

        }

        public void GonflerPneu(int x)
        {
            pression = pression + x;
        }

    }
}
