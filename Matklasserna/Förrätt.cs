// Åsa Forss  2012-05-18   Receptfinnaren

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Receptfinnaren
{
    /// <summary>
    /// Klass Förätt som ärver Maträtt
    /// </summary>
      [Serializable]
    public class Förrätt:Maträtt
    {
          /// <summary>
          /// Konstruktor med 5 parametrar
          /// </summary>
          /// <param name="namn"></param>
          /// <param name="tid"></param>
          /// <param name="ställe"></param>
          /// <param name="bild"></param>
          /// <param name="kategori"></param>
        public Förrätt(string namn, int tid, string ställe, System.Drawing.Image bild, Kategori kategori)
            :base(namn,tid,ställe,bild)
        {
            this.kategori = kategori;
        }
        /// <summary>
        /// Propertyn kategori
        /// </summary>
        public Kategori kategori { get; set; }
    }
    
}
