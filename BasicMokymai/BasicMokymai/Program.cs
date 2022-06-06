namespace BasicMokymai
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

            //Console.WriteLine("Romuald");
            //Console.WriteLine("Iveskite savo varda");

            //Console.WriteLine("Jusu vardas: " + Console.ReadLine());
            //Console.WriteLine("Iveskite bet kokia raide: ");
            //Console.WriteLine("Ivesta raide: " + Console.ReadLine());
            //Console.WriteLine("Iveskite savo varda: ");
            //var vardas = Console.ReadLine()[0];
            
            //Console.WriteLine("Vardo pirmoji raide ASCII formatu: " + (int)vardas);
            Console.WriteLine("Iveskite savo varda");
            var vardas1 = Console.ReadLine()[0];
            Console.WriteLine("Ivesto vardo pirma raide:" + vardas1);
            Console.WriteLine("Iveskite skaiciu:");
            var skaicius = Console.ReadLine();
            Console.WriteLine("Ivestas skaicius:" + skaicius);
            int suma = vardas1 + Convert.ToInt32(skaicius);
            Console.WriteLine("Vardo pirmos raides ir skaiciaus suma: {0:C}", suma );

            // Console.WriteLine(name.KeyChar);




        }
    }
}