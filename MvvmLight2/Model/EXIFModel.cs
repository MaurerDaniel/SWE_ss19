using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight2.Model
{
    class EXIFModel 
    {
        public int Breite { get; private set; }
        public int Höhe { get; private set; }
        public int HorizontAuflösung { get; private set; }
        public int VertAuflösung { get; private set; }
        public int BildTiefe { get; private set; }
        public int Auflösungseinheit { get; private set; }

        public EXIFModel(int breite, int höhe, int horizontAufl, int vertAufl, int bildTiefe, int auflösEinheit)
        {
            Breite = breite;
            Höhe = höhe;
            HorizontAuflösung = horizontAufl;
            VertAuflösung = vertAufl;
            BildTiefe = bildTiefe;
            Auflösungseinheit = auflösEinheit;
        }
    }

}

