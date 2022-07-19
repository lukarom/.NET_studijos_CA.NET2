using System.Text;

namespace Paskaita_17_Ciklai_Praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            // ReadIntNumber();
            // double sk = PakeltiLaipsniu2();

            //Console.WriteLine(sk);

            //SkaiciusTrikampis();
            string sk1 = SkaiciuPiramide();
            Console.WriteLine(sk1);
            SkaiciusTrikampisSkaic();




        }

        public static void ReadIntNumber()
        {
            Console.WriteLine("Iveskite skaiciu");
            bool arSkaiciusTeisingas = false;
            bool arLyginisSkaicius = false;
            while (!arSkaiciusTeisingas)
            {
                string skaicius = Console.ReadLine();
                arSkaiciusTeisingas = int.TryParse(skaicius, out _);

                if (!arSkaiciusTeisingas)
                {

                    Console.WriteLine("Ivestas skaicius netesingas, bandykite is naujo");

                }

                else if (!(arLyginisSkaicius = Convert.ToInt32(skaicius) % 2 == 0))
                {

                    while (!(arLyginisSkaicius = Convert.ToInt32(skaicius) % 2 == 0))
                    {
                        Console.WriteLine("Ivestas skaicius netesingas, bandykite is naujo");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Ivestas skaicius" + " " + skaicius);
                    break;

                }


            }
        }

        public static void IntegerToBinary(int sk)
        {

        }


        public static double PakeltiLaipsniu()
        {
            Console.WriteLine("Iveskite skaicius kuri kelsime laispniu");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaicius kuri kelsime laispniu");
            int laipsnis = Convert.ToInt32(Console.ReadLine());
            while (sk == 0 && laipsnis > 0)
            {
                return 1;
                break;
            }
            while (sk == 0 && laipsnis == 0)
            {
                return 0;
                break;
            }
            while (sk == 0 && laipsnis == 1)
            {
                return sk;
                break;
            }

            return sk ^ laipsnis;


        }


        public static double PakeltiLaipsniu2()
        {
            Console.WriteLine("Iveskite skaicius kuri kelsime laispniu");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite laipsni kuri kelsime");
            int laipsnis = Convert.ToInt32(Console.ReadLine());

            if (sk > 0 && laipsnis == 0)
            {
                return 1;
            }
            if (sk == 0 && laipsnis == 0)
            {
                return 0;
            }
            if (laipsnis == 1)
            {
                return sk;
            }
            else
            {
                var rezultatas = sk;
                for (int i = 2; i < laipsnis; i++)
                {
                    rezultatas = rezultatas * sk;
                }
                return rezultatas;
            }






        }

        public static void SkaiciusTrikampis()
        {
            Console.WriteLine("Iveskite skaiciu nuo 1 iki 9");
            int sk = Convert.ToInt32(Console.ReadLine());
            if (Convert.ToInt32(sk) >= 1 && Convert.ToInt32(sk) <= 9)
            {
                string sk1 = SkaiciusTrikampisSkaic(sk);
            }
            
            

            

        }

        public static string SkaiciuPiramide()
        {
            Console.WriteLine("Iveskite skaiciu nuo 1 iki 9");
            int sk = Convert.ToInt32(Console.ReadLine());
            StringBuilder sk1 = new StringBuilder();
            sk1.Append(Convert.ToString(sk));
            
                
            for (int i = 1; i <= sk; i++) 
             {
             sk1 = sk1.Append(Convert.ToInt32(sk));
             Console.WriteLine(sk1);
             } 
            for (int i = sk; i <= 2*sk-1; i++)
            {
             sk1 = sk1.Remove(0, 1);
            Console.WriteLine(sk1);
            }
            return sk1.ToString();

                   
           
        }



        public static string SkaiciusTrikampisSkaic(int sk)
        {
            Console.WriteLine("Iveskire skaiciu");
            int sko = Convert.ToInt32(Console.ReadLine());
            StringBuilder sk1 = new StringBuilder();
            sk1.Append(Convert.ToString(sko));
            for (int i = 1; i < sk; i++)
            {
                sk1 = sk1.Append(i);
                Console.WriteLine(sk1);
            }
            return sk1.ToString();
        }
    }
}