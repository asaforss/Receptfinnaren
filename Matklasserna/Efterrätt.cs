// Åsa Forss  2012-05-18   Receptfinnaren

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Receptfinnaren
{
    /// <summary>
    /// Klassen Efterätt som ärver Maträtt
    /// </summary>
      [Serializable]
    public class Efterrätt:Maträtt
    {
          /// <summary>
          /// Konstruktor med 5 parametrar
          /// </summary>
          /// <param name="namn"></param>
          /// <param name="tid"></param>
          /// <param name="ställe"></param>
          /// <param name="bild"></param>
          /// <param name="sött"></param>
          public Efterrätt(string namn, int tid, string ställe, System.Drawing.Image bild, bool sött)
            :base(namn,tid,ställe,bild)
        {
            this.sött = sött;
        }

        /// <summary>
        /// Property sött
        /// </summary>
        public bool sött { get; set; }
    }
}
