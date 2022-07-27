using System.Collections.Generic;

namespace Paskaita_Baigiamasis_Darbas
{
    internal class Program
    {
        #region Global variables

        public static int topicChoice;
        public static bool tesiam = true;
        public static bool atspetasZodis = false;
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

        public static List<string> guessedLetters = new List<string> { };
 
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

                HangmanGame(Console.ReadLine().ToLower());
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
                Console.WriteLine($"Spetos raides: {GuessedLetters(ivedimas)}");
                Console.WriteLine($"Zodis: {GuessedWord(ivedimas)}");
                Console.WriteLine("\nSpekite raide ar zodi:");
                HangmanGame(Console.ReadLine().ToLower());
            }
        }
        public static string GuessedLetters(string ivedimas)
        {
            if (ivedimas.Length > 1)
            {

            }
            else 
            if (ivedimas != "" && Char.IsLetter(Convert.ToChar(ivedimas.ToLower())) && !guessedLetters.Contains($" {ivedimas}") && !word.ToLower().Contains(Convert.ToChar(ivedimas)))
            {
                guessedLetters.Add($" {ivedimas}");
            }
            else
            {
                //Console.WriteLine("Wrong");
            }

            string guessedLettersString = string.Join("", guessedLetters);

            return guessedLettersString;
        }
        public static string GuessedWord(string ivedimas)
        {
            
            if (!emptyLetters.Contains("_ ") && atspetasZodis == false)
            {
                emptyLetters = new string[word.Length];

                for (int runs = 0; runs < word.Length; runs++)
                {
                    emptyLetters[runs] = "_ ";
                }
            }
            else if (ivedimas.Length == word.Length)
            {
                if (ivedimas == word.ToLower())
                {
                    atspetasZodis = true;
                    for (int letter = 0; letter < word.Length; letter++)
                    {

                        emptyLetters[letter] = $"{word[letter]} ";

                    }
                }
                else if (ivedimas.Length > word.Length && ivedimas.Length > 1)
                {
                    
                }
            }
            else if (ivedimas != "" && (word.ToLower().Contains(Convert.ToChar(ivedimas)) && ivedimas.Length <= 1 && ivedimas != null))
            {

                for (int letter = 0; letter < word.Length; letter++)
                {
                    if (word.ToLower()[letter] == Convert.ToChar(ivedimas))
                    {
                        emptyLetters[letter] = $"{ivedimas} ";
                    }
                }      
            }
            
            else
            {
                Console.WriteLine("Netesinga ivestis, bandykite dar karta");
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
