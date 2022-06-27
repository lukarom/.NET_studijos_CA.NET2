
Console.WriteLine("Hello, uzduotis!");

Console.WriteLine("▓▓▓▓▓▓▓▓▓▓");

int amzius19 = 1800;
int amzius20 = 1900;
int amzius21 = 2000;


Console.WriteLine("Iveskite varda");
string vardas = Convert.ToString(Console.ReadLine());
Console.WriteLine("Iveskite pavarde");
string pavarde = Convert.ToString(Console.ReadLine());
Console.WriteLine("Iveskite asmens koda");
string asmensKodas = Convert.ToString(Console.ReadLine());
Console.WriteLine("Iveskite amziu (neprivaloma)");
var amzius = Console.ReadLine();
Console.WriteLine("Iveskite gimimo data formatu YYYYMMDD (metai,menuo,diena)(neprivaloma)");
var mydate = Convert.ToString(Console.ReadLine());
//mydate = mydate.ToString("yyyy-MM-dd");

DateTime siandienosData = DateTime.Now;
var siandienosD = siandienosData.ToString("yyyy-MM-dd");
string lytis = "";
string amziausPatikimumas = "";
int gimimoMetai;
int gimimoMetaiAsmKod = Convert.ToInt32(asmensKodas.Substring(1, 2));
int siandDataMetai = Convert.ToInt32(siandienosD.Substring(0, 4));
//Console.WriteLine(siandDataMetai);

//Console.WriteLine($" {gimimoDataAsmKod} == {mydate} ir {gimimoMetai} == {gimimoMetaiAsmKod}");

//Asmens kodo patikrinimas pries tolimesnius skaiciavimus

int kontrolinisSk;



int S = Convert.ToInt32(asmensKodas.Substring(0, 1)) * 1 + Convert.ToInt32(asmensKodas.Substring(1, 1)) * 2 + 
    + Convert.ToInt32(asmensKodas.Substring(2, 1)) * 3 + Convert.ToInt32(asmensKodas.Substring(3, 1)) * 4 +
    + Convert.ToInt32(asmensKodas.Substring(4, 1)) * 5 + 
    +Convert.ToInt32(asmensKodas.Substring(5, 1)) * 6 + Convert.ToInt32(asmensKodas.Substring(6, 1)) * 7 + 
    Convert.ToInt32(asmensKodas.Substring(7, 1)) * 8 + Convert.ToInt32(asmensKodas.Substring(8, 1)) * 9 +
    +Convert.ToInt32(asmensKodas.Substring(9, 1)) * 1;

int S2 = Convert.ToInt32(asmensKodas.Substring(0, 1)) * 3 + Convert.ToInt32(asmensKodas.Substring(1, 1)) * 4 +
    +Convert.ToInt32(asmensKodas.Substring(2, 1)) * 5 + Convert.ToInt32(asmensKodas.Substring(3, 1)) * 6 +
    +Convert.ToInt32(asmensKodas.Substring(4, 1)) * 7 +
    +Convert.ToInt32(asmensKodas.Substring(5, 1)) * 8 + Convert.ToInt32(asmensKodas.Substring(6, 1)) * 9 +
    Convert.ToInt32(asmensKodas.Substring(7, 1)) * 1 + Convert.ToInt32(asmensKodas.Substring(8, 1)) * 2 +
    +Convert.ToInt32(asmensKodas.Substring(9, 1)) * 3;



if (S % 11 != 10)
{
    kontrolinisSk = S % 11;
}
else if (S2 % 11 != 10)
{
    kontrolinisSk = S2 % 11;
}
else
{
    kontrolinisSk = 0;
}

// Patikrinimas ar kontrolinisSk sutampa su asmens kodo ivedimu

