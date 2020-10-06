using System;
using System.Collections.Generic;
using System.Text;

namespace retour_POO
{
    class Vehicule
    {
        public int dureeVieKm;
        public int autonomieKm;
        public string couleur;
        private int anneeDeProduction;
        public string marque;
        public string modele;

        public virtual void Demarrer()
        {

        }

    }
}
