namespace BasicMokymai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, \n brother World!");

            Console.Write("isvedimas "); 
            Console.Write("eiluteje "); 
            Console.Write("vienoje");
            Console.WriteLine("tekstas" + "vienoje" + "eiluteje"); //konkatinacija
            Console.WriteLine("{0} {1} {2}", "isvedimas", "vienoje", "eiluteje"); //kompozicija
            Console.WriteLine($"{"isvedimas"} {"vienoje"} {"eiluteje"}"); //interpoliacija

        }
    }
}