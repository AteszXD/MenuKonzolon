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
            int szulEv = 0;
            string valasz = "";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
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
                    Console.Write("Kérem a nevét: ");
                    nev = Console.ReadLine();

                    Console.Write("Kérem a születési évét: ");
                    szulEv = int.Parse(Console.ReadLine());

                    Console.Write("Kérem a nemét (Férfi/Nő): ");
                    ferfi = Console.ReadLine() == "Férfi";

                    Console.WriteLine("Sikeresen rögzítettük az adatokat. Enterre tovább....");
                    Console.ReadLine();

                } else if (valasz == "2")
                {
                    Console.WriteLine($"A neve: {nev}\n" +
                        $"A neme: {(ferfi ? "Férfi" : "Nő")}\n" +
                        $"A születési éve: {szulEv}");

                    Console.WriteLine("Enterre tovább....");
                    Console.ReadLine();

                } else if (valasz == "3")
                {
                    Console.Beep();
                    Console.WriteLine("Biztosan ki szeretne lépni? (Igen/Nem): ");
                    valasz = Console.ReadLine() != "Igen" ? " " : "3";
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
