using System;
using System.Collections.Generic;
using System.Text;

namespace Valuta
{
    internal class ValutaValto
    {
        public double Arfolyam;

        public ValutaValto(double Arfolyam)
        {
            this.Arfolyam = Arfolyam;
        }
        public double EuroToHuf(double euro)
        {
            return Arfolyam* euro;
        }
        public static double FixEuroToHuf(double euro)
        {
            return euro*400;
        }
    }
}
