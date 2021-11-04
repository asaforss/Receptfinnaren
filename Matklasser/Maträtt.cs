using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Receptfinnaren
{
     public abstract class Maträtt
    {
      
        /// <summary>
        /// Konstruktor med 4 parametrar
        /// </summary>
        /// <param name="namn"></param>
        /// <param name="tid"></param>
        /// <param name="ställe"></param>
        /// <param name="bild"></param>
        public Maträtt(string namn, int tid, string ställe, Image bild)
        {
            this.namn = namn;
            tidsåtgång = tid;
            receptställe = ställe;
            this.bild = bild;
            id = new Guid();
            id = Guid.NewGuid();
        }

        public string namn { get; set; }
        public int tidsåtgång { get; set; }
        public string receptställe { get; set; }
        public Image bild { get; set; }
        public Guid id { get; set; }

    }
}
