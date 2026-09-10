using System;
using System.Collections.Generic;
using Valuta;

var mai = new ValutaValto(360.3d);
Console.WriteLine($"3,5 Euró 360,3 Forintos árfolyammal számolva: {mai.EuroToHuf(3.5d)} Forint");

