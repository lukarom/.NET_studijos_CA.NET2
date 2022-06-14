namespace Paskaita_6_Reliaciniai_Operatoriai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Reliaciniai operatoriai!");

            //Reliaciniai operatoria == != > < >= <=
            var skaicius = 10;
            var nelyginisSkaicius = 5;
            var lyginisSkaicius = 10;
            Console.WriteLine(" == patikrina ar kintamieji yra lygus");
            Console.WriteLine($" {skaicius}=={lyginisSkaicius} yra {skaicius == lyginisSkaicius}");
            bool ar10yraLygu5 = skaicius == nelyginisSkaicius;
            Console.WriteLine($" {skaicius}=={nelyginisSkaicius} yra {ar10yraLygu5}");
            Console.WriteLine(" -------------------------------------------");

            Console.WriteLine(" != patikrina ar kintamieji yra lygus");
            Console.WriteLine($" {skaicius}!={lyginisSkaicius} yra {skaicius != lyginisSkaicius}");
            Console.WriteLine(" -------------------------------------------");
            Console.WriteLine(" > patikrina ar kaireje esanti reiksme yra didesne uz desineje esanto");
            Console.WriteLine($" {skaicius}>{nelyginisSkaicius} yra {skaicius > nelyginisSkaicius}");
            Console.WriteLine(" -------------------------------------------");
            Console.WriteLine(" < patikrina ar kaireje esanti reiksme yra mazesne uz desineje esanto");
            Console.WriteLine($" {skaicius}<{nelyginisSkaicius} yra {skaicius < nelyginisSkaicius}");




        }
    }
}