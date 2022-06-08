namespace Paskaita_3_Tower_of_Hanoi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string FirstColFirstRow = "";
            string FirstColSecondRow = "";
            string FirstColThirdRow = "";
            string FirstColFourthRow = "";
            string FirstColFifthRow = "";


            string SecondColFirstRow = "";
            string SecondColSecondRow = "";
            string SecondColThirdRow = "";
            string SecondColFourthRow = "";
            string SecondColFifthRow = "";


            string ThirdColFirstRow = "";
            string ThirdColSecondRow = "";
            string ThirdColThirdRow = "";
            string ThirdColFourthRow = "";
            string ThirdColFifthRow = "";

            //Pirma uzduotis

            //Pagal elementu atstumus paskaiciuojame, kad pirmo stulpelio pirmos eilutes
            //bruksnelis nutoles nuo kaires puses iki "1stulp" U raides per 8 zignsnius
            //antro stulpelio pirmos eilutes vertikalus bruksnys nutoles nuo pirmo stulpelio pirmos eilutes bruksnio
            //iki "2stulp" U raides per 13 zingsniu. Trecio stulpelio pirma eilute taip pat nutolusi
            //nuo antro stuelpelio pirmos eilutes per 13 zignsniu. Pirmo stulpelio antros eilutes atstumas skaciuojamas
            //atemus 1 del papildomo groteliu simbolio is abieju pusiu todel atstumas sumazeja atitinkamai iki 7 pirmam stulpeliui
            //ir iki 12 antram stulpeliui. Trecias stulpelis siuo atveju lieka per ta pati atsuma nuo antro stulpelio,
            //nes antras stulpelis lieka tuscias. Atitinkami skaiciavimai atliekami treciai ketivrtai ir penktai eilutei.

            Console.WriteLine("1. nupieškite Tower of Hanoi. Piešiniui naudokite kintamuosius.");

            FirstColFirstRow = "|";
            FirstColSecondRow = "#|#";
            FirstColThirdRow = "##|##";
            FirstColFourthRow = "###|###";
            FirstColFifthRow = "####|####";

            SecondColFirstRow = "|";
            SecondColSecondRow = "|";
            SecondColThirdRow = "|";
            SecondColFourthRow = "|";
            SecondColFifthRow = "|";


            ThirdColFirstRow = "|";
            ThirdColSecondRow = "|";
            ThirdColThirdRow = "|";
            ThirdColFourthRow = "|";
            ThirdColFifthRow = "|";

            string PirmaEilute = $"1eil.{FirstColFirstRow}{SecondColFirstRow}{ThirdColFirstRow}";
            string AntraEilute = $"2eil.{FirstColSecondRow}{SecondColSecondRow}{ThirdColSecondRow}";
            string TreciaEilute = $"3eil.{FirstColThirdRow}{SecondColThirdRow}{ThirdColThirdRow}";
            string KetvirtaEilute = $"4eil.{FirstColFourthRow}{SecondColFourthRow}{ThirdColFourthRow}";
            string PenktaEilute = $"5eil.{FirstColFifthRow}{SecondColFifthRow}{ThirdColFifthRow}";
            string ApatineEilute = $"       ---1stulp---  ---2stulp---  ---3stulp---           ";


            Console.WriteLine(PirmaEilute);
            Console.WriteLine(AntraEilute);
            Console.WriteLine(TreciaEilute);
            Console.WriteLine(KetvirtaEilute);
            Console.WriteLine(PenktaEilute);
            Console.WriteLine(ApatineEilute);

            Console.ReadLine();



        }
    }
}