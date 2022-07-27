// See https://aka.ms/new-console-template for more information
namespace Paskaita_21_Super_Skaiciuotuvas
{
    /* ## Super Skaiciuotuvas ## 
        Sukurti skaiciuotuva. Ijungus programa turetume gauti pranešimą “
        1. Nauja operacija 2 Iseiti. 
        
        Pasirinkus 1 vada į submeniu:
        1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
    
        Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius,
        o gale isvesti rezultata į ekraną. Po rezultato parodymo naudotojui parodomas submeniu su klausimu ar naudotojas nori atlikti nauja operacija ar testi su rezultatu. 
        1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”
        Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. 
        Pasirinkus 3 programa turetu issijungti. Visa kita turetu veikti tokiu pat budu.
    
    Pvz:
    > 1. Nauja operacija 2 Iseiti. 
    _1
    > 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
    _1
    > pasirinktas veiksmas + 
    > iveskite pirma skaiciu
    _15
    > iveskite antra skaiciu
    _45
    > Rezultatas: 60
    > 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
    _2
    > 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
    _2
    > pasirinktas veiksmas - 
    > Iveskite skaiciu
    _10
    > Rezultatas: 50
    > 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
    _1
    > 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
    _2
    > pasirinktas veiksmas * 
      > iveskite pirma skaiciu
    _2
    > iveskite antra skaiciu
    _3
    > Rezultatas: 6
    > 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
    _3
    > Baigta
     
    
    
    BONUS1: Iskelkite operacijas i metodus
    BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius. 
            - dalyba is nulio, neteisingu ivesciu prevencija 
            - kada tikimasi gauti skaiciu, bet gaunamas char arba string.
            - neteisingas meniu punkto pasirinkimas
    BONUS3: Parasyti unit testus uztikrinant operaciju veikima
    BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas
    
       */
    public class Program
    {
        static double? rezultatas = null;
        static int meniuLangas = 0;
        static double? pirmasSk = null;
        static double? antrasSk = null;
        static bool testi = true;
        static int klaida = 0;
        static int veiksmas = 0;



        static void Main(string[] args)
        {
            MeniuLangas();
        }


        public static void SuperSkaiciuotuvas(string ivedimas)
        {
            Reset();
            Console.Clear();

            if (meniuLangas == 0 && klaida == 0 && ivedimas == "1")
            {
                meniuLangas = 1;
            }
            else if (meniuLangas == 1 && klaida == 0 && ivedimas == "2")
            {

                veiksmas = Convert.ToInt32(ivedimas) - 1;
                switch (veiksmas)
                {
                    case 0:
                            Console.Write($" {meniuLangas = 2} \"+\" ");
                    break;
                    case 1:  Console.WriteLine($"{meniuLangas = 2} \"-\" ");
                    break;
                    case 3:  Console.WriteLine($"{meniuLangas = 2} \"*\" ");
                    break;
                    case 4:  Console.WriteLine($"{meniuLangas = 2} \"\\\" ");
                    break;
                    default: klaida = 2;
                        break;

                }
                

                meniuLangas = 4;
                pirmasSk = Convert.ToInt32(ivedimas);
                meniuLangas = 5;
                antrasSk = Convert.ToInt32(ivedimas);


            }
            //todo
        }

        public static double Rezultatas()
        {
            return rezultatas ?? 0;
        }
        public static void Reset()
        {
            
            meniuLangas = 0;
            pirmasSk = null;
            antrasSk = null;
            testi = true;
            rezultatas = null;
        }

        public static void MeniuLangas()
        {
            while (testi)
            {
                switch (meniuLangas)
                {
                    case 0:
                        Console.WriteLine("1. Nauja Operacija 2. Išeiti");
                        break;
                    case 1:
                        Console.WriteLine("1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba");
                        break;
                    case 2:
                        Console.WriteLine($"Pasirinktas veiksmas: ");
                        break;
                    case 3:
                        Console.WriteLine("1. Nauja operacija 2. Testi su rezultatu 3. Iseiti");
                        break;
                    case 4:
                        Console.WriteLine("Iveskite pirma skaiciu");
                        break;
                    case 5:
                        Console.WriteLine("Iveskite antra skaiciu");
                        break;
                    default:
                        break;

                        
                }
                SuperSkaiciuotuvas(Console.ReadLine());

                
                
            }
            switch (klaida)
            {
                case 0:
                    Console.WriteLine("Tokio skaiciaus nera");
                    break;
                case 1:
                    Console.WriteLine("Dalyba is nulio");
                    break;
                case 2:
                    Console.WriteLine("Ivestas neteisinga reiksme");
                    break;
            }
        }
    
    }



}

