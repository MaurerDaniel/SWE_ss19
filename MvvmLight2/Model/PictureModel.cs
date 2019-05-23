using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight2.Model
{
    class PictureModel
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public FotographerModel Owner { get; private set; }
        public IPTCModel IPTC { get; private set; }
        public EXIFModel EXIF { get; private set; }

        public PictureModel(string name, FotographerModel _owner , IPTCModel _iptc, EXIFModel _exif)
        {
            Name = name;
            Owner = _owner;
            IPTC = _iptc;
            EXIF = _exif;
        }

    }
}
