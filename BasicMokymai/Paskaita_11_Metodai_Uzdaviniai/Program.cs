namespace Paskaita_11_Metodai_Uzdaviniai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SveikiVisi();
            //LinkiuVisiems();
            //VardoIvedimas();
            //LinkiuJums();
            Console.WriteLine("Iveskite du skaicius");
            Console.WriteLine(SkaitmenSkaiciai(Convert.ToString(Console.ReadLine()), Convert.ToString(Console.ReadLine())));
            Console.WriteLine("Iveskite bet koki teksta su tarpais");
            Console.WriteLine($"Tarpu kiekis yra: {TekstasSuTarpais(Convert.ToString(Console.ReadLine()))}");
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

        public static int TekstasSuTarpais(string tekstasSuTarpais)
        {
            int tarpuSk = tekstasSuTarpais.Count(Char.IsWhiteSpace);
            return tarpuSk;
        }

        //------------------------------------------------------------------




    } 
}