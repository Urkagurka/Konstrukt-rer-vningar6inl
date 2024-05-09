using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktörerövningar6inl
{
    class Fordonslista
    {
        private List<Fordon> listafordon;
        public Fordonslista() 
        {
            listafordon = new List<Fordon>();
        }

        public void addfordon(Fordon F)
        {
            listafordon.Add(F);
        }
        public void addfordon(string tillv, string mod, int å, int vi)
        {
            addfordon(new Fordon(tillv, mod, å, vi));
        }

        public void skrivut()
        {
            foreach(var f in listafordon)
            {
                Console.WriteLine(f);
            }
        }
    }
}
