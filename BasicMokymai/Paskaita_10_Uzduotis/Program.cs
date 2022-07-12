
//sukuriame int kintamuosius, kad galetume veliau konvertuoti asmens kodo gimimo metus i pilna metu formata yyyy
int amzius19 = 1800;
int amzius20 = 1900;
int amzius21 = 2000;

//Ivedame varda, pavarde, konvertuojame i string
Console.WriteLine("Iveskite varda");
string vardas = Convert.ToString(Console.ReadLine());
Console.WriteLine("Iveskite pavarde");
string pavarde = Convert.ToString(Console.ReadLine());
//Ivedame asmens koda, taip pat kovertuojame i string
Console.WriteLine("Iveskite asmens koda");
string asmensKodas = Convert.ToString(Console.ReadLine());
Console.WriteLine("Iveskite amziu (neprivaloma)");
//Ivedame arba praleidziame amziu
var amzius = Console.ReadLine();
//Ivedame arba praleidziame gimimo data, prasome ivesti gimimo data atitinkamu formatu
Console.WriteLine("Iveskite gimimo data formatu yyyyMMdd (metai,menuo,diena)(neprivaloma)");
var mydate = Convert.ToString(Console.ReadLine());


//sukuriame siandienos datos kintamaji
DateTime siandienosData = DateTime.Now;
//kovertuojame kintamaji i mum tinkamiausia formata su ToString metodu
var siandienosD = siandienosData.ToString("yyyy-MM-dd");
//Sukuriame amziausPatikimumas kintamaji
string amziausPatikimumas;
//Sukuriame  lytis kintamaji
string lytis = "";
int gimimoMetai; //sukuriame int kintamaji gimimMetai, kad veliau isnaudoti amziaus patikimumo patikrinime
int gimimoMetaiAsmKod = Convert.ToInt32(asmensKodas.Substring(1, 2)); //cia is asmens kodo istraukiame gimimo metu paskutinius du skaitmenis
int siandDataMetai = Convert.ToInt32(siandienosD.Substring(0, 4)); //cia is siandienos dienos istraukiame 4 datos skaitmenis
string gimimoDataAsmKod = "";
string formattedDate = "";
//Asmens kodo patikrinimas pries tolimesnius skaiciavimus

int kontrolinisSk; //sukuriame kontrolinio skaiciaus kintamaji, kad patikrinti ar ivestas asmens kodas yra teisingas


//sukuriame formules pagal wikipedia puslapi pateikta uzduotyje, kad paskaiciuoti pirma ir antra S reiksme
int S = Convert.ToInt32(asmensKodas.Substring(0, 1)) * 1 + Convert.ToInt32(asmensKodas.Substring(1, 1)) * 2 +
    +Convert.ToInt32(asmensKodas.Substring(2, 1)) * 3 + Convert.ToInt32(asmensKodas.Substring(3, 1)) * 4 +
    +Convert.ToInt32(asmensKodas.Substring(4, 1)) * 5 +
    +Convert.ToInt32(asmensKodas.Substring(5, 1)) * 6 + Convert.ToInt32(asmensKodas.Substring(6, 1)) * 7 +
    Convert.ToInt32(asmensKodas.Substring(7, 1)) * 8 + Convert.ToInt32(asmensKodas.Substring(8, 1)) * 9 +
    +Convert.ToInt32(asmensKodas.Substring(9, 1)) * 1;

int S2 = Convert.ToInt32(asmensKodas.Substring(0, 1)) * 3 + Convert.ToInt32(asmensKodas.Substring(1, 1)) * 4 +
    +Convert.ToInt32(asmensKodas.Substring(2, 1)) * 5 + Convert.ToInt32(asmensKodas.Substring(3, 1)) * 6 +
    +Convert.ToInt32(asmensKodas.Substring(4, 1)) * 7 +
    +Convert.ToInt32(asmensKodas.Substring(5, 1)) * 8 + Convert.ToInt32(asmensKodas.Substring(6, 1)) * 9 +
    Convert.ToInt32(asmensKodas.Substring(7, 1)) * 1 + Convert.ToInt32(asmensKodas.Substring(8, 1)) * 2 +
    +Convert.ToInt32(asmensKodas.Substring(9, 1)) * 3;


//pagal if salyga paskaiciuojame kontrolini skaiciu
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

bool kSkPalyginimas = Convert.ToString(kontrolinisSk) == Convert.ToString(asmensKodas.Substring(10, 1));
// Patikrinimas ar kontrolinisSk sutampa su ivesto asmens kodo paskutiniu skaiciumi

if (kSkPalyginimas && asmensKodas.Length == 11)
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
        amzius = "";
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
    asmensKodas = "kodas neteisingas";

}

//---------------------------------------------------
//amziaus patikimumo patikrinimas

//if salyga kuri patikrina ar ivestas amzius ir gimimo data arba nors vienas kintamasis yra ivesti
if (Convert.ToString(amzius) != "" && Convert.ToString(mydate) == "" && kSkPalyginimas && int.TryParse(amzius, out _))
{
    gimimoMetai = siandDataMetai - Convert.ToInt32(amzius); //gauname gimimo metus atimant amzius nuo dabartiniu

    //Console.WriteLine(gimimoMetai);
    // Console.WriteLine(gimimoMetaiAsmKod);
    if (gimimoMetai == gimimoMetaiAsmKod)
    {
        amziausPatikimumas = "amzius patikimas";
    }
    else
    {
        amziausPatikimumas = "amzius pameluotas";
    }
}
else if (Convert.ToString(amzius) == "" && Convert.ToString(mydate) != "" && kSkPalyginimas && int.TryParse(mydate,out _))
{
    gimimoDataAsmKod = gimimoMetaiAsmKod + asmensKodas.Substring(3, 4); //gauname pilna data is asmens kodo yyyyMMdd
    formattedDate = mydate.Insert(4, "-").Insert(7, "-");
    if (gimimoDataAsmKod == mydate)
    {
        amziausPatikimumas = "amzius patikimas";
    }
    else
    {
        amziausPatikimumas = "amzius pameluotas";
    }
}
else if (Convert.ToString(amzius) != "" && Convert.ToString(mydate) != "" && kSkPalyginimas && int.TryParse(amzius, out _) && int.TryParse(mydate,out _)) 
{
    //jeigu ivestas ir amzius ir gimimo data patikriname ar ivesta informacija sutampa su asmens kodo gimimo metais
    
    gimimoMetai = siandDataMetai - Convert.ToInt32(amzius);
    gimimoDataAsmKod = gimimoMetaiAsmKod + asmensKodas.Substring(3, 4);
    //palyginame ar asmens kodo data yra lygi su ivesta data ir jei gimimo metai sutampa su asmens kodo gimimo metais
    //isvedame i amziausPatikimumo laukeli atitinkama atsakyma
    if (gimimoDataAsmKod == mydate && gimimoMetai == gimimoMetaiAsmKod)
    {
        amziausPatikimumas = "amzius tikras";
    }
    else if (gimimoDataAsmKod != mydate && gimimoMetai == gimimoMetaiAsmKod || gimimoDataAsmKod == mydate && gimimoMetai != gimimoMetaiAsmKod)
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

//Formatuojame data jeigu buvo ivesta
if (mydate != "")
{
    formattedDate = mydate.Insert(4, "-").Insert(7, "-");
}
else
{
    formattedDate = "";
}

//Visa informacija isvedama i ekrana

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
Console.WriteLine($"▓ Gimimo data ▓ {formattedDate}               ▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓ Amziaus patikimumas ▓ {amziausPatikimumas}               ▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");