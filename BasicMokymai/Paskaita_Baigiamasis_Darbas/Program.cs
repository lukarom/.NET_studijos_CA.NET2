using System.Collections.Generic;

namespace Paskaita_Baigiamasis_Darbas
{
    internal class Program
    {
        #region Global variables

        public static int topicChoice;
        public static bool tesiam = true;
        public static string word;
        public static string head = null;
        public static string neck = null;
        public static string lhand = null;
        public static string rhand = null;
        public static string torso = null;
        public static string lleg = null;
        public static string rleg = null;

        #endregion
        #region Word array declaration
        public static string[] vardai = new string[] { "Irmantas", "Mindaugas", "Aurelija", "Skirmantas", "Andrzej",
                "Eleonora", "Marina", "Miroslav", "Anastasija", "Liudvikas" };

        public static string[] lietuvosMiestai = new string[] { "Klaipeda", "Marijampole", "Kaisiadorys",
                "Kernave", "Ignalina", "Raseiniai", "Vilkaviskis", "Zarasai", "Salcininkai", "Prienai" };

        public static string[] valstybes = new string[] { "Danija", "Zimbabve", "Argentina", "Indonezija",
                "Vatikanas", "Urugvajus", "Bangladesas", "Kanada", "Airija", "Grenlandija"};

        public static string[] kitiZodziai = new string[] { "Ekskavatorius", "Teleskopas", "Respublika", "Infliacija",
                "Apelsinas", "Lazanija", "Krepsinis", "Aritmija", "Kulkosvaidis", "Statybininkas"};

        public static string[] temos = new string[] { "VARDAI", "LIETUVOS MIESTAI", "VALSTYBES", "KITA" };

        public static string[] kunoDalys = new string[] { "o", "|", "/", "\\", "0"};

        public static string[] emptyLetters = new string[] {};
 
        #endregion 


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Kartuves");

            TopicChoiceMenu();

        }

        public static void HangmanGame(string ivedimas)
        {
            if (word == null)
            {
                GetRandomWord(ivedimas);
            }
            DrawTheHangman(ivedimas);
        } 

        public static void TopicChoiceMenu()
        {
                Console.WriteLine($"1. VARDAI\n2. LIETUVOS MIESTAI\n3. VALSTYBES\n4. KITA");

                HangmanGame(Console.ReadLine());
        }

        public static void GetRandomWord(string ivedimas)
        {

            var random = new Random();

            if (ivedimas == "1")
            {
                int index = random.Next(vardai.Length);
                word = vardai[index];
            }
            else if (ivedimas == "2")
            {
                int index = random.Next(lietuvosMiestai.Length);
                word = lietuvosMiestai[index];
            }
            else if (ivedimas == "3")
            {
                int index = random.Next(valstybes.Length);
                word = valstybes[index];
            }
            else if (ivedimas == "4")
            {
                int index = random.Next(kitiZodziai.Length);
                word = kitiZodziai[index];
            }
            
            
            
        }

        public static void DrawTheHangman(string ivedimas)
        {
            while (tesiam)
            {
                
                Console.Clear();
                //Console.WriteLine($"TEMA: {temos[Convert.ToInt32(ivedimas) - 1]}");
                Console.WriteLine("- - - - - - - |");
                Console.WriteLine($"|             {head}\n|            {lhand}{neck}{rhand}\n|             {torso}\n|            {lleg} {rleg}\n|\n|\n|\n|\n|\n|");
                Console.WriteLine($"_ _ _ _");
                Console.WriteLine($"Spetos raides: ");
                Console.WriteLine($"Zodis: {GuessedWord(ivedimas)}");
                Console.WriteLine("\nSpekite raide ar zodi:");
                HangmanGame(Console.ReadLine());
            }
        }
        //public static string GuessedLetters(string letters)
        //{

        //}
        public static string GuessedWord(string ivedimas)
        {
            
            if (!emptyLetters.Contains("_ "))
            {
                emptyLetters = new string[word.Length];

                for (int runs = 0; runs < word.Length; runs++)
                {
                    emptyLetters[runs] = "_ ";
                }
            }
            if (word.Contains(Convert.ToChar(ivedimas)))
            {

                for (int letter = 0; letter < word.Length; letter++)
                {
                    if (word[letter] == Convert.ToChar(ivedimas))
                    {
                        emptyLetters[letter] = ivedimas;
                    }
                }      
            }
            else
            {

            }
            string emptyLettersString = String.Concat(emptyLetters);

            return emptyLettersString;
        }
        public static void Reset()
        {
            tesiam = true;
            word = null;
        }
    }
        
}
