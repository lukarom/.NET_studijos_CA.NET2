
Console.WriteLine("Hello, Kelias");

Console.WriteLine("Iveskite atstuma kilometrais tarp tasku A ir B: ");
var kelioAtstumas = int.Parse(Console.ReadLine());
Console.WriteLine("Iveskite A transporto priemones greiti: ");
var greitisA = int.Parse(Console.ReadLine());
Console.WriteLine("Iveskite B transporto priemones greiti: ");
var greitisB = int.Parse(Console.ReadLine());

//skaiciuojamas susitikimo laikas:
var susitikimoLaikas = kelioAtstumas*1000 / ((greitisA * (float)5 / 18) + (greitisB * (float)5 / 18));
var susitikimoLaikasH = kelioAtstumas / (greitisA + greitisB);
//skaiciuojamas susitikimo atstumas metrais, kovertuojame greitiA i m/s ir padauginame it laiko
var susitikimoAtstumas = (greitisA * (float)5 / 18) * susitikimoLaikas;
var susitikimoAtstumasKm = greitisA * susitikimoLaikasH;

Console.WriteLine($"susitikimo atstumas metrais: {susitikimoAtstumas}");
Console.WriteLine($"susitikimo atstumas kilometrais: {susitikimoAtstumasKm}");

Console.WriteLine($"automobiliai susitiko po {susitikimoLaikas} sekundziu");


//Skaiciuojame laikus, atstuma pakeiciame i metrus, greiti i m/s,
//padaliname atstuma is greicio ir dar padaliname is 60 kad paskaiciuoti kelio laiko minutemis
var laikasA = (kelioAtstumas*1000 / (greitisA * (float)5 / 18))/60;
var laikasB = (kelioAtstumas*1000 / (greitisB * (float)5 / 18))/60;

Console.WriteLine($"Automobilis A tisla pasieks uz {laikasA} minuciu");
Console.WriteLine($"Automobilis A tisla pasieks uz {laikasB} minuciu" +
    $"");

var Co2Norma = 95;
var Co2 = kelioAtstumas * 2 * Co2Norma;
Console.WriteLine($"Abu automobiliai per visa kelia isnaudojo {Co2} gramu CO2");

var atstumasTarpSegmentu = "     ";
var pirmoSegmAtstumas = kelioAtstumas / 20;
var firstSegment5 = $" {0,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas,-3}{atstumasTarpSegmentu}{2 * pirmoSegmAtstumas,-3}{atstumasTarpSegmentu}{3 * pirmoSegmAtstumas,-3}{atstumasTarpSegmentu}{4 * pirmoSegmAtstumas,-3}{atstumasTarpSegmentu}{5 * pirmoSegmAtstumas,-3}{atstumasTarpSegmentu}";
var firstSegment10 = $"{pirmoSegmAtstumas * 6 ,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas * 7 ,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas * 8 ,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas * 9 ,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas * 10,-3}{atstumasTarpSegmentu}";
var firstSegment15 = $"{pirmoSegmAtstumas * 11,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas * 12,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas * 13,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas * 14,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas * 15,-3}{atstumasTarpSegmentu}";
var firstSegment20 = $"{pirmoSegmAtstumas * 16,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas * 17,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas*18  ,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas*19  ,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas*20  ,-3}";
Console.WriteLine($"{firstSegment5}{firstSegment10}{firstSegment15}{firstSegment20}");

var pirmoSegmAtstumasSpr = Convert.ToString(pirmoSegmAtstumas);
pirmoSegmAtstumasSpr = " | ";
var secondSegment5 = $"{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}";
var secondSegment10 = $"{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}";
var secondSegment15 = $"{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}";
var secondSegment20 = $"{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }";
Console.WriteLine($"{secondSegment5}" +
                   $"{secondSegment10}" +
                   $"{secondSegment15}" +
                   $"{secondSegment20}");
Console.WriteLine($"{secondSegment5}" +
                   $"{secondSegment10}" +
                   $"{secondSegment15}" +
                   $"{secondSegment20}");
var nukeliautoAtstumoZyme = "V";


