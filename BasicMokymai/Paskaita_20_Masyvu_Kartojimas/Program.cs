namespace Paskaita_20_Masyvu_Kartojimas
{
    public class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Hello, Masyvu Kartojimas!");

            int[] ints = { 5, 3, 7, 6, 8, 2, 10};

            SurastiMaziausiaNari(ints);
            SurastiDidziausiaNari(ints);
            SurikiuotiSkaiciusMasyve(ints);
            Console.WriteLine(SurikiuotiSkaiciusMasyve(ints));
        }


        public static int SurastiMaziausiaNari(int[] ints)
        {
            int MinInts = ints.Min();

            Console.WriteLine(MinInts);

            return MinInts;
        }


        public static int SurastiDidziausiaNari(int[] ints)
        {
            int MaxInts = ints.Max();

            Console.WriteLine(MaxInts);

            return MaxInts;
        }

        public static string SurikiuotiSkaiciusMasyve(int[] ints)
        {

            for (int i = 0; i < ints.Length; i++)
            {
                for(int j = 0; j< ints.Length -1; j++)
                {
                    if(ints[j+1] < ints[j])
                    {
                        char temp = (char)ints[j+1];
                        ints[j + 1] = ints[j];
                        ints[j] = temp;
                    }
                        

                }
            }
            string result = String.Join(", ", ints);
            return result;

            
        }

    }
}