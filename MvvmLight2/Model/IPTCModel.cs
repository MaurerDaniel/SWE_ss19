using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight2.Model
{
    class IPTCModel
    {
        public string Land { get; private set; }
        public string Ort { get; private set; }
        public string Bundesland { get; private set; }
        public string ISO_Landescode { get; private set; }

        public IPTCModel(string land, string ort, string bundesland, string isoLC)
        {
            Land = land;
            Ort = ort;
            Bundesland = bundesland;
            ISO_Landescode = isoLC;
        }
    }

}

