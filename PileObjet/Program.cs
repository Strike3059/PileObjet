using PileObjet.Tests;
using System;

namespace MesOutils
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestPile.TestPileVide();
                TestPile.TestEmpiler();
                TestPile.TesteEmpilerDepiler();
                // appels des méthodes de tests conversions
                TestPile.TestConversion();
                TestPile.TestConversion(154, 2) ;
                TestPile.TestConversion(11, 16);
                TestPile.TestConversion(2986, 16);
                TestPile.TestConversion(9999, 16);
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