if (kontrolinisSk != 0 && asmensKodas.Length == 11)
{
    //---------------------------------------------------------
    //Gimimo metu pagal asmens koda identifikavimas
    if (asmensKodas.Substring(0, 1).Equals("1") || asmensKodas.Substring(0, 1).Equals("2") && amzius != "")
    {
        gimimoMetaiAsmKod = amzius19 + gimimoMetaiAsmKod;

    }
    else if (asmensKodas.Substring(0, 1).Equals("3") || asmensKodas.Substring(0, 1).Equals("4") && amzius != "")
    {
        gimimoMetaiAsmKod = amzius20 + gimimoMetaiAsmKod;

    }
    else if (asmensKodas.Substring(0, 1).Equals("5") || asmensKodas.Substring(0, 1).Equals("6") && amzius != "")
    {
        gimimoMetaiAsmKod = amzius21 + gimimoMetaiAsmKod;

    }
    else
    {

    }
    //--------------------------------------------------
    //Lyties nustatatymas pagal asmens koda
    if (asmensKodas.Substring(0, 1).Equals("1") || asmensKodas.Substring(0, 1).Equals("3") || asmensKodas.Substring(0, 1).Equals("5"))
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
}
else
{
    asmensKodas = "kodas netesingas";
}

//---------------------------------------------------
//amziaus patikimumo patikrinimas

if (amzius != "")
{

}
else
{
    amzius = "";
}

   
    if (Convert.ToString(amzius) != "" && Convert.ToString(mydate) == "")
    {
    gimimoMetai = siandDataMetai - Convert.ToInt32(amzius);
    string gimimoDataAsmKod = gimimoMetaiAsmKod + asmensKodas.Substring(3, 4);
    Console.WriteLine(gimimoMetai);
        Console.WriteLine(gimimoMetaiAsmKod);
        if (gimimoMetai == gimimoMetaiAsmKod)
        {
            amziausPatikimumas = "amzius patikimas";
        }
        else
        {
            amziausPatikimumas = "amzius pameluotas";
        }
    }
    else if (Convert.ToString(amzius) == "" && Convert.ToString(mydate) != "")
    {
    gimimoMetai = siandDataMetai - Convert.ToInt32(amzius);
    string gimimoDataAsmKod = gimimoMetaiAsmKod + asmensKodas.Substring(3, 4);
    if (gimimoDataAsmKod == mydate)
        {
            amziausPatikimumas = "amzius patikimas";
        }
        else
        {
            amziausPatikimumas = "amzius pameluotas";
        }
        Console.WriteLine("antras");
    }
    else if (Convert.ToString(amzius) != "" && Convert.ToString(mydate) != "")
    {
    gimimoMetai = siandDataMetai - Convert.ToInt32(amzius);
    string gimimoDataAsmKod = gimimoMetaiAsmKod + asmensKodas.Substring(3, 4);
    if (gimimoDataAsmKod == mydate && gimimoMetai == gimimoMetaiAsmKod)
        {
            amziausPatikimumas = "amzius tikras";
        }
        else if (gimimoDataAsmKod != mydate && gimimoMetai == gimimoMetaiAsmKod)
        {
            amziausPatikimumas = "amzius nepatikimas";
        }
        else if (gimimoDataAsmKod == mydate && gimimoMetai != gimimoMetaiAsmKod)
        {
            amziausPatikimumas = "amzius nepatikimas";
        }
        else
        {
            amziausPatikimumas = "amzius pameluotas";
        }
    }
    else
    {
        amziausPatikimumas = "patikimumui truksta duomenu";
    }





Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ATASKAITA APIE ASMENI ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓   {siandienosD,10}   ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓ Vardas, Pavarde ▓ {vardas} {pavarde}             ▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓ Lytis ▓ {lytis}                 ▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓ Asmens Kodas ▓ {asmensKodas}                ▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓ Amzius ▓ {amzius}                 ▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓ Gimimo data ▓ {mydate}                ▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓ Amziaus patikimumas ▓ {amziausPatikimumas}               ▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");