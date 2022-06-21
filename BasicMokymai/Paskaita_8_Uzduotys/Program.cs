namespace Paskaita_8_Uzduotys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, if uzduotys");

            //Console.WriteLine($"Iveskite skaicius:");
            //int skaicius = int.Parse(Console.ReadLine());


            //if (skaicius % 2 == 0)
            //{
            //    Console.WriteLine("Lyginis skaicius");
            //}
            //if (skaicius <  0)
            //{
            //    Console.WriteLine("Neigiamas skaicius");
            //}
            //if (skaicius % 2 != 0 && skaicius > 0)
            //{
            //    Console.WriteLine("Kitas atvejis");
            //}


            //Console.WriteLine("Uzduotis numeris 2");

            //Console.WriteLine("Iveskite grupes nariu kieki");
            //int nariuKiekis = int.Parse(Console.ReadLine());

            //if (nariuKiekis == 1)
            //{
            //    Console.WriteLine("Tai SOLO atlikejas");
            //}
            //else if (nariuKiekis == 2)
            //{
            //    Console.WriteLine("Tai duetas");
            //}
            //else if (nariuKiekis > 2 && nariuKiekis < 10)
            //{
            //    Console.WriteLine("Tai Ansamblis");
            //}
            //else if (nariuKiekis > 10)
            //{
            //    Console.WriteLine("Tai kamerinis ansamblis");   
            //}
            //else
            //{
            //    Console.WriteLine("Ivedimo klaida");
            //}

            Console.WriteLine("Uzduotis 3");

            Console.WriteLine("Prasykite isdirbtas valandas");
            bool arGerasSkaicius = int.TryParse(Console.ReadLine(), out int input);
            //int isdirbtosVal = int.Parse(Console.ReadLine());
            if (arGerasSkaicius)
            {
                if (input < 160 && input > 0)
                {
                    Console.WriteLine($"Liko isdirbti {160 - input}");
                }
                else if (input == 160)
                {
                    Console.WriteLine("Isdirbtas pilnas etatas");
                }
                else if (input > 160)
                {
                    Console.WriteLine($"Isdirbta virsvalandziu {input - 160}");
                }
            }
            else
            {
                Console.WriteLine(" klaida");
            }
        }
    }
}