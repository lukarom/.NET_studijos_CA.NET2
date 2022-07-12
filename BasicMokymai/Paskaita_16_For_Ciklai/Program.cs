namespace Paskaita_16_For_Ciklai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ForLoopNesting();
        }


        public static void ForLoop()
        {
            for (int i = 0; i > 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void ForLoopBack()
        {
            int skaicius = 5;
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(i);
            }
        }

        public static void BreakeForLoop()
        {
            int skaicius = 5;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == skaicius)
                {
                    break;
                }
            }
        }

        public static void SkipIterationForLoop()
        {
            int iteracijsKuriaNorimePraleisti = 5;
            for (int i = 0; i < 10; i++)
            {
                if (i == iteracijsKuriaNorimePraleisti)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        public static void ForLoopNesting()
        {
            for (int i = 0; i <5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }
                Console.Write("labas");
            }
        }

        
    }
}