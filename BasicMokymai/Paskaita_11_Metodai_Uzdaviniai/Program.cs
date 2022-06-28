namespace Paskaita_11_Metodai_Uzdaviniai
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SveikiVisi();
            //LinkiuVisiems();
            //VardoIvedimas();
            //LinkiuJums();
            //Console.WriteLine("Iveskite du skaicius");
            // Console.WriteLine(SkaitmenSkaiciai(Convert.ToString(Console.ReadLine()), Convert.ToString(Console.ReadLine())));
            Console.WriteLine("Iveskite bet koki teksta su tarpais");
            Console.WriteLine($"Tarpu kiekis yra: {TekstasSuTarpais(Convert.ToString(Console.ReadLine()))}");

            //Console.WriteLine("Iveskite sakini su tarpais");
            //Console.WriteLine(ZodziuKiekis(Convert.ToString(Console.ReadLine())));

            //Console.WriteLine("Iveskite betkoki teksta");
            //Console.WriteLine(TarpuKiekisGale(Convert.ToString(Console.ReadLine())));

            //Console.WriteLine("Iveskite betkoki teksta");
            //Console.WriteLine(TarpuKiekisPriekyje(Convert.ToString(Console.ReadLine())));

            Console.WriteLine("Iveskite betkoki teksta");
            TarpaiPriekyjeGale(Convert.ToString(Console.ReadLine()), out int tarpuKiekisGale, out int tarpuKiekisPriekyje);
            Console.WriteLine($"Tarpu kiekis  {tarpuKiekisGale}");
            Console.WriteLine($"Tarpu kiekis priekyje {tarpuKiekisPriekyje}");
        }

      

        static public void SveikiVisi()
        {
            Console.WriteLine("Sveiki Visi!");
        }

        static public void LinkiuVisiems()
        {
            Console.WriteLine("Linkiu Visiems geros dienos");

        }
        //----------------------------------------------------------
        public static string VardoIvedimas()
        {
            var vardas = Console.ReadLine();
            string ivestis = vardas;
            Console.WriteLine("Labas" + vardas);
            return ivestis;
        }

        public static void LinkiuJums()
        {
            Console.WriteLine($"Linkiu Jums {VardoIvedimas()} geros dienos");
        }

        //---------------------------------------------------------------

        public static string SkaitmenSkaiciai(string sk1, string sk2)
        {
            bool sk1IntBool = int.TryParse(sk1, out int sk1Int);
            bool sk2IntBool = int.TryParse(sk2, out int sk2Int);


            if (sk1IntBool && sk2IntBool == true)
            {
                string rezultatas = Convert.ToString(sk1Int + sk2Int);
                return rezultatas;
            }
            else
            {
                string rezultatas = "netinkama ivestis";
                return rezultatas;
            }

        }
        // Uzduotis 4
        public static int TekstasSuTarpais(string tekstasSuTarpais)
        {
            int tarpuSk = tekstasSuTarpais.Count(Char.IsWhiteSpace);
            return tarpuSk;
        }

        // Uzduotis 5  ----------------------------------------------------

        public static int TekstoIlgis(string tekstasSuTarpais)
        {
            int tekstoIlgis = tekstasSuTarpais.Trim().Length;

            return tekstoIlgis;
        }

        // Uzuduotis 6 ------------------------------------------------------------------


        public static int ZodziuKiekis (string tekstasSuTarpais)
        { 
            
            tekstasSuTarpais = tekstasSuTarpais.Trim(' ');

            
            String [] zodziai = tekstasSuTarpais.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int zodziuSkaicius = zodziai.Length;

            return zodziuSkaicius;
        }

        // Uzduotis 7 ----------------------------------------------------------------------

        public static int TarpuKiekisGale (string tekstas)
        {
            int tarpuKiekisGale = tekstas.Length - tekstas.TrimEnd(' ').Length;
            return tarpuKiekisGale;

        }

        // Uzduotis 8 ----------------------------------------------------------------

        public static int TarpuKiekisPriekyje(string tekstas)
        {
            int tarpuKiekisPriekyje = tekstas.Length - tekstas.TrimStart(' ').Length;
            return tarpuKiekisPriekyje;

        }

        // Uzduotis 9 --------------------------------------------------------------

        public static void TarpaiPriekyjeGale(string tekstas, out int tarpuKiekisGale, out int tarpuKiekisPriekyje)
        {
            tarpuKiekisPriekyje = tekstas.Length - tekstas.TrimStart(' ').Length;
            
            tarpuKiekisGale = tekstas.Length - tekstas.TrimEnd(' ').Length;

        }


    } 
}