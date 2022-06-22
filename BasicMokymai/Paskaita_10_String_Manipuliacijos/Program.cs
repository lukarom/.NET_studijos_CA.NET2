namespace Paskaita_10_String_Manipuliacijos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, String Manipuliacijos!");

            char[] letters = { 'H', 'e', 'l', 'l','o' };

            string greetings = new string(letters); //string constructor
            Console.WriteLine(greetings);
            Console.WriteLine(letters[2]);
            //array

            //-------------------
            Console.WriteLine("******** string concatination");


            //----------------------------
            Console.WriteLine("-----------------------------");
            string aa1 = "kabute = \"";
            string aa2 = "kabute = \\";
            string aa3 = "kabute = \n";
            string aa4 = $"eilute {Environment.NewLine} nauja";
            string aa5 = $"kelias diskineje sistemoje {Path.DirectorySeparatorChar}programfiles{Path.DirectorySeparatorChar}windows";
            string aa6 = $"{{ }}";
            string aa7 = @"
            galime
rasyti teksta
per 
""""
{kelias }
eilutes
            ";
            Console.WriteLine(aa7);
            Console.WriteLine("-------------------------------------");

            double skaicius = 6.3545982772;
            Console.WriteLine(skaicius);
            string skaiciusSuApribotuKiekiuPoKablelio = skaicius.ToString("0.00");
            Console.WriteLine(skaiciusSuApribotuKiekiuPoKablelio);

        }
    }
}