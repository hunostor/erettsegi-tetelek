using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramozasiTetelek
{
    /// <summary>
    /// Egy „n” elemű sorozatban (tömb, lista…) azon elem sorszámának és értékének a meghatározása, amelyik a
    /// legnagyobb/legkisebb elem az adott sorozatban.
    /// </summary>
    public class KivalasztasMinMax
    {
        /// <summary>
        /// Kiválasztja a tömbből a legnagyobb értékű számot
        /// </summary>
        /// <param name="Array"></param>
        /// <returns>A legnagyobb szám a tömbben</returns>
        public int Max(int[] Array)
        {
            int eredmeny = 0;

            // Elmentjük a sorozat első tagját és ehez fogjuk mérni a többit
            int pointer = Array[0];

            // bejárom a tömböt egy for ciklussal
            for (int i = 0; i < Array.Length; i++)
            {
                // Ha a pointer értéke kisebb mint a cikluselem ahol éppen tartok         
                if (pointer < Array[i])
                {                       
                    // akkor átírom az eredménybe az értéket, mivel ez az eddigi legnagyobb amivel a tömb
                    // bejárása során találkoztam 
                    eredmeny = Array[i];

                    // a pointert is átállítom erre az értékre, hogy a tömb további elemeit
                    // ehez az értékhez hasonlítsa
                    pointer = Array[i];
                }
            }

            return eredmeny;
        }

        /// <summary>
        /// kiválasztja a listából a legnagyobb értékű számot
        /// </summary>
        /// <param name="list"></param>
        /// <returns>A legnagyobb szám a listában</returns>
        public int Max(List<int> list)
        {
            // egy nyelvi környezet adta átalakítása az integerekkel teli lista
            // integerekkel teli tömbbé, sokkal egyszerűbben, mint a Osszegzes tételénél
            int[] arr = list.ToArray();
            return Max(arr);
        }
    }
}
