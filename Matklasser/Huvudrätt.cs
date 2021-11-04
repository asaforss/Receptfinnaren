using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Receptfinnaren
{
    public class Huvudrätt:Maträtt
    {
        public Huvudrätt(string namn, int tid, string ställe, System.Drawing.Image bild, Kategori kategori)
            :base(namn,tid,ställe,bild)
        {
            this.kategori = kategori;
        }
        public Kategori kategori { get; set; }
    }
}
