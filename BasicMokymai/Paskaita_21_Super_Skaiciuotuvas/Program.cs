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
            PagrindinisMeniu();

        }


        public static void SuperSkaiciuotuvas(string ivedimas)
        {
            //klaida = 0;
            if (ivedimas.Length > 0 && meniu >= 0 && meniu <= 2 && (skaicius1 == null || skaicius2 == null) && veiksmas == null)
            {
                int ivestis = IntSkaiciausTikrinimas(ivedimas);
                if ((meniu == 0 && ivestis >= 1 && ivestis <= 2) || (meniu == 1 && ivestis >= 1 && ivestis <= 3) || (meniu >= 1 && ivestis <= 6))
                    if ((meniu == 0 && ivestis == 2) || (meniu == 1 && ivestis == 3))
                        testi = false; //isejimas is programos
                    else if ((meniu == 0 && ivestis == 1) || (meniu == 1 && ivestis == 1))
                    {
                        rezultatas = null;
                        meniu = 2;
                    }
                    else if (meniu == 2 && (ivestis >= 1 && ivestis <= 6))
                    {
                        veiksmas = ivestis;
                        Console.Write("Pasirinktas veiksmas");
                        switch (veiksmas)
                        {
                            case 1:
                                Console.WriteLine("+");
                                break;
                            case 2:
                                Console.WriteLine("-");
                                break;
                            case 3:
                                Console.WriteLine("*");
                                break;
                            case 4:
                                Console.WriteLine("/");
                                break;
                            case 5:
                                Console.WriteLine("^");
                                break;
                            case 6:
                                Console.WriteLine("√");
                                break;

                            default:
                                break;
                        }
                        if (rezultatas != null)
                        {
                            skaicius1 = rezultatas;
                            meniu = 4; // antro skaiciaus ivedimas
                        }
                        else
                            meniu = 3; // pirmo skaiciuas ivedimas
                    }
                    else
                        meniu = ivestis;
                else
                    klaida = 1;
            }

            //Pirmo skaiciaus (skaicius1) ivedimas
            else if (ivedimas.Length > 0 && meniu == 3 && skaicius1 == null && klaida == 0 && veiksmas != null)
            {
                skaicius1 = DoubleSkaiciausTikrinimas(ivedimas);
                if (skaicius1 == null)
                    klaida = 2;
                else
                    meniu = 4;
            }
            //Antro skaiciaus (skaicius2) ivedimas
            else if (ivedimas.Length > 0 && skaicius2 == null && klaida == 0 && veiksmas != null)
            {
                skaicius2 = DoubleSkaiciausTikrinimas(ivedimas);
                if (skaicius2 == null)
                    klaida = 2;
                else if (skaicius2 == 0 && veiksmas == 4) // dalyba is nulio
                {
                    klaida = 3;
                    skaicius2 = null; // jeigu skaicius 2 null, leidziame ivesti skacius2 pakartotinai
                }
            }

            if (klaida == 0 && veiksmas != null && skaicius1 != null && skaicius2 != null) //Jeigu ivesti skaiciai yra teisingi ivykdome atitinkama veiksma
            {
                switch (veiksmas) 
                {
                    case 1:
                        rezultatas = Sudetis((double)skaicius1, (double)skaicius2);
                        break;
                    case 2:
                        rezultatas = Atimtis((double)skaicius1, (double)skaicius2);
                        break;
                    case 3:
                        rezultatas = Daugyba((double)skaicius1, (double)skaicius2);
                        break;
                    case 4:
                        rezultatas = Dalyba((double)skaicius1, (double)skaicius2);
                        break;
                }
                if (/*klaida == 0 &&*/ rezultatas != null) // patikriname ar rezultatas nera null
                    Console.WriteLine("Rezultatas: {0}", rezultatas);
                skaicius1 = null;
                skaicius2 = null;
                veiksmas = null;
                meniu = 1; // sugriztame i pagrindini meniu
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

        public static void PagrindinisMeniu()
        {
            Console.Clear();
            Reset();
            while (testi)
            {
                switch (meniu)
                {
                    case 0: //Pradinis meniu pasirinkimas
                        Console.WriteLine("1. Nauja Operacija 2. Išeiti");
                        break;
                    case 1: //Pradinis meniu pasirinkimas
                        Console.WriteLine("1. Nauja Operacija 2. Testi su rezultatu 3. Išeiti");
                        break;
                    case 2: //Operacijos parinkimas
                        Console.WriteLine("1. Sudėtis 2. Atimtis 3. Daugyba 4. Dalyba");
                        break;
                    case 3: //Pirmo skaiciaus ivedimas
                        Console.WriteLine("4. Iveskite pirma skaiciu");
                        break;
                    case 4: //Antro skaiciaus ivedimas
                        Console.WriteLine("5. Iveskite antra skaiciu");
                        break;
                    case 5: //Kitu skaiciu ivedimas
                        Console.WriteLine("6. Iveskite skaiciu");
                        break;
                }

                SuperSkaiciuotuvas(Console.ReadLine());

                switch (klaida)
                {
                    case 0: 
                        Console.WriteLine("Nėra tokio skaičiaus");
                        break;
                    case 1: 
                        Console.WriteLine("Neteisingas skaičiaus formatas");
                        break;
                    case 2: 
                        Console.WriteLine("Dalyba iš nulio");
                        break;
                }
            }
        }

      

        

        public static double Sudetis(double skaicius1, double skaicius2) => skaicius1 + skaicius2;
        public static double Atimtis(double skaicius1, double skaicius2) => skaicius1 - skaicius2;
        public static double Daugyba(double skaicius1, double skaicius2) => skaicius1 * skaicius2;
        public static double Dalyba (double skaicius1, double skaicius2) => skaicius1 / skaicius2;

        private static double? DoubleSkaiciausTikrinimas(string? tekstas) => double.TryParse(tekstas, out double skaicius) ? skaicius : null;
        private static int IntSkaiciausTikrinimas(string? tekstas) => int.TryParse(tekstas, out int skaicius) ? skaicius : 0;


    }

}