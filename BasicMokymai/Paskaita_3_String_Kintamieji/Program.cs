namespace Paskaita_3_String_Kintamieji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String tekstinio tipo kintamieji");
            string kintamasis = "Hello World";
            Console.WriteLine(kintamasis);
            

            var stringkintamasis = "blabla";
            //var tipas atiduoda kompiliatoriui nuspresti koks tipas priskiariamas reiksmei
            var tuscias = "";
            string nulas = null; 
            string laisvaerdve = "      "; //white space

            string tekstas = "tgakgonfgwvnifjnsidjnvdsncvlksjgnb";
            string konkatinacija = laisvaerdve + stringkintamasis;
            Console.WriteLine(konkatinacija);
            string kompozicija = string.Format("{0}", stringkintamasis);
            string interpoliacija = $"{stringkintamasis}";

            stringkintamasis = "Hello Tom";
            Console.WriteLine(stringkintamasis);

            //kintamuju sudarymo taisykles
        }
    }
}