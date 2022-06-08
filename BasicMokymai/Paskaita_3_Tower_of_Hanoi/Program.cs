namespace Paskaita_3_Tower_of_Hanoi
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

            FirstColFirstRow = "        |";
            FirstColSecondRow = "       #|#";
            FirstColThirdRow = "      ##|##";
            FirstColFourthRow = "     ###|###";
            FirstColFifthRow = "    ####|####";

            SecondColFirstRow = "             |";
            SecondColSecondRow = "            |";
            SecondColThirdRow = "           |";
            SecondColFourthRow = "          |";
            SecondColFifthRow = "         |";


            ThirdColFirstRow = "             |";
            ThirdColSecondRow = "             |";
            ThirdColThirdRow = "             |";
            ThirdColFourthRow = "             |";
            ThirdColFifthRow = "             |";

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


            //Antra uzduotis

            //Panasus procesas kaip ir pirmoje uzduotyje tik pirmas ir antras stulpeliai keicia atstumus atvirkstiniu budu
            //Pirmi stulpeliai turi maziausius atstumus, o Penkti stulpeliai didziausius. Trecias stulpelis lieka nepakites


            FirstColFirstRow = "    ####|####";
            FirstColSecondRow = "     ###|###";
            FirstColThirdRow = "      ##|##";
            FirstColFourthRow = "       #|#";
            FirstColFifthRow = "        |";

            SecondColFirstRow = "         |";
            SecondColSecondRow = "          |";
            SecondColThirdRow = "           |";
            SecondColFourthRow = "            |";
            SecondColFifthRow = "             |";


            ThirdColFirstRow = "             |";
            ThirdColSecondRow = "             |";
            ThirdColThirdRow = "             |";
            ThirdColFourthRow = "             |";
            ThirdColFifthRow = "             |";

            PirmaEilute = $"1eil.{FirstColFirstRow}{SecondColFirstRow}{ThirdColFirstRow}";
            AntraEilute = $"2eil.{FirstColSecondRow}{SecondColSecondRow}{ThirdColSecondRow}";
            TreciaEilute = $"3eil.{FirstColThirdRow}{SecondColThirdRow}{ThirdColThirdRow}";
            KetvirtaEilute = $"4eil.{FirstColFourthRow}{SecondColFourthRow}{ThirdColFourthRow}";
            PenktaEilute = $"5eil.{FirstColFifthRow}{SecondColFifthRow}{ThirdColFifthRow}";
            ApatineEilute = $"       ---1stulp---  ---2stulp---  ---3stulp---           ";


            Console.WriteLine(PirmaEilute);
            Console.WriteLine(AntraEilute);
            Console.WriteLine(TreciaEilute);
            Console.WriteLine(KetvirtaEilute);
            Console.WriteLine(PenktaEilute);
            Console.WriteLine(ApatineEilute);

            Console.ReadLine();


            //Trecia uzduotis

            //Visuosuose stulpeliuose lieka tik santykiniai atstumai vienas nuo kito, 8, 13 ir 13 atitinkamai.


            FirstColFirstRow = "        |";
            FirstColSecondRow = "        |";
            FirstColThirdRow = "        |";
            FirstColFourthRow = "        |";
            FirstColFifthRow = "        |";

            SecondColFirstRow = "             |";
            SecondColSecondRow = "             |";
            SecondColThirdRow = "             |";
            SecondColFourthRow = "             |";
            SecondColFifthRow = "             |";


            ThirdColFirstRow = "             |";
            ThirdColSecondRow = "             |";
            ThirdColThirdRow = "             |";
            ThirdColFourthRow = "             |";
            ThirdColFifthRow = "             |";

            PirmaEilute = $"1eil.{FirstColFirstRow}{SecondColFirstRow}{ThirdColFirstRow}";
            AntraEilute = $"2eil.{FirstColSecondRow}{SecondColSecondRow}{ThirdColSecondRow}";
            TreciaEilute = $"3eil.{FirstColThirdRow}{SecondColThirdRow}{ThirdColThirdRow}";
            KetvirtaEilute = $"4eil.{FirstColFourthRow}{SecondColFourthRow}{ThirdColFourthRow}";
            PenktaEilute = $"5eil.{FirstColFifthRow}{SecondColFifthRow}{ThirdColFifthRow}";
            ApatineEilute = $"       ---1stulp---  ---2stulp---  ---3stulp---           ";


            Console.WriteLine(PirmaEilute);
            Console.WriteLine(AntraEilute);
            Console.WriteLine(TreciaEilute);
            Console.WriteLine(KetvirtaEilute);
            Console.WriteLine(PenktaEilute);
            Console.WriteLine(ApatineEilute);

            Console.ReadLine();


            //Ketvirta uzduotis

            //Pirmo stulpelio paskutines eilutes atstumas sumazeja keturiais zingsniais iki 4. Antro stulpelio penktos eilutes
            //atstumas sumazeja 8 zignsiais iki 5. Trecio stulpelio penktos eilutes atstumas sumazeja 8 zingsniais iki 5 


            FirstColFirstRow = "        |";
            FirstColSecondRow = "        |";
            FirstColThirdRow = "        |";
            FirstColFourthRow = "        |";
            FirstColFifthRow = "    ####|####";

            SecondColFirstRow = "             |";
            SecondColSecondRow = "             |";
            SecondColThirdRow = "             |";
            SecondColFourthRow = "             |";
            SecondColFifthRow = "     ####|####";


            ThirdColFirstRow = "             |";
            ThirdColSecondRow = "             |";
            ThirdColThirdRow = "             |";
            ThirdColFourthRow = "             |";
            ThirdColFifthRow = "     ####|####";

            PirmaEilute = $"1eil.{FirstColFirstRow}{SecondColFirstRow}{ThirdColFirstRow}";
            AntraEilute = $"2eil.{FirstColSecondRow}{SecondColSecondRow}{ThirdColSecondRow}";
            TreciaEilute = $"3eil.{FirstColThirdRow}{SecondColThirdRow}{ThirdColThirdRow}";
            KetvirtaEilute = $"4eil.{FirstColFourthRow}{SecondColFourthRow}{ThirdColFourthRow}";
            PenktaEilute = $"5eil.{FirstColFifthRow}{SecondColFifthRow}{ThirdColFifthRow}";
            ApatineEilute = $"       ---1stulp---  ---2stulp---  ---3stulp---           ";


            Console.WriteLine(PirmaEilute);
            Console.WriteLine(AntraEilute);
            Console.WriteLine(TreciaEilute);
            Console.WriteLine(KetvirtaEilute);
            Console.WriteLine(PenktaEilute);
            Console.WriteLine(ApatineEilute);

            Console.ReadLine();


            //Penkta uzduotis

            //Pirmo stulpelio atstumas lieka toks pats kaip praeitoje uzduotyje. Antro stulpelio ketvirta eilute padidina
            //atstuma vienu zingsniu iki 6. Trecio stulpelio trecia eilute sumazina atstumavienu zignsiu iki 12.
            //Trecio stulpelio ketvirta eilute padidina atstuma trimis zignsiais nuo 5 iki 8.


            FirstColFirstRow = "        |";
            FirstColSecondRow = "        |";
            FirstColThirdRow = "        |";
            FirstColFourthRow = "        |";
            FirstColFifthRow = "    ####|####";

            SecondColFirstRow = "             |";
            SecondColSecondRow = "             |";
            SecondColThirdRow = "             |";
            SecondColFourthRow = "             |";
            SecondColFifthRow = "      ###|###";


            ThirdColFirstRow = "             |";
            ThirdColSecondRow = "             |";
            ThirdColThirdRow = "             |";
            ThirdColFourthRow = "            #|#";
            ThirdColFifthRow = "        ##|##";

            PirmaEilute = $"1eil.{FirstColFirstRow}{SecondColFirstRow}{ThirdColFirstRow}";
            AntraEilute = $"2eil.{FirstColSecondRow}{SecondColSecondRow}{ThirdColSecondRow}";
            TreciaEilute = $"3eil.{FirstColThirdRow}{SecondColThirdRow}{ThirdColThirdRow}";
            KetvirtaEilute = $"4eil.{FirstColFourthRow}{SecondColFourthRow}{ThirdColFourthRow}";
            PenktaEilute = $"5eil.{FirstColFifthRow}{SecondColFifthRow}{ThirdColFifthRow}";
            ApatineEilute = $"       ---1stulp---  ---2stulp---  ---3stulp---           ";


            Console.WriteLine(PirmaEilute);
            Console.WriteLine(AntraEilute);
            Console.WriteLine(TreciaEilute);
            Console.WriteLine(KetvirtaEilute);
            Console.WriteLine(PenktaEilute);
            Console.WriteLine(ApatineEilute);

            Console.ReadLine();

            //Sesta uzduotis

            //Pirmos stulpelio ketvirtoje eiluteje sumaziname atstuma nuo 8 iki 7, del atsiradusio elemento.
            //Antro stulpelio ketvrtoje eiluteje sumaziname atstuma nuo 13 iki 12.


            FirstColFirstRow = "        |";
            FirstColSecondRow = "        |";
            FirstColThirdRow = "        |";
            FirstColFourthRow = "       #|#";
            FirstColFifthRow = "    ####|####";

            SecondColFirstRow = "             |";
            SecondColSecondRow = "             |";
            SecondColThirdRow = "             |";
            SecondColFourthRow = "            |";
            SecondColFifthRow = "      ###|###";


            ThirdColFirstRow = "             |";
            ThirdColSecondRow = "             |";
            ThirdColThirdRow = "             |";
            ThirdColFourthRow = "            #|#";
            ThirdColFifthRow = "        ##|##";

            PirmaEilute = $"1eil.{FirstColFirstRow}{SecondColFirstRow}{ThirdColFirstRow}";
            AntraEilute = $"2eil.{FirstColSecondRow}{SecondColSecondRow}{ThirdColSecondRow}";
            TreciaEilute = $"3eil.{FirstColThirdRow}{SecondColThirdRow}{ThirdColThirdRow}";
            KetvirtaEilute = $"4eil.{FirstColFourthRow}{SecondColFourthRow}{ThirdColFourthRow}";
            PenktaEilute = $"5eil.{FirstColFifthRow}{SecondColFifthRow}{ThirdColFifthRow}";
            ApatineEilute = $"       ---1stulp---  ---2stulp---  ---3stulp---           ";


            Console.WriteLine(PirmaEilute);
            Console.WriteLine(AntraEilute);
            Console.WriteLine(TreciaEilute);
            Console.WriteLine(KetvirtaEilute);
            Console.WriteLine(PenktaEilute);
            Console.WriteLine(ApatineEilute);

            Console.ReadLine();


            //Septinta uzduotis


            //Pirmos eilutes atstumai lieka tokie patys.
            //Antro stulpelio pirmos antros ir trecios eilutes atstumai sumazeja 2 zignsiais iki 11.
            //Ketvirtos eilutes atstumas sumazeja 2 zingisniai iki 10;
            //Penktos eilutes ketvirtos eilutes atstumas sumazeja iki 7;
            //Trecio stulpelio pirmos antros ir trecios eilutes atstumai sumazeja per 2 iki 11
            //Trecio stulpleio ketvirtos eilutes atstumas sumazeja per viena
            //Penktor stulpelio atstumas padidejo per viena

            FirstColFirstRow = "        |";
            FirstColSecondRow = "        |";
            FirstColThirdRow = "        |";
            FirstColFourthRow = "       #|#";
            FirstColFifthRow = "    ####|####";

            SecondColFirstRow = "           ##|##";
            SecondColSecondRow = "           ##|##";
            SecondColThirdRow = "           ##|##";
            SecondColFourthRow = "          ##|##";
            SecondColFifthRow = "       ##|##";


            ThirdColFirstRow = "           |";
            ThirdColSecondRow = "           |";
            ThirdColThirdRow = "           |";
            ThirdColFourthRow = "          #|#";
            ThirdColFifthRow = "         ##|##";
            
            PirmaEilute = $"1eil.{FirstColFirstRow}{SecondColFirstRow}{ThirdColFirstRow}";
            AntraEilute = $"2eil.{FirstColSecondRow}{SecondColSecondRow}{ThirdColSecondRow}";
            TreciaEilute = $"3eil.{FirstColThirdRow}{SecondColThirdRow}{ThirdColThirdRow}";
            KetvirtaEilute = $"4eil.{FirstColFourthRow}{SecondColFourthRow}{ThirdColFourthRow}";
            PenktaEilute = $"5eil.{FirstColFifthRow}{SecondColFifthRow}{ThirdColFifthRow}";
            ApatineEilute = $"       ---1stulp---  ---2stulp---  ---3stulp---           ";


            Console.WriteLine(PirmaEilute);
            Console.WriteLine(AntraEilute);
            Console.WriteLine(TreciaEilute);
            Console.WriteLine(KetvirtaEilute);
            Console.WriteLine(PenktaEilute);
            Console.WriteLine(ApatineEilute);

            Console.ReadLine();

            //Astunta uzduotis


            //Pirmi du stulpeliai lieka su piriminiais atstumais, 8 ir 13 atitinkamai.
            //Trecio stulpelio pirma eilute irgi lieka per 13 zingsniu nuo antro stulpelio
            //Kitos eilutes mazina atstuma tiek kiek dideja elementu skaicius

            FirstColFirstRow = "        |";
            FirstColSecondRow = "        |";
            FirstColThirdRow = "        |";
            FirstColFourthRow = "        |";
            FirstColFifthRow = "        |";

            SecondColFirstRow = "             |";
            SecondColSecondRow = "             |";
            SecondColThirdRow = "             |";
            SecondColFourthRow = "             |";
            SecondColFifthRow = "             |";


            ThirdColFirstRow = "             |";
            ThirdColSecondRow = "            #|#";
            ThirdColThirdRow = "           ##|##";
            ThirdColFourthRow = "          ###|###";
            ThirdColFifthRow = "         ####|####";

            PirmaEilute = $"1eil.{FirstColFirstRow}{SecondColFirstRow}{ThirdColFirstRow}";
            AntraEilute = $"2eil.{FirstColSecondRow}{SecondColSecondRow}{ThirdColSecondRow}";
            TreciaEilute = $"3eil.{FirstColThirdRow}{SecondColThirdRow}{ThirdColThirdRow}";
            KetvirtaEilute = $"4eil.{FirstColFourthRow}{SecondColFourthRow}{ThirdColFourthRow}";
            PenktaEilute = $"5eil.{FirstColFifthRow}{SecondColFifthRow}{ThirdColFifthRow}";
            ApatineEilute = $"       ---1stulp---  ---2stulp---  ---3stulp---           ";


            Console.WriteLine(PirmaEilute);
            Console.WriteLine(AntraEilute);
            Console.WriteLine(TreciaEilute);
            Console.WriteLine(KetvirtaEilute);
            Console.WriteLine(PenktaEilute);
            Console.WriteLine(ApatineEilute);

            Console.ReadLine();

            //Devinta uzduotis


            FirstColFirstRow = "        |";
            FirstColSecondRow = "        |";
            FirstColThirdRow = "        |";
            FirstColFourthRow = "        |";
            FirstColFifthRow = "        |";

            SecondColFirstRow = "             |";
            SecondColSecondRow = "             |";
            SecondColThirdRow = "             |";
            SecondColFourthRow = "             |";
            SecondColFifthRow = "             |";


            ThirdColFirstRow = "             |";
            ThirdColSecondRow = "            #|#";
            ThirdColThirdRow = "           ##|##";
            ThirdColFourthRow = "          ###|###";
            ThirdColFifthRow = "         ####|####";

            //Pakeistas zenklas treciame stulpelyje visuose eilutese su .Replace komanda

            ThirdColFirstRow = ThirdColFirstRow.Replace("#", "\"");
            ThirdColSecondRow = ThirdColSecondRow.Replace("#", "\"");
            ThirdColThirdRow = ThirdColThirdRow.Replace("#", "\"");
            ThirdColFourthRow = ThirdColFourthRow.Replace("#", "\"");
            ThirdColFifthRow = ThirdColFifthRow.Replace("#", "\"");

            PirmaEilute = $"1eil.{FirstColFirstRow}{SecondColFirstRow}{ThirdColFirstRow}";
            AntraEilute = $"2eil.{FirstColSecondRow}{SecondColSecondRow}{ThirdColSecondRow}";
            TreciaEilute = $"3eil.{FirstColThirdRow}{SecondColThirdRow}{ThirdColThirdRow}";
            KetvirtaEilute = $"4eil.{FirstColFourthRow}{SecondColFourthRow}{ThirdColFourthRow}";
            PenktaEilute = $"5eil.{FirstColFifthRow}{SecondColFifthRow}{ThirdColFifthRow}";
            ApatineEilute = $"       ---1stulp---  ---2stulp---  ---3stulp---           ";


            Console.WriteLine(PirmaEilute);
            Console.WriteLine(AntraEilute);
            Console.WriteLine(TreciaEilute);
            Console.WriteLine(KetvirtaEilute);
            Console.WriteLine(PenktaEilute);
            Console.WriteLine(ApatineEilute);

            Console.ReadLine();


            //Desimta Uzduotis

          
            //Sukurti kintamieji suagoti naujiems pirmu eiluciu zenklams
            //Naudotojas iveda po viena simboli kiekvienai eilutei
            //Pakeisti pirmu eiluciu kintamieji, kad atvaizduotu simbolius tinkamuose vietose

            Console.WriteLine($"Irasykite pirmo stulpelio pirmos eilutes zenkla:");
            string EditFirstColFirstRow = Console.ReadLine();
            Console.WriteLine($"{EditFirstColFirstRow}");
            Console.WriteLine($"Irasykite antro stulpelio pirmos eilutes zenkla:");
            string EditSecondColFirstRow = Console.ReadLine();
            Console.WriteLine($"{EditSecondColFirstRow}");
            Console.WriteLine($"Irasykite trecio stulpelio pirmos eilutes zenkla:");
            string EditThirdColFirstRow = Console.ReadLine();
            Console.WriteLine($"{EditThirdColFirstRow}");

            FirstColFirstRow = "        " + EditFirstColFirstRow;
            FirstColSecondRow = "        |";
            FirstColThirdRow = "        |";
            FirstColFourthRow = "        |";
            FirstColFifthRow = "        |";

            SecondColFirstRow = "             " + EditSecondColFirstRow;
            SecondColSecondRow = "             |";
            SecondColThirdRow = "             |";
            SecondColFourthRow = "             |";
            SecondColFifthRow = "             |";


            ThirdColFirstRow = "             " + EditThirdColFirstRow;
            ThirdColSecondRow = "            #|#";
            ThirdColThirdRow = "           ##|##";
            ThirdColFourthRow = "          ###|###";
            ThirdColFifthRow = "         ####|####";

            

            ThirdColFirstRow = ThirdColFirstRow.Replace("#", "\"");
            ThirdColSecondRow = ThirdColSecondRow.Replace("#", "\"");
            ThirdColThirdRow = ThirdColThirdRow.Replace("#", "\"");
            ThirdColFourthRow = ThirdColFourthRow.Replace("#", "\"");
            ThirdColFifthRow = ThirdColFifthRow.Replace("#", "\"");

            PirmaEilute = $"1eil.{FirstColFirstRow}{SecondColFirstRow}{ThirdColFirstRow}";
            AntraEilute = $"2eil.{FirstColSecondRow}{SecondColSecondRow}{ThirdColSecondRow}";
            TreciaEilute = $"3eil.{FirstColThirdRow}{SecondColThirdRow}{ThirdColThirdRow}";
            KetvirtaEilute = $"4eil.{FirstColFourthRow}{SecondColFourthRow}{ThirdColFourthRow}";
            PenktaEilute = $"5eil.{FirstColFifthRow}{SecondColFifthRow}{ThirdColFifthRow}";
            ApatineEilute = $"       ---1stulp---  ---2stulp---  ---3stulp---           ";


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