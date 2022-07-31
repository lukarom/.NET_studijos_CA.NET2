using System.Collections.Generic;

namespace Paskaita_Baigiamasis_Darbas
{
    public class Program
    {
        #region Global variables

        
        public static bool continued = true; //nuo sio bool priklauso ar zaidimas tesiamas ar ne
        public static bool atspetasZodis = false; //nustato ar buvo atseptas zodis
        public static bool neatspetasZodis = false; //nustato ar nebuvo atspetas zodis
        public static bool wordInArray = true; // nustato ar zodziu masyve dar liko zodziu
        public static bool containsInt; // nustato ar ivedimas turi skaicius
        public static int screen = 1; //nustato kuris ekranas dabar yra naudojamas
        public static string topicChoice; //pasirinktos temos pavadinimas
        public static string word;
        public static string? wordAnswer;// spejamas zodis
        //Body parts
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

        

        public static List<string> guessedLetters = new List<string> {};

        public static List<string> bodyParts = new List<string> { head, neck, lhand, torso, rhand, lleg, rleg};
 
        #endregion 


        public static void Main(string[] args)
        {           
            UserInput();
        }

        public static void HangmanGame(string ivedimas) 
        { 
            if (word == null && int.TryParse(ivedimas, out _) && Convert.ToInt32(ivedimas) > 0 && Convert.ToInt32(ivedimas) < 5) 
            {
                if (wordInArray)
                {
                    GetRandomWord(ivedimas);
                    topicChoice = temos[Convert.ToInt32(ivedimas)-1];
                }
               
            }

            /*else if (screen == 1 && int.TryParse(ivedimas, out _) == false)
            {
                Console.WriteLine("Neteisinga ivestis, bandykite dar karta");
                HangmanGame(Console.ReadLine().ToLower());
            }*/
            
            DrawTheHangman(ivedimas);

            
        } 

        public static void UserInput()
        {
            while (continued)
            {
                if (topicChoice == null)
                {
                    Console.WriteLine($"1. VARDAI\n2. LIETUVOS MIESTAI\n3. VALSTYBES\n4. KITA");
                }
                if ((wordAnswer != word.ToLower()  /*ivedimas != word.ToLower())*/ && continued == true))
                {
                    screen = 2;
                }
                HangmanGame(Console.ReadLine().ToLower());               
            }
        }

        public static void GetRandomWord(string ivedimas)
        {

            var random = new Random();
            if (vardai.Length != 0 && lietuvosMiestai.Length != 0 && valstybes.Length != 0 && kitiZodziai.Length != 0)
            {
                if (ivedimas == "1" && vardai.Length != 0)
                {
                    int index = random.Next(vardai.Length);
                    word = vardai[index];
                    vardai = Array.FindAll(vardai, i => i != vardai[index]).ToArray();
                }
                else if (ivedimas == "2" && lietuvosMiestai.Length != 0)
                {
                    int index = random.Next(lietuvosMiestai.Length);
                    word = lietuvosMiestai[index];
                    lietuvosMiestai = Array.FindAll(lietuvosMiestai, i => i != lietuvosMiestai[index]).ToArray();
                }              
                else if (ivedimas == "3" && valstybes.Length != 0)
                {
                    int index = random.Next(valstybes.Length);
                    word = valstybes[index];
                    valstybes = Array.FindAll(valstybes, i => i != valstybes[index]).ToArray();
                }               
                else if (ivedimas == "4" && kitiZodziai.Length != 0)
                {
                    int index = random.Next(kitiZodziai.Length);
                    word = kitiZodziai[index];
                    kitiZodziai = Array.FindAll(kitiZodziai, i => i != kitiZodziai[index]).ToArray();
                }
                else
                {
                    wordInArray = false;
                }
            }
            else
            {
                Console.WriteLine("Neliko zodziu, perkraukite programa");
            }


        }

