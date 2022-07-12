// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//TrecioSprendimoApskaiciavimas();
SlaptazodzioSimuliacija();

//static void TrecioSprendimoApskaiciavimas()
//{
//    int suma = 0;
//    int ivestis = 0;

//    do
//    {
//        suma += ivestis;
//        Console.WriteLine(ivestis);
//        ivestis = Convert.ToInt32(Console.ReadLine());

//    } while (ivestis > 0);
//    Console.WriteLine($"Suma: {suma}");

//}

static void SlaptazodzioSimuliacija()
{
    Console.WriteLine("nustatykite slaptazodi");
    string slaptazodisPirmas = Convert.ToString(Console.ReadLine());
    Console.WriteLine("pakartokite slaptazodi");
    string slaptazodisAntras = Convert.ToString(Console.ReadLine());
    while (slaptazodisPirmas != slaptazodisAntras)
    {
        
        Console.WriteLine("neteisingas slaptazodis, bandykite dar karta");
        SlaptazodzioSimuliacija();
    }
    Console.WriteLine("Sveikinam! Prisijungete");


}
