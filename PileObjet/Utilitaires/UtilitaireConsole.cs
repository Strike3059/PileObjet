using MesOutils;
using System;

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pNbAConvertir"></param>
        /// <param name="pNewBase"></param>
        /// <returns></returns>
        public static string Convertir(int pNbAConvertir, Int32 pNewBase)
        {
            if (pNbAConvertir <= 0)
            {
                throw new Exception("Le nombre à convertir doit être strictement positif");
            }
            if (pNewBase < 2 || pNewBase > 16)
            {
                throw new Exception("La nouvelle base doit être comprise entre 2 et 16");
            }

            Pile<int> unePile = new Pile<int>();

            int quot = pNbAConvertir;
            string str = "";
            while (quot != 0)
            {
                unePile.Empiler(quot % pNewBase);
                quot = quot / pNewBase;
            }
            while (!unePile.PileVide())
            {
                //str = str + Convert.ToChar(Depiler(ref unePile2));
                int retour = (int)unePile.Depiler();
                if (retour < 10)
                {
                    str += Convert.ToChar(48 + retour);
                }
                else
                {
                    str += Convert.ToChar(55 + retour);
                }
            }

            return str;
        }

        public static string InversePhraseMieux(String phrase)
        {
            String Retourne = "";
            var tab = phrase.Split(' ');
            foreach (string mot in tab)
            {
                Retourne = " "+mot + Retourne;
            }
            return Retourne;
        }
    }
}
