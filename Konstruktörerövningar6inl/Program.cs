using Konstruktörerövningar6inl;
using System;

namespace Konstruktorerövningar6inl
{
    class Program
    {
        static void Main(string[] args)
        {
            Fordonslista fordonslista = new Fordonslista();
            fordonslista.addfordon("Mazda", "Cosmo", 1983, 1150);
            fordonslista.addfordon("Toyota", "Chaser", 1989, 1280);

            fordonslista.skrivut();
        }
    }
}