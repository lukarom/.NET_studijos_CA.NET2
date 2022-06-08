namespace Paskaita_4_Kintamieji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Kintamieji");
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
            Tuple<int, int, string> tuple = new Tuple<int, int, string>(20, 1500, "Laptop");//iki 7 reiksmiu*/

            /////////////////////////////////////////////////////
            //Pirma uzduotis


            // string mokyklosPavadinimas = "Code Academy";
            // string kursoPavadinimas = ".CA.NET2";
            // int studentuSkaicius = 18;
             var siandienosData = new DateTime(2022, 06, 08);


             //Console.WriteLine($"Mokyklos Pavadinimas: {mokyklosPavadinimas}" +
              //   $"\nKurso Pavadinimas: {kursoPavadinimas}" +
               //  $"\nStudentu Skaicius: {studentuSkaicius}" +
               //  $"\nSiandienos Data: {siandienosData.ToShortDateString()}");*/

            var kursoPradziosData = new DateTime(2022, 05, 30);
            var kursoPabaigosData = new DateTime(2022, 12, 31);

            var kursoTrukme = siandienosData - kursoPradziosData;

            //Antra Uzduotis

            Console.WriteLine("Kurso Pradzios Data: ");
            Console.WriteLine(kursoPradziosData.ToShortDateString());
            Console.WriteLine("Kurso Pabaigos Data: ");
            Console.WriteLine(kursoPabaigosData.ToShortDateString());
            Console.WriteLine("Kurso trukme: ");
            Console.WriteLine(kursoTrukme.TotalDays + " dienu");

            //Trecia uzduotis

            var tekstas = "tekstas";
            var skaitmuo = 34;
            bool loginis = true;

            Console.WriteLine(tekstas + " " + skaitmuo + " " + loginis);
            Console.WriteLine("{0} {1} {2}", tekstas, skaitmuo, loginis);
            Console.WriteLine($"{tekstas} {skaitmuo} {loginis}");

            var skaicius1 = 1;
            var skaicius2 = 2;
            var skaicius3 = 3;

            Console.WriteLine(skaicius1 + " " + skaicius2 + " " + skaicius3);
            Console.WriteLine("{0} {1} {2}", skaicius1, skaicius2, skaicius3);
            Console.WriteLine($"{skaicius1} {skaicius2} {skaicius3}");


        }
    }
}