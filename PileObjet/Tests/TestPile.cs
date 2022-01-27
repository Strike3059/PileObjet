using MesOutils;
using System;
using Utilitaires;

namespace PileObjet.Tests
{
    internal abstract class TestPile
    {
        public static void TestPileVide()
        {
            Pile<int> unePile = new Pile<int>();
            if (unePile.PileVide())
            {
                Console.WriteLine("La pile est vide");
            }
            else
            {
                Console.WriteLine("La pile n'est pas vide");
            }

            //if (unePile.PilePleine())
            //{
            //    Console.WriteLine("La pile est pleine");
            //}
            //else
            //{
            //    Console.WriteLine("La pile n'est pas pleine");
            //}

        }

        public static void TestEmpiler()
        {
            Pile<int> unePile = new Pile<int>();
            unePile.Empiler(2);
            unePile.Empiler(14);
            unePile.Empiler(6);
        }

        public static void TesteEmpilerDepiler()
        {
            try
            {
                Pile<int> unePile = new Pile<int>();
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
                valeurDepilee = (int)unePile.Depiler();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        ///

        public static void TestConversion(int nbAConvertir, int newBase)
        {
            try
            {
                Console.WriteLine(UtilitaireConsole.Convertir(nbAConvertir, newBase));
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void TestConversion()
        {
            Console.Write("Entrez le nombre à convertir : ");
            int nbConvert = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez la nouvelle base entre 2 et 16 : ");
            int nbBase = Convert.ToInt32(Console.ReadLine());
            TestConversion(nbConvert, nbBase);
        }
    }
}