        public static void DrawTheHangman(string ivedimas)
        {
            
                containsInt = ContainsDigit(ivedimas);
                GuessedWord(ivedimas);
                GuessedLetters(ivedimas);
                wordAnswer = string.Join("", emptyLetters).Replace(" ", "");

                if ((atspetasZodis == true || neatspetasZodis == true) && (ivedimas == "n" || ivedimas == "N"))
                {

                    continued = false;
                }
                else if ((atspetasZodis == true || neatspetasZodis == true) && (ivedimas == "y" || ivedimas == "Y"))
                {
                //    Console.Clear();
                //    Reset();
                //    UserInput();
                }
                else if ((wordAnswer == word.ToLower() || ivedimas == word.ToLower())) //&& atspetasZodis == true)
                {
               //     Console.Clear();
               //     Console.WriteLine($"!!! SVEIKINIMAI !!!");
                //    Console.WriteLine($" :) Zodis teisingas :)");
               //     Console.WriteLine($"Zodis buvo: {word}");
               //     Console.WriteLine($"Pakartoti zaidima T/N ?");
                    atspetasZodis = true;
                         

                }
                else if (atspetasZodis == false)
                {
                    
                //Console.Clear();
               // Console.WriteLine($"TEMA: {topicChoice}");
               // Console.WriteLine("- - - - - - - |");                
               // Console.WriteLine($"|             {bodyParts[0]}\n|{bodyParts[3],13}{bodyParts[1]}{bodyParts[4]}\n|             {bodyParts[2]}\n|            {bodyParts[5]} {bodyParts[6]}\n|\n|\n|\n|\n|\n|");
                   // Console.WriteLine($"_ _ _ _");
                    if (guessedLetters.Count > 6 || (ivedimas.Length > 1 && !containsInt))
                    {

                       // Console.WriteLine($" :( Pralaimejote :( ");
                       // Console.WriteLine($"Zodis buvo: {wordAnswer}");
                       // Console.WriteLine("Pakartoti zaidima, Y/N?");
                        neatspetasZodis = true;
                    }
                    else
                    {
                        if (containsInt && screen == 2)
                        {
                            //Console.WriteLine("Neteisinga ivestis, bandykite dar karta");
                        }
                       // Console.WriteLine($"Spetos raides: {string.Join("", guessedLetters)}");
                        //Console.WriteLine($"Zodis: {String.Concat(emptyLetters)}");
                        
                        //Console.WriteLine("\nSpekite raide ar zodi:");
                    }
                }

                
            
        }
        public static void DrawBody()
        {
            if (guessedLetters != null && guessedLetters.Count() <= 7 && guessedLetters.Count() > 0)
            {
                for (int bodyPart = 0; bodyPart < guessedLetters.Count(); bodyPart++)
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
            else if (ivedimas != ""  && Char.IsLetter(Convert.ToChar(ivedimas.ToLower())) && !guessedLetters.Contains($" {ivedimas}") && !word.ToLower().Contains(Convert.ToChar(ivedimas)))
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
            if (ivedimas.Length == word.Length)
            {
                if (ivedimas == word.ToLower() || ivedimas == word)
                {
                    atspetasZodis = true;
                    for (int letter = 0; letter < word.Length; letter++)
                    {

                        emptyLetters[letter] = $"{word.ToLower()[letter]} ";

                    }
                }
                else if (ivedimas.Length > word.Length && ivedimas.Length > 1)
                {
                    
                }
            }
            if (ivedimas != "" && ivedimas != null && ivedimas.Length <= 1  && (word.ToLower().Contains(Convert.ToChar(ivedimas)) ))
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
            continued = true;
            word = null;
            emptyLetters = new string[] { };
            guessedLetters.Clear();
            atspetasZodis = false;
            neatspetasZodis = false;
            EmptyTheBody();
            screen = 1;
        }

        public static bool ContainsDigit(string ivedimas)
        {
            bool containsInt = (ivedimas.Any(char.IsDigit));

            return containsInt;
        }

        public static string Rezultatas()
        {
            return wordAnswer;
        }

        public static void EmptyTheBody()
        {
            bodyParts = new List<string> { head, neck, lhand, torso, rhand, lleg, rleg };
        }
    }
        
}
