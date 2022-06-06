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
            //var key = Console.ReadKey();
            //Console.WriteLine("ivestas simbolis {0}", key.KeyChar);
           // Console.WriteLine("ivestas simbolis {0}", (int)key.KeyChar);

            //Console.WriteLine("ivestas simbolis {0}", Console.ReadKey().KeyChar);
            //Console.WriteLine("ivestas simbolis {0}", (int)Console.ReadKey().KeyChar);

            Console.WriteLine("Iveskite savo varda o as atspesiu pirma raide:");
            Console.WriteLine("o stai mano pakartojimas \"" + Console.ReadLine()[0] + "\"");



            Console.ReadKey();
        }
    }
}