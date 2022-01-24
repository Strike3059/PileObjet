using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            } catch(Exception ex)
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
    }
}
