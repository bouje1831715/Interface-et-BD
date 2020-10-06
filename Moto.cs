using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace retour_POO
{
    class Moto : Vehicule
    {
        public Moteur moteur;
        public Roue[] roue = new Roue[2];
        public string style;
        public double tailleReservoir;
        public double distanceParcourue;

        //new Moto(100, "Chopper", 30, moteur, roue, "Red", "Harley Davidson", "Street Bob");

        public Moto(int dureeVieKm_, string wtfIsThis_, int autonomieKm_, Moteur moteur_, Roue roue_, string style_, string marque_, string modele_)
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

        public Moto()
        {

        }

        public override void Demarrer()
        {
            if (style == "Red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            if (style == "Yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }

        public void Rouler(int km)
        {
            while(km > 0)
            {
                tailleReservoir = tailleReservoir - moteur.consommationParKm;
                if(tailleReservoir < 0)
                {
                    Console.WriteLine("Vous avez roulé 30 KM. Vous devez faire le plein avant de continuer le voyage");
                    FaireLePlein();
                }
                km = km - 1;
            }
            AjouterUsure(km);
            Console.WriteLine("Le voyage est fini!");
        }

        public void DiminuerPression()
        {
            roue[0].GonflerPneu(-1);
            roue[1].GonflerPneu(-1);
        }

        public void AjouterPression()
        {
            roue[0].GonflerPneu(35);
            roue[1].GonflerPneu(35);
        }

        public void FaireLePlein()
        {
            Console.WriteLine("Le plein est en cours");
            TournerSerrer();
            DiminuerPression();
            tailleReservoir = 30;
            Thread.Sleep(5000);
            Console.WriteLine("Le plein a été fait");
        }

        public virtual void TournerSerrer()
        {
            Console.WriteLine("Vous avez fait un tournant serrer");
        }

        public void AjouterUsure(int km)
        {
            distanceParcourue = distanceParcourue + km;
            if(distanceParcourue >= dureeVieKm)
            {
                Console.WriteLine("Elle risque de vous lacher a nimporte quel moment");
            }
        }
    }
}
