using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitaires
{
    public abstract class UtilitaireConsole
    {
        public static int SaisirNb()
        {
            int nb = 0;
            //do
            //{
                try
                {
                    Console.Write("Veuillez saisir un nombre entier: ");
                    nb = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) { }
            //} while ();
            return nb;
        }
        public static int SaisirNb(int pMin)
        {
            int nb = 0;
            do
            {
                try
                {
                    Console.Write("Veuillez saisir un nombre entier supériuer à " + pMin + " : ");
                    nb = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) { }
            } while (nb < pMin);
            return nb;
        }

        public static int SaisirNb(int pMin, int pMax)
        {
            int nb = 0;
            do
            {
                try
                {
                    Console.Write("Veuillez saisir un nombre entier supériuer à " + pMin + " et inférieur à " + pMax + " : ");
                    nb = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) { }
            } while (nb < pMin && nb > pMax);
            return nb;
        }
    }
}
