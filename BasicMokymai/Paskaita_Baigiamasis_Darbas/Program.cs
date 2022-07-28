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
        public static string head;
        public static string neck;
        public static string lhand;
        public static string rhand;
        public static string torso;
        public static string lleg;
        public static string rleg;

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

        public static string[] kunoDalys = new string[] { "o", "|" , "0", "\\", "/", "/", "\\"};

        public static string[] emptyLetters = new string[] {};

        public static string? wordAnswer;

        public static List<string> guessedLetters = new List<string> { };

        public static List<string> bodyParts = new List<string> { head, neck, lhand, torso, rhand, lleg, rleg};
 
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

                GuessedWord(ivedimas);
                GuessedLetters(ivedimas);
                wordAnswer = string.Join("", emptyLetters).Replace(" ", "");

                if (atspetasZodis == true && (ivedimas == "n" || ivedimas == "N"))
                {

                    tesiam = false;
                }
                else if (atspetasZodis == true && (ivedimas == "y" || ivedimas == "Y"))
                {
                    Console.Clear();
                    atspetasZodis = false;
                    Reset();
                    TopicChoiceMenu();
                }
                else if ((wordAnswer == word.ToLower() || ivedimas == word.ToLower())) //&& atspetasZodis == true)
                {
                    Console.Clear();
                    Console.WriteLine($"!!! SVEIKINIMAI !!!");
                    Console.WriteLine($" :) Zodis teisingas :)");
                    Console.WriteLine($"Zodis buvo: {word}");
                    Console.WriteLine($"Pakartoti zaidima T/N ?");
                    atspetasZodis = true;
                         

                }
                else if (atspetasZodis == false)
                {
                
                Console.Clear();
                //Console.WriteLine($"TEMA: {temos[Convert.ToInt32(ivedimas) - 1]}");
                Console.WriteLine("- - - - - - - |");
                
                Console.WriteLine($"|             {bodyParts[0]}\n|            {bodyParts[3]}{bodyParts[1]}{bodyParts[4]}\n|             {bodyParts[2]}\n|            {bodyParts[5]} {bodyParts[6]}\n|\n|\n|\n|\n|\n|");
                    Console.WriteLine($"_ _ _ _");
                    if (guessedLetters.Count > 6)
                    {
                        Console.WriteLine($" :( Pralaimejote :( ");
                        Console.WriteLine($"Zodis buvo: {word}");
                        Console.WriteLine("Pakartoti zaidima, Y/N?");
                    }
                    else
                    {
                        Console.WriteLine($"Spetos raides: {string.Join("", guessedLetters)}");
                        Console.WriteLine($"Zodis: {String.Concat(emptyLetters)}");
                        
                        Console.WriteLine("\nSpekite raide ar zodi:");
                    }
                }

                if ((wordAnswer != word.ToLower() || ivedimas != word.ToLower()) && tesiam == true)
                {
                    HangmanGame(Console.ReadLine().ToLower());
                }
            }
        }
        public static void DrawBody()
        {
            if (guessedLetters != null && guessedLetters.Count() < 8 && guessedLetters.Count() >= 1)
            {
                for (int bodyPart = 0; bodyPart <= guessedLetters.Count(); bodyPart++)
                {
                   bodyParts[bodyPart] = kunoDalys[bodyPart];
                }
            }
        }
        public static void GuessedLetters(string ivedimas)
        {
            if (ivedimas.Length > 1)
            {
                Console.WriteLine("Neteisinga ivestis, bandykite dar karta");
            }
            else if (ivedimas != "" && Char.IsLetter(Convert.ToChar(ivedimas.ToLower())) && !guessedLetters.Contains($" {ivedimas}") && !word.ToLower().Contains(Convert.ToChar(ivedimas)))
            {
                guessedLetters.Add($" {ivedimas}");
                DrawBody();
            }
            else
            {
                //Console.WriteLine("Wrong");
            }          
        }
        public static void GuessedWord(string ivedimas)
        {
            
            if (!emptyLetters.Contains("_ ") && atspetasZodis == false && (wordAnswer != word.ToLower()))
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
            else if (ivedimas != "" && ivedimas != null && ivedimas.Length <= 1  && (word.ToLower().Contains(Convert.ToChar(ivedimas)) ))
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
               // Console.WriteLine("Netesinga ivestis, bandykite dar karta");
            }            
        }
        public static void Reset()
        {
            tesiam = true;
            word = null;
            emptyLetters = new string[] { };
            guessedLetters.Clear();
        }
    }
        
}
