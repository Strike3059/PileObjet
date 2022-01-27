using System;
using Utilitaires;
using System.CodeDom;

namespace MesOutils
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //TestPileVidePleine(5);
                //TestPileVidePleine(0);
                //TestEmpiler(5);
                //TestEmpiler(2);

                TesteEmpilerDepiler(5);
                int nbSaisi = UtilitaireConsole.SaisirNb();
                Console.WriteLine("Nombre saisi : " + nbSaisi);
                nbSaisi = UtilitaireConsole.SaisirNb(10);
                Console.WriteLine("Nombre saisi : " + nbSaisi);
                nbSaisi = UtilitaireConsole.SaisirNb(10, 30);
                Console.WriteLine("Nombre saisi : " + nbSaisi);

                //TestConversion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Fin du programme");
            Console.ReadKey();
        }

        static void TestPileVidePleine(int nbElements)
        {
            Pile unePile = new Pile(nbElements);
            if (unePile.PileVide())
            {
                Console.WriteLine("La pile est vide");
            }
            else
            {
                Console.WriteLine("La pile n'est pas vide");
            }

            if (unePile.PilePleine())
            {
                Console.WriteLine("La pile est pleine");
            }
            else
            {
                Console.WriteLine("La pile n'est pas pleine");
            }

        }

        static void TestEmpiler(int nbElements)
        {
            Pile unePile = new Pile(nbElements);
            unePile.Empiler(2);
            unePile.Empiler(14);
            unePile.Empiler(6);
        }

        static void TesteEmpilerDepiler(int nbElements)
        {
            try
            {
                Pile unePile = new Pile(nbElements);
                unePile.Empiler(2);
                unePile.Empiler(22);
                unePile.Empiler(14);
                unePile.Empiler(12);
                unePile.Empiler(5);
                int valeurDepilee = (int)unePile.Depiler();
                Console.WriteLine("valeur dépilée : " + valeurDepilee);
                valeurDepilee = (int)unePile.Depiler();
                valeurDepilee = (int)unePile.Depiler();
                valeurDepilee = (int)unePile.Depiler();
                valeurDepilee = (int)unePile.Depiler();
                //valeurDepilee = (int)unePile.Depiler();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static string Convertir(int pNbElements, int pNbAConvertir, Int32 pNewBase)
        {
            Pile unePile = new Pile(pNbElements);

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

        static void TestConversion()
        {
            Console.Write("Entrez le nombre d'éléments du talbeau : ");
            int nbElem = Int32.Parse(Console.ReadLine());
            Console.Write("Entrez le nombre à convertir : ");
            int nbConvert = Int32.Parse(Console.ReadLine());
            Console.Write("Entrez la nouvelle base entre 2 et 16 : ");
            int nbBase = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Convertir(nbElem, nbConvert, nbBase));
        }
    }
}
