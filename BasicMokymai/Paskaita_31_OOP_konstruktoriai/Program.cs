namespace Paskaita_31_OOP_konstruktoriai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello, OOP konstruktoriai!");

            var klientas1 = new Customer();
            Console.WriteLine($"Kliento1 vardas: {klientas1.Vardas}");
            klientas1.Vardas = "Benas";
            Console.WriteLine($"Kliento1 vardas: {klientas1.Vardas}");
            Customer klientas2 = new Customer
            {
                Vardas = "Ieva"
            };
            Console.WriteLine($"Kliento2 vardas: {klientas2.Vardas}");
            var klientas3 = new Customer();
            Console.WriteLine($"Kliento3 vardas: {klientas3.Vardas}");
            var klientas4 = new Customer("Romka");
            Console.WriteLine($"Kliento4 vardas: {klientas4.Vardas}");*/



            var ismanusisTelefonas1 = new IsmanusisTelefonas();
            var ismanusisTelefonas2 = new IsmanusisTelefonas("2000", "IOS", "2 mpx", "Apple", "200")
            {
                Dimensija = "4/3",
                Stiklas = "Grudintas",
                Modelis = "Sansun",
                Rezoliucija = "1980x1020"
            };

            var ismanusisTelefonas3 = new IsmanusisTelefonas(ismanusisTelefonas2);
 
            







        }


    }
}