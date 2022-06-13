namespace Paskaita_5_Variable_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, tipu konversijos");
            //dabar dirbame su implicit casting
            int skaiciusInt = 100;
            long skaiciusLong = 100;
            long castintasLong = (long)skaiciusInt;
            long castintasLongVienas = skaiciusInt; // tipo konversija daroma automatiskai

            var castintasLongAntras = (long)skaiciusInt; //kompiliatorius pats primeta kintamojo tipa

            byte skaiciusByte = 200;
            int skaiciusInt2 = skaiciusByte;
            long skaiciusLongAntras = skaiciusByte;
            long skaiciusLongTrecias = skaiciusInt2;
            float skaiciusFloat = skaiciusByte;
            float skaiciusFloatAntras = skaiciusInt2;
            float skaiciusFloatTrecias = skaiciusLongAntras;
            double skaiciusDouble = skaiciusByte;
            double skaiciusDouble1 = skaiciusInt2;
            double skaiciusDouble2 = skaiciusLongAntras;
            double skaiciusDouble3 = skaiciusFloatAntras;
            decimal skaiciusDecimal = skaiciusByte;
            // byte -> short -> int -> long -> float -> double -> decimal

            //Explicit cast
            int castintasInt = (int)skaiciusLong;
            //decimal -> double ->float -> long -> int -> char
            float fl = 5.6f;
            int castintasInt1 = (int)fl;
            Console.WriteLine("  i={0}", castintasInt1); //kas po kablelio yra ignoruojama

            char skaiciusRaide = 'a';

            int castintasInt2 = skaiciusRaide;

            Console.WriteLine($" CastintasINT = {castintasInt2}");

            long castintasLong2 = skaiciusRaide;
            Console.WriteLine($" CastintasLong = {castintasLong2}");

            //char -> ushort -> int -> uint -> long -> ulong -> float -> double -> decimal

            long skaiciusLongDidesnis = 3_000_000_000;

            int castintasInt4 = (int)skaiciusLongDidesnis;

            Console.WriteLine($"   castintasInt4={castintasInt4}");

            long skaiciusLongDarDidesnis = long.MaxValue;
            int castintasInt5 = (int)skaiciusLongDarDidesnis;
            Console.WriteLine($"   castintasInt5={castintasInt5}");

            //+++++ Type Conversion Methods

            string konvertuotasString = Convert.ToString(skaiciusInt);

            Console.WriteLine(konvertuotasString);
            string konvertuotasString1 = skaiciusInt.ToString();
            long konvertuotasLong = Convert.ToInt64(skaiciusInt);
            double konvertuotasDouble = Convert.ToDouble(skaiciusInt);
            //int konvertuotasInt = Convert.ToInt32(konvertuotasLong); //Luzte nes netelpa

            // Darbas su NULL tipais
            int? skaiciusIntNull = null;//rasomas klaustukas, kad gali buti irasytas null
            //long castintasLong5 = (long)skaiciusIntNull;//luzta

            long konvertuotasLong1 = Convert.ToInt64(skaiciusIntNull); //programa nenuluzta,
                                                                       //o grazinama long tipo default reiksme            /

            //Parsinimas
            string skaiciusString = "100";
            string skaiciusDidelisString = "99999999999999999999999";
            string tekstas = "tekstas";
            int skaiciusIntParsintas = int.Parse(skaiciusString);

            Console.WriteLine($" skaiciusStirng + 1 = {skaiciusString + 1}");  //kodel gavome 1001
            Console.WriteLine($" skaiciusIntPrarsintas + 1 = {skaiciusIntParsintas + 1}");

            int tekstasIntParsintas = int.Parse(tekstas);










        }
    }
}