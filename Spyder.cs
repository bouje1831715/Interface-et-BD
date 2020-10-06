using System;
using System.Collections.Generic;
using System.Text;

namespace retour_POO
{
    class Spyder : Moto
    {
        public Spyder(int dureeVieKm_, int autonomieKm_, Moteur moteur_, Roue roue_, string style_, string marque_, string modele_)
        {
            dureeVieKm = dureeVieKm_;
            autonomieKm = autonomieKm_;
            moteur = moteur_;
            roue[0] = roue_;
            roue[1] = roue_;
            style = style_;
            marque = marque_;
            modele = modele_;
        }

        public override void TournerSerrer()
        {
            Console.WriteLine("Pour faire le tournant serré, vous avez simplement tourné la direction de la Spyder");
        }
    }
}
