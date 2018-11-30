using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramozasiTetelek
{
    /// <summary>
    /// Végigmegy egy sorozaton (tömb, lista…), és ha a szomszédos elemeknél rossz a sorrend, akkor megcseréli őket. (ez a
    /// csere, mint egy buborék végighalad a tömbön, és a legnagyobb elem, biztosan a tömb végére kerül
    /// </summary>
    public class BuborekosRendezes
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rendezetlenLista"></param>
        /// <returns></returns>
        public List<int> Rendezes(List<int> rendezetlenLista)
        {
            List<int> rendezett;
            // Lefele szamoltatjuk a ciklus pointert
            for (int i = rendezetlenLista.Count -1; i > 1; i--)
            {
                // Ezért volt értelme az i -t lefelé számoltatni
                // most lehet olyan feltetelünk, hogy a addig fusson míg a j kisebb mint
                // az i
                for (int j = 0; j < i; j++)
                {
                    // Itt képződik a "buborék" ha az utánna következő érték nagyobb a sorban
                    // akkor elkezdődik a vándorlás, az elemek megcserélődnek
                    if(rendezetlenLista[j] > rendezetlenLista[j + 1])
                    {
                        int atmenetiTarolo = rendezetlenLista[j];
                        rendezetlenLista[j] = rendezetlenLista[j + 1];
                        rendezetlenLista[j + 1] = atmenetiTarolo;
                    }
                }
            }

            rendezett = rendezetlenLista;
            return rendezett;
        }
    }
}
