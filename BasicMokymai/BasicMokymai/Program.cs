﻿namespace BasicMokymai
{

    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, \n brother World!");

            //Console.Write("isvedimas "); 
            //Console.Write("eiluteje "); 
            //Console.Write("vienoje");
            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("tekstas" + "vienoje" + "eiluteje"); //konkatinacija
            //Console.WriteLine("{0} {1} {2}", "isvedimas", "vienoje", "eiluteje"); //kompozicija
            //Console.WriteLine($"{"isvedimas"} {"vienoje"} {"eiluteje"}"); //interpoliacija
            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("tekstas idedamas i \"kabutes\" ");
            //Console.WriteLine("tekstas \n idedamas \ni \n\"kabutes\" ");
            //Console.WriteLine("tekstas \t idedamas \ti \t\"kabutes\" ");
            //Console.WriteLine("----------------------------------------------------");
            Console.Clear();
            //Console.WriteLine("Iveskite savo varda o as ji pakartosiu");
            //Console.WriteLine("o stai mano pakartojimas {0}", Console.ReadLine());
            //Console.WriteLine($" o stai mano pakartojimas {Console.ReadLine()}");
            //Console.WriteLine("Iveskie raide");

            //Console.WriteLine("ivestas simbolis {0}", key.KeyChar);
            // Console.WriteLine("ivestas simbolis {0}", (int)key.KeyChar);

            //Console.WriteLine("ivestas simbolis {0}", Console.ReadKey().KeyChar);
            //Console.WriteLine("ivestas simbolis {0}", (int)Console.ReadKey().KeyChar);

            //Console.WriteLine("Iveskite savo varda o as atspesiu pirma raide:");
            //Console.WriteLine("o stai mano pakartojimas \"" + Console.ReadLine()[0] + "\"");

            //Console.ReadKey();

            //            Console.WriteLine("eilute 1" + 
            //                Environment.NewLine + "eilute 2" +
            //                Environment.NewLine + "eilute 2");

            //            Console.WriteLine(@" "" tekstas kabutese "" \ \ \ \ \ \ \ \
            //Eilute 1 
            //Eilute 2 
            //Eilute 3");
            //Console.WriteLine("----------------------------------------------------");
            //var raide = Console.ReadKey();

            //Pirma uzduotis
            Console.WriteLine("Romuald");

            //Antra uzduotis
            Console.WriteLine("iveskite savo varda");
            Console.WriteLine("jusu vardas: " + Console.ReadLine());

            //Trecia uzduotis
            Console.WriteLine("iveskite savo varda: ");
            var vardas = Console.ReadLine()[0];
            Console.WriteLine("Vardo pirmoji raide ASCII formatu: " + (int)vardas);

            //Ketvirta uzduotis
            Console.WriteLine("Iveskite savo varda");
            var vardas1 = Console.ReadLine()[0];
            Console.WriteLine("Ivesto vardo pirma raide:" + vardas1);
            Console.WriteLine("Iveskite skaiciu:");
            var skaicius = Console.ReadLine();
            Console.WriteLine("Ivestas skaicius:" + skaicius);
            int suma = vardas1 + Convert.ToInt32(skaicius);
            Console.WriteLine("Vardo pirmos raides ir skaiciaus suma: {0:C}", suma);


            //Penkta uzduotis
            MenuMenu();
        }

        private static bool MenuMenu()
        {
            Console.WriteLine("Pasirinkite viena is opciju");
            Console.WriteLine("(1) Pirkti");
            Console.WriteLine("(2) Parduoti");
            Console.WriteLine("(3) Likuciai");
            
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Pirkti");
                    return true;
                case "2":
                    Console.WriteLine("Parduoti");
                    return true;
                case "3":
                    Console.WriteLine("Likuciai");
                    return true;
                default:
                    Console.WriteLine("Netinkamas pasirinkimas");
                    return MenuMenu();
            }

        }
    }
}