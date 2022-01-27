using PileObjet.Tests;
using System;
using PileObjet.Utilitaires;
using Utilitaires;

namespace MesOutils
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //TestPile.TestPileVide();
                //TestPile.TestEmpiler();
                //TestPile.TesteEmpilerDepiler();
                //// appels des méthodes de tests conversions
                //TestPile.TestConversion();
                //TestPile.TestConversion(154, 2) ;
                //TestPile.TestConversion(11, 16);
                //TestPile.TestConversion(2986, 16);
                //TestPile.TestConversion(9999, 16);
                String phrase = UtilitaireAPI.RecupereLoremIpsum(3);
                Console.WriteLine("-----------------------------");
                Console.WriteLine("phrase : ");
                Console.WriteLine(phrase);
                String phraseInversee = UtilitaireConsole.InversePhraseMieux(phrase);
                Console.WriteLine("\n phrase inversée : ");
                Console.WriteLine(phraseInversee);
                Console.WriteLine("-----------------------------");
                TestPile.TesteInversePhrase();

                //Console.WriteLine(TestPile.InversePhrase("salut comment tu vas !"));
                //Console.WriteLine(UtilitaireConsole.InversePhraseMieux("salut comment tu vas !"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Fin du programme");
            Console.ReadKey();
        }
    }
}
