
Console.WriteLine("Hello, uzduotis!");

Console.WriteLine("▓▓▓▓▓▓▓▓▓▓");

Console.WriteLine("Iveskite varda");
string vardas = Convert.ToString(Console.ReadLine());
Console.WriteLine("Iveskite pavarde");
string pavarde = Convert.ToString(Console.ReadLine());
Console.WriteLine("Iveskite asmens koda");
string asmensKodas = Convert.ToString(Console.ReadLine());
Console.WriteLine("Iveskite amziu (neprivaloma)");
int amzius = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Iveskite gimimo data formatu YYYYMMDD (metai,menuo,diena)(neprivaloma)");
var mydate = Convert.ToString(Console.ReadLine());

DateTime siandienosData = DateTime.Now;
string lytis;
string amziausPatikimumas;

//Lyties nustatatymas pagal asmens koda
if (asmensKodas.Substring(0,1).Equals("1") || asmensKodas.Substring(0,1).Equals("3") || asmensKodas.Substring(0, 1).Equals("5"))
{
    lytis = "Vyras";

}
else if (asmensKodas.Substring(0, 1).Equals("2") || asmensKodas.Substring(0, 1).Equals("4") || asmensKodas.Substring(0, 1).Equals("6"))
{
    lytis = "Moteris";

}
else
{
    lytis = "Netinkamas asmens kodas";
}

//amziaus patikimumo patikrinimas

if (Convert.ToString(amzius) != "" && Convert.ToString(mydate) == "")
{

}
else if(Convert.ToString(amzius) == "" && Convert.ToString(mydate) != "")
{

}
else if(Convert.ToString(amzius) != "" && Convert.ToString(mydate) != "")
{

}




    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ATASKAITA APIE ASMENI▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓{siandienosData.ToString("yyyy-MM-dd"),10}▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓ Vardas, Pavarde ▓▓▓▓▓▓▓▓▓▓▓ {vardas} {pavarde} ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓ Lytis ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓{lytis}▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓ Asmens Kodas ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓{asmensKodas}▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓ Amzius ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓{amzius}▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓ Gimimo data▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓{mydate}▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓ Amziaus patikimumas ▓▓▓▓▓▓▓▓▓▓▓▓▓▓{amziausPatikimumas}▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");