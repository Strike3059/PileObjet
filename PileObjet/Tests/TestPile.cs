using MesOutils;
using PileObjet.Utilitaires;
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
        public static string InversePhrase(String phrase)
        {
            Pile<string> maPile = new Pile<string>();
            var tab = phrase.Split(' ');
            foreach (string mot in tab)
            {
                maPile.Empiler(mot);
            }
            String message = "";
            while (!maPile.PileVide())
            {
                message += " " + maPile.Depiler();
            }
            return message;
        }

        public static void TesteInversePhrase()
        {
            try
            {
                String phrase = UtilitaireAPI.RecupereLoremIpsum(3);
                Console.WriteLine(phrase);
                String phraseInversee = InversePhrase(phrase);
                Console.WriteLine("\n ------ Version Pile ------ ");
                Console.WriteLine(phraseInversee);
                //phraseInversee = InversePhraseMieux(phrase);
                Console.WriteLine("\n ------ Version Améliorée ------ ");
                Console.WriteLine(phraseInversee);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
