using System;
using System.Collections.Generic;
using System.Text;

namespace Bankszamla
{
    internal class Bankszamlak
    {
        private double egyenleg = 15250d;
        public void Befizetes(double osszeg)
        {
            if(osszeg > 0)
            {
                egyenleg += osszeg;
                Console.WriteLine($"Befizetés: {osszeg} Forint\nÚj egyenleg: {egyenleg} Forint");
            }
            else
            {
                Console.WriteLine("A befizetés összege nem lehet negatív!");
            }
        }
        public void Kifizetes(double osszeg)
        {
            if(osszeg > 0 && osszeg <= egyenleg)
            {
                egyenleg -= osszeg;
                Console.WriteLine($"Kifizetés: {osszeg} Forint\nÚj egyenleg: {egyenleg} Forint");
            }
            else
            {
                Console.WriteLine("A kifizetés összege nem lehet negatív, vagy nagyobb, mint a számla egyenlege!");
            }
        }
    }
}
