namespace Paskaita_21_Super_Skaiciuotuvas
{
    public class Program
    {
        static double? rezultatas = null;
        static double? skaicius1 = null;
        static double? skaicius2 = null;
        static int? veiksmas = null;
        static int meniu = 0;
        static int klaida = 0;
        static bool testi = true;


        static void Main(string[] args)
        {
            SuperSkaiciuotuvas(Convert.ToString(Console.ReadLine()));

        }


        public static void SuperSkaiciuotuvas(string ivedimas)
        {
            Console.WriteLine("1. Nauja operacija 2. Iseiti");
            if (ivedimas == "1")
            {
                NaujaOperacija(skaicius1, skaicius2)
            }
        }

        public static double Rezultatas()
        {

            return rezultatas ?? 0;
        }
        public static void Reset()
        {

            rezultatas = null;
            skaicius1 = null;
            skaicius2 = null;
            veiksmas = null;
            klaida = 0;
            meniu = 0;
            testi = true;
        }

        public static double NaujaOperacija (string skaicius1, string skaicius2)
        {
            string veiksmas = NaujasVeiksmas();

            if (veiksmas == "1")
            {
                skaicius1 + skaicius2;
            }

            return Rezultatas();
        }

        
        public static string NaujasVeiksmas()
        {
            Console.WriteLine("1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba");
            string veiksmas = Console.ReadLine().ToString();

            return veiksmas;
        }


        public static double Sudetis(double skaicius1, double skaicius2) => skaicius1 + skaicius2;
        public static double Atimtis(double skaicius1, double skaicius2) => skaicius1 - skaicius2;
        public static double Daugyba(double skaicius1, double skaicius2) => skaicius1 * skaicius2;
        public static double Dalyba (double skaicius1, double skaicius2) => skaicius1 / skaicius2;
    }

}