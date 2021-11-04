// Åsa Forss  2012-05-18   Receptfinnaren

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Receptfinnaren
{
    /// <summary>
    /// Klassen skapar maträtter
    /// </summary>
    public class Maträttsfabrik

    {
        Maträtt matObj;
        /// <summary>
        /// Metod som skapar huvudrätter och förrätter, överlagrad
        /// </summary>
        /// <param name="namn"></param>
        /// <param name="tid"></param>
        /// <param name="ställe"></param>
        /// <param name="bild"></param>
        /// <param name="kategori"></param>
        /// <param name="mat"></param>
        /// <returns></returns>
        public Maträtt createMat (string namn, int tid, string ställe, System.Drawing.Image bild, Kategori kategori, MatTyp mat)
        {
            if (mat==MatTyp.Huvudrätt)
         
                    matObj = new Huvudrätt(namn,tid, ställe, bild, kategori);
            else
                    matObj = new Förrätt(namn,tid, ställe, bild, kategori);
                  
           
            return matObj; //return the created animal object.

        }
        /// <summary>
        /// Metod som skapar efterrätter, överlagrad
        /// </summary>
        /// <param name="namn"></param>
        /// <param name="tid"></param>
        /// <param name="ställe"></param>
        /// <param name="bild"></param>
        /// <param name="sött"></param>
        /// <returns></returns>
        public Maträtt createMat(string namn, int tid, string ställe, System.Drawing.Image bild, bool sött)
        {

            matObj = new Efterrätt(namn, tid, ställe, bild, sött);
            return matObj;

        }
    }
}
