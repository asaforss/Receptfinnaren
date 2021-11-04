using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Receptfinnaren
{
    public class Efterrätt:Maträtt
    {
          public Efterrätt(string namn, int tid, string ställe, System.Drawing.Image bild, bool sött)
            :base(namn,tid,ställe,bild)
        {
            this.sött = sött;
        }
        public bool sött { get; set; }
    }
}
