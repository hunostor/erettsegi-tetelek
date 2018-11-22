using ProgramozasiTetelek;
using System;
using System.Collections.Generic;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {
            EldontesTetelEllenorzes();
        }

        private static void EldontesTetelEllenorzes()
        {
            Eldontes eldontes = new Eldontes();
            List<int> sorozat = new List<int>() { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            sorozat = new List<int>() { 44, 43, 45, 546, 34 };
            // sorozat = new List<int>() { 44, 43, 45, 546, 34, 4 };
            // sorozat = new List<int>() { 0, 44, 43, 45, 546, 34 };

            // pelda: van e kisebb eleme a sorozatnak mint 15
            bool result = eldontes.Operation(sorozat, s => { return s <= 15; });

            if (result)
                Console.WriteLine("van kisebb érték a sorozatban, mint 15");
            else
                Console.WriteLine("nincs kisebb érték a sorozatban, mint 15");

            Console.WriteLine($"A ciklus {eldontes.CikusFutasSzama} szer futott le.");

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey(true);
        }
    }
}
