using System;
using System.Collections.Generic;
using System.Text;

namespace retour_POO
{
    class Moteur
    {
        private int taille;
        private int nbCylindres;
        private int puissanceChevaux;
        public double consommationParKm { get; set; }

        public Moteur(int taille_, int nbCylindres_, int puissanceChevaux_,  double consommationParKm_)
        {
            taille = taille_;
            nbCylindres = nbCylindres_;
            puissanceChevaux = puissanceChevaux_;
            consommationParKm = consommationParKm_;
        }

        public void DemarrerMoteur()
        {
            Console.WriteLine("Vroooooom!");
        }
    }
}