var kelioZyme1 = (susitikimoAtstumasKm < kelioAtstumas / 20).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme2 = (susitikimoAtstumasKm < kelioAtstumas / 20 * 2).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme3 = (susitikimoAtstumasKm < kelioAtstumas / 20 * 3).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme4 = (susitikimoAtstumasKm < kelioAtstumas / 20 * 4).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme5 = (susitikimoAtstumasKm < kelioAtstumas / 20 * 5).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme6 = (susitikimoAtstumasKm < kelioAtstumas / 20 * 6).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme7 = (susitikimoAtstumasKm < kelioAtstumas / 20 * 7).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme8 = (susitikimoAtstumasKm < kelioAtstumas / 20 * 8).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme9 = (susitikimoAtstumasKm < kelioAtstumas / 20 * 9).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme10 = (susitikimoAtstumasKm < kelioAtstumas / 20 * 10).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme11 = (susitikimoAtstumasKm < kelioAtstumas / 20 * 11).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme12 = (susitikimoAtstumasKm < kelioAtstumas / 20 * 12).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme13 = (susitikimoAtstumasKm < kelioAtstumas / 20 * 13).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme14 = (susitikimoAtstumasKm < kelioAtstumas / 20 * 14).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme15 = (susitikimoAtstumasKm < kelioAtstumas / 20 * 15).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme16 = (susitikimoAtstumasKm < kelioAtstumas / 20 * 16).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme17 = (susitikimoAtstumasKm < kelioAtstumas / 20 * 17).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme18 = (susitikimoAtstumasKm < kelioAtstumas / 20 * 18).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme19 = (susitikimoAtstumasKm < kelioAtstumas / 20 * 19).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme20 = (susitikimoAtstumasKm < kelioAtstumas).ToString().Replace("True", "_").Replace("False", "V");

var atstumasTarpSegmentu1  =   $"___{kelioZyme1 }___";
var atstumasTarpSegmentu2  =   $"___{kelioZyme2 }___";
var atstumasTarpSegmentu3  =   $"___{kelioZyme3 }___";
var atstumasTarpSegmentu4  =   $"___{kelioZyme4 }___";
var atstumasTarpSegmentu5  =   $"___{kelioZyme5 }___";
var atstumasTarpSegmentu6  =   $"___{kelioZyme6 }___";
var atstumasTarpSegmentu7  =   $"___{kelioZyme7 }___";
var atstumasTarpSegmentu8  =   $"___{kelioZyme8 }___";
var atstumasTarpSegmentu9  =   $"___{kelioZyme9 }___";
var atstumasTarpSegmentu10 =   $"___{kelioZyme10}___";
var atstumasTarpSegmentu11 =   $"___{kelioZyme11}___";
var atstumasTarpSegmentu12 =   $"___{kelioZyme12}___";
var atstumasTarpSegmentu13 =   $"___{kelioZyme13}___";
var atstumasTarpSegmentu14 =   $"___{kelioZyme14}___";
var atstumasTarpSegmentu15 =   $"___{kelioZyme15}___";
var atstumasTarpSegmentu16 =   $"___{kelioZyme16}___";
var atstumasTarpSegmentu17 =   $"___{kelioZyme17}___";
var atstumasTarpSegmentu18  =  $"___{kelioZyme18}___";
var atstumasTarpSegmentu19 =   $"___{kelioZyme19}___";
var atstumasTarpSegmentu20 =   $"___{kelioZyme20}___";



pirmoSegmAtstumasSpr = "|";

var fourthSegment5 = $" {pirmoSegmAtstumasSpr}{atstumasTarpSegmentu1}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu2}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu3}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu4}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu5}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu6}";
var fourthSegment10 = $"{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu7}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu8}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu9}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu10}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu11}";
var fourthSegment15 = $"{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu12}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu13}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu14}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu15}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu16}";
var fourthSegment20 = $"{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu17}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu18}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu19}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu20}{pirmoSegmAtstumasSpr}";

Console.WriteLine($"{fourthSegment5}" +
                   $"{fourthSegment10}" +
                   $"{fourthSegment15}" +
                   $"{fourthSegment20}");



