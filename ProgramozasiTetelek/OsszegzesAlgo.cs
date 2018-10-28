using System;
using System.Collections.Generic;

namespace ProgramozasiTetelek
{
    /// <summary>
    /// Programozási tételekből az összegzés tételére
    /// szolgáltat algoritmusokat
    /// </summary>
    public class OsszegzesAlgo
    {
        /// <summary>
        /// Egy bámilyen hosszúságú integer -ekkel feltöltött
        /// tömbben szereplő értékekeket összeadja
        /// </summary>
        /// <param name="Array"></param>
        /// <returns>A paraméter tömben szereplő számok összege</returns>
        public int Osszegzes(int[] Array)
        {
            int summa = 0;

            foreach(int number in Array)
            {
                summa += number;
            }

            return summa;
        }

        /// <summary>
        /// Egy bámilyen hosszúságú integer -ekkel feltöltött
        /// listában szereplő értékekeket összeadja
        /// </summary>
        /// <param name="list"></param>
        /// <returns>A paraméter listában szereplő számok összege</returns>
        public int Osszegzes(List<int> list)
        {
            int[] arr = Convert(list); // a List típust átalakítom egy tömbbé

            return Osszegzes(arr);
        }

        /// <summary>
        /// Átalakítom a List objetumot Array -á
        /// mivel ez közvetlenül nem tehető meg, tulajdonképpen minden egyes
        /// elemet egymás után kivesz a List -ből és átteszi egy új int[] array -ba.
        /// </summary>
        /// <param name="list"></param>
        /// <returns>Egy tömb amelynek elemei megegyeznek a paraméter List elemeivel</returns>
        private int[] Convert(List<int> list)
        {
            int[] arr = new int[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                arr[i] = list[i];
            }
            return arr;
        }
    }
}
