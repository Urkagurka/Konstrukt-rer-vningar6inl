using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktörerövningar6inl
{
    class Fordon
    {
        public string tillvärkare;
        public string modell;
        public int år;
        public int vikt;

        public Fordon(string tillv, string mod, int å, int vi)
        {
            tillvärkare = tillv;
            modell = mod;
            år = å;
            vikt = vi;
        }

        public override string ToString()
        {
            return tillvärkare + " " + modell + " " + år + " " + vikt;
        }
    }
}
