using System;
using System.Collections.Generic;
using System.Text;

namespace Jatekosok
{
    internal class Jatekos
    {
        private int elet;
        public string Nev { get; set; }
        public int Elet
        {
            get;
            set {
                if (value < 0) elet = 0;
                else if (value > 100) elet = 100;
                else elet = value;
                }
        }
    }
}
