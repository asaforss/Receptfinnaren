// Åsa Forss  2012-05-18   Receptfinnaren

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Receptfinnaren
{
    /// <summary>
    /// Den abstrakta klassen Maträtt
    /// </summary>
      [Serializable]
     public abstract class Maträtt
    {
         
         
         /// <summary>
        /// Konstruktor med 4 parametrar
        /// </summary>
        /// <param name="namn"></param>
        /// <param name="tid"></param>
        /// <param name="ställe"></param>
        /// <param name="bild"></param>
        public Maträtt(string namn, int tid, string ställe, System.Drawing.Image bild)
        {
            this.namn = namn;
            tidsåtgång = tid;
            receptställe = ställe;
            this.bild = bild;
          
        }
          // Properties

        public int IDnr { get; set; }
        public string namn { get; set; }
        public int tidsåtgång { get; set; }
        public string receptställe { get; set; }
        public System.Drawing.Image bild { get; set; }
       

    }
}
