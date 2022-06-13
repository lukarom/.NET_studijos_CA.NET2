namespace Paskaita_5_Uzdaviniai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           // Console.WriteLine(" Prasau iveskite 2 skaicius:");
          //  string pirmasSkaicius = Console.ReadLine();
          //  Console.WriteLine(" Pirmas skaicius" + pirmasSkaicius);
           // string antrasSkaicius = Console.ReadLine();
           // Console.WriteLine(" Antras skaicius" + antrasSkaicius);

           // Console.WriteLine(" Skaiciu suma: " + int.Parse(pirmasSkaicius) + int.Parse(antrasSkaicius));
           // Console.WriteLine($" Skaiciu skirtumas: {int.Parse(pirmasSkaicius)- int.Parse(antrasSkaicius)}");
            //Console.WriteLine($" Skaiciu DAUGYBA: {int.Parse(pirmasSkaicius) * int.Parse(antrasSkaicius)}");
           // Console.WriteLine($" Skaiciu DALYBA: {(double)int.Parse(pirmasSkaicius) / int.Parse(antrasSkaicius)}");

            Console.WriteLine("Iveskite tris skaicius: ");
            int skaicius1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Pirmas skaicius: {skaicius1} ");
            int skaicius2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Antras skaicius: {skaicius2}");
            int skaicius3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Trecias skaicius: {skaicius3}");

            Console.WriteLine($"Triju skaiciu vidurkis: {(double)(skaicius1 + skaicius2 + skaicius3) / 3}");

        }
    }
}