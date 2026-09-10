using Bankszamla;

var peldany = new Bankszamlak();
Console.WriteLine("Válassza ki a tranzakciót!\nBefizetés [B], Kifizetés [K]");
string valasz = Console.ReadLine();
if(valasz == "B")
{
    Console.Write("Kérem a befizetni kívánt összeget:");
    double be = Convert.ToDouble(Console.ReadLine());
    peldany.Befizetes(be);
}
else
{
    Console.Write("Kérem a kifizetni kívánt összeget:");
    double ki = Convert.ToDouble(Console.ReadLine());
    peldany.Kifizetes(ki);
}
