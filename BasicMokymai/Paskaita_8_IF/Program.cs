namespace Paskaita_8_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, If");
            int nelyginisSkaicius = 5;
            int lyginisSkaicius = 2;
            bool tiesa = true;
            
            if (nelyginisSkaicius > lyginisSkaicius)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginisSkaicius}");
            }

            Console.WriteLine("Press any key to continue");

            Console.WriteLine("if - else");

            if (nelyginisSkaicius < lyginisSkaicius)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginisSkaicius}");
            }
            else {
                Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius}");
            }
            Console.WriteLine("Press any key to continue");



            Console.WriteLine("if - else if - else");

            if (nelyginisSkaicius < lyginisSkaicius && tiesa)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius} ir tiesa yra true");
            }
            else if (nelyginisSkaicius < lyginisSkaicius && !tiesa)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius} ir tiesa yra false");
            }
            else if (nelyginisSkaicius > lyginisSkaicius && tiesa)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginisSkaicius} ir tiesa yra true");
            }
            else
            {
                Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginisSkaicius} ir tiesa yra false");
            }
            Console.WriteLine("Press any key to continue");


            Console.WriteLine("---------------------------------------");

            Console.WriteLine(" if kompozicija, nesting");
            int shields = 1, armor = 2;
            if (shields <= 0)
            {
               if (armor <=0)
                {
                    Console.WriteLine("jus mires");
                }
                else
                {
                    Console.WriteLine("jus dar turite armor");
                }//........
            }
            else
            {
                Console.WriteLine("Jus dar turite galimybiu");
            }
        

        }
    }
}