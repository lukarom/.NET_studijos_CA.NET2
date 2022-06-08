namespace Paskaita_4_Kintamieji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kintamieji");
            //Skaiciu kintamieji
            //Sveiku skaiciu kintamieji
            byte mazasSkaicius = 2; //iki 255 skaiciu
            short trumpasSkaicius = 2; //iki32767
            int skaicius = 2; //2.147.483.647
            int maksimalusIntSkaitmuo = int.MaxValue;

            Console.WriteLine(" " + maksimalusIntSkaitmuo);

            long ilgasSkaicius = 2; //didesnio skaiciaus uz long nera

            int? skaiciusKurisGaliButiNull;

            uint tikTeigiamasSkaicius = 2; //tik teigiami skaiciai
            //tikTeigiamasSkaicius = -5; //taip negalima

            Console.WriteLine("Floating Point Types");

            float maziausiasTrupmeninis = 8.5f;
            var trmpenininisVar = 8.5; //var kintamajam priskiria tipa double;
            var trmpenininisVarFl = 8.5f; //var kintamajam priskiria tipa double;
            double trupmeninis = 8.5;
            decimal didziausiasTrupmeninisTipas = 8.5m;

            //

            float f1 = 0.09f * 100f;
            float f2 = 0.09f * 99.999988f;

            Console.WriteLine("ar f1 > f2? {0}", f1 > f2);
            Console.WriteLine("ar f1 > f2? {0}", f1 < f2);
            Console.WriteLine("ar f1 = f2? {0}", f1 == f2);

            Console.WriteLine("Loginiai kintamieji");
            bool teisybe = true; //reprezentuoja teisybe
            bool neteisybe = false; //reprezentuoja neteisybe
            //bool negali buti null

            bool? nullableLoginis = null;


            Console.WriteLine("char kintamieji");

            char raide = 'h';

            Console.WriteLine("datos kintamieji");
            DateTime siandien = DateTime.Today;

            Console.WriteLine("sudetingesni kintamieji");

            KeyValuePair<int, string> raiktasIrReiksme = new KeyValuePair<int, string>(10, "Laptop");
            Tuple<int, int, string> tuple = new Tuple<int, int, string>(20, 1500, "Laptop");//iki 7 reiksmiu


        }
    }
}