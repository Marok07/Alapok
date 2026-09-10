using System;
using System.Collections.Generic;
using Autok;


class Program
{
    static void Main(string[] args)
    {
        Auto auto1 = new Auto("Mercedes-Benz", 27);
        Auto auto2 = new Auto("Honda", 3);
        Console.WriteLine($"Márka: {auto1.Marka}, Életkor: {auto1.Eletkor}");
        Console.WriteLine($"Márka: {auto2.Marka}, Életkor: {auto2.Eletkor}");
    }
}
