using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramozasiTetelek
{
    /// <summary>
    /// Annak eldöntése, hogy egy „n” elemű sorozat (tömb, lista…) elemei között van-e olyan, 
    /// ami megfelel a megadott
    /// feltételnek(a kódban a Feltétel szó jelöli).
    /// </summary>
    public class Eldontes
    {
        /// <summary>
        /// Megadja, hogy hányszor futott le a ciklus
        /// mire kiértékelhető eredményre jutott
        /// </summary>
        public int CikusFutasSzama { get; set; }

        public bool Operation(List<int> numbers, Func<int, bool> feltetel)
        {
            // megadja hogy hol tartunk eppen a ciklusban
            // lefutasonkent +1 et hozzaadunk az ertekehez
            int i = 1;

            // a ciklus csak addig fut amíg meg nem találja az első olyan elemet
            // ami igaz a feltétel alapján, a program teljesítménye alapján ez az optimális           
            while (i < numbers.Count && ! feltetel(numbers[i]))
            {
                bool res = feltetel(numbers[i]);
                int num = numbers[i];
                i++;
            }

            // átadja az osztály szintű property nek a ciklusok futásszámát
            CikusFutasSzama = i;

            if (i < numbers.Count)
                return true;
            else
                return false;           
        }
    }
}
