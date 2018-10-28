using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÉrettségiSegítő
{
    /// <summary>
    /// Olyan mintákat generál autimatikusan, amikkel lehet dolgozni
    /// az érettségihez hasonló feladatokon
    /// </summary>
    public class MunkaMintaKészítő
    {
        private Random random = new Random();
         
        /// <summary>
        /// Készít egy random integerekből álló tömböt
        /// a megadott hosszban.
        /// Az integerek értéke 0 - 999 -ig változik
        /// </summary>
        /// <param name="hossz"></param>
        /// <returns>Tömb mely integereket tartalmaz</returns>
        public int[] SzámsorTömb(int hossz)
        {
            int[] result = new int[hossz];

            for (int i = 0; i < hossz; i++)
            {
                result[i] = random.Next(0, 999);
            }

            return result;
        }

        /// <summary>
        /// Készít egy random integerekből álló Lista típusú
        /// objektumot a paraméterben megadott hosszúságban.
        /// Az integerek értéke 0 - 999 -ig változik
        /// </summary>
        /// <param name="hossz"></param>
        /// <returns>Lista mely integereket tartalmaz</returns>
        public List<int> SzámsorLista(int hossz)
        {
            int[] arr = SzámsorTömb(hossz);
            List<int> result = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                result.Add(arr[i]);
            }

            return result;
        }
    }
}
