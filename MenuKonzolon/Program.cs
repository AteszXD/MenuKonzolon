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
                Console.SetCursorPosition(Console.WindowWidth/3,0);
                Console.WriteLine("1 - Személyes adatok bevitele");
                Console.SetCursorPosition(Console.WindowWidth / 3, 1);
                Console.WriteLine("2 - Személyes adatok kiírása");
                Console.SetCursorPosition(Console.WindowWidth / 3, 2);
                Console.WriteLine("3 - Kilépés");

                Console.SetCursorPosition(Console.WindowWidth / 3, 3);
                Console.WriteLine("A megfelelő menüpont számával választhat");

                Console.SetCursorPosition(Console.WindowWidth / 3, 4);
                valasz = Console.ReadLine();

                // If végiglépés

                if (valasz == "1")
                {
                    Console.SetCursorPosition(Console.WindowWidth / 3, 4);
                    Console.Write("Kérem a nevét: ");
                    Console.SetCursorPosition(Console.WindowWidth / 3, 5);
                    nev = Console.ReadLine();

                    Console.SetCursorPosition(Console.WindowWidth / 3, 6);
                    Console.Write("Kérem a születési évét: ");
                    Console.SetCursorPosition(Console.WindowWidth / 3, 7);
                    szulEv = int.Parse(Console.ReadLine());

                    Console.SetCursorPosition(Console.WindowWidth / 3, 8);
                    Console.Write("Kérem a nemét (Férfi/Nő): ");
                    Console.SetCursorPosition(Console.WindowWidth / 3, 9);
                    ferfi = Console.ReadLine() == "Férfi";

                    Console.SetCursorPosition(Console.WindowWidth / 3, 10);
                    Console.WriteLine("Sikeresen rögzítettük az adatokat. Enterre tovább....");
                    Console.SetCursorPosition(Console.WindowWidth / 3, 11);
                    Console.ReadLine();

                } else if (valasz == "2")
                {
                    Console.SetCursorPosition(Console.WindowWidth / 3, 4);
                    Console.WriteLine($"A neve: {nev}");
                    Console.SetCursorPosition(Console.WindowWidth / 3, 5);
                    Console.WriteLine($"A neme: {(ferfi ? "Férfi" : "Nő")}");
                    Console.SetCursorPosition(Console.WindowWidth / 3, 6);
                    Console.WriteLine($"A születési éve: {szulEv}");

                    Console.SetCursorPosition(Console.WindowWidth / 3, 7);
                    Console.WriteLine("Enterre tovább....");
                    Console.SetCursorPosition(Console.WindowWidth / 3, 8);
                    Console.ReadLine();

                } else if (valasz == "3")
                {
                    Console.Beep();
                    Console.SetCursorPosition(Console.WindowWidth / 3, 4);
                    Console.WriteLine("Biztosan ki szeretne lépni? (Igen/Nem): ");
                    Console.SetCursorPosition(Console.WindowWidth / 3, 5);
                    valasz = Console.ReadLine() != "Igen" ? " " : "3";
                }
                else
                {
                    Console.SetCursorPosition(Console.WindowWidth / 3, 4);
                    Console.WriteLine("Nem létező menüpont, kérem válasszon újra!");
                    Console.SetCursorPosition(Console.WindowWidth / 3, 5);
                    Console.WriteLine("Enterre tovább....");
                    Console.SetCursorPosition(Console.WindowWidth / 3, 6);
                    Console.ReadLine();
                }
            }
            while (valasz != "3");
        }
    }
}
