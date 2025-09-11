using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuKonzolon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nev = "";
            bool ferfi = true;
            int szulEv;
            string valasz = "";
            do
            {
                Console.Clear();
                Console.Title = "Személyes adatok kezelése";
                Console.WriteLine("1 - Személyes adatok bevitele");
                Console.WriteLine("2 - Személyes adatok kiírása");
                Console.WriteLine("3 - Kilépés");

                Console.WriteLine("A megfelelő menüpont számával választhat");
                valasz = Console.ReadLine();

                // If végiglépés

                if (valasz == "1")
                {
                    
                    Console.WriteLine("Sikeresen rögzítettük az adatokat. Enterre tovább....");
                    Console.ReadLine();
                } else if (valasz == "2")
                {

                } else if (valasz == "3")
                {
                    
                }
                else
                {
                    Console.WriteLine("Nem létező menüpont, kérem válasszon újra!");
                }
            }
            while (valasz != "3");
        }
    }
}
