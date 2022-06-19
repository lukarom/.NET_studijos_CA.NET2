
Console.WriteLine("Hello, Kelias");

Console.WriteLine("Iveskite atstuma kilometrais tarp tasku A ir B: ");
var kelioAtstumas = int.Parse(Console.ReadLine());
Console.WriteLine("Iveskite A transporto priemones greiti: ");
var greitisA = int.Parse(Console.ReadLine());
Console.WriteLine("Iveskite B transporto priemones greiti: ");
var greitisB = int.Parse(Console.ReadLine());

//skaiciuojamas susitikimo laikas sekundemis:
var susitikimoLaikas = kelioAtstumas*1000 / ((greitisA * (float)5 / 18) + (greitisB * (float)5 / 18));
//skaiciuojamas susitikimo laikas valandomis:
var susitikimoLaikasH = kelioAtstumas / ((float)greitisA + (float)greitisB);
//skaiciuojamas susitikimo atstumas metrais, kovertuojame greitiA i m/s ir padauginame is laiko
var susitikimoAtstumas = (greitisA * (float)5 / 18) * susitikimoLaikas;
//skaiciuojamas susitikimo laikas kilometrais. Greiti km/h padauginame is susitikimo laiko valandomis
var susitikimoAtstumasKm = greitisA * susitikimoLaikasH;

//isvedame i ekrana susitikimo atstuma metrais ir susitikimo atstuma kilometrais
Console.WriteLine("susitikimo atstumas metrais: {0:0.00}", susitikimoAtstumas);
Console.WriteLine("susitikimo atstumas kilometrais: {0:0.00}", susitikimoAtstumasKm);

//isvedame i ekrana  susitikimo laika sekundemis
Console.WriteLine($"automobiliai susitiko po {(int)susitikimoLaikas} sekundziu");


//Skaiciuojame susitikimo laikus abieju auotomobiliu, atstuma pakeiciame i metrus, greiti i m/s,
//padaliname atstuma is greicio ir dar padaliname is 60 kad paskaiciuoti kelio laiko minutemis
var laikasA = (kelioAtstumas*1000 / (greitisA * 5 / 18))/60;
var laikasB = (kelioAtstumas*1000 / (greitisB * 5 / 18))/60;

//Isvedame i ekrana susitikimo laikus minutemis
Console.WriteLine($"Automobilis A tiksla pasieks uz {laikasA} minuciu");
Console.WriteLine($"Automobilis A tiksla pasieks uz {laikasB} minuciu" +
    $"");

//Paskaiciuojama ir isvedame i ekrana CO2 iskyrima
var Co2Norma = 95;
var Co2 = kelioAtstumas * 2 * Co2Norma;
Console.WriteLine($"Abu automobiliai per visa kelia isnaudojo {Co2} gramu CO2");


//Piesiame segementu atstumus. Daliname visa kelio atstuma is 20(segmentu), kad zinoti pirmo segmento atstuma. Sekancius segemento atstumo dauginame is atitinkamo segemento skaiciaus
var atstumasTarpSegmentu = "     ";
var pirmoSegmAtstumas = kelioAtstumas / 20;
var firstSegment5 = $" {0,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas,-3}{atstumasTarpSegmentu}{2 * pirmoSegmAtstumas,-3}{atstumasTarpSegmentu}{3 * pirmoSegmAtstumas,-3}{atstumasTarpSegmentu}{4 * pirmoSegmAtstumas,-3}{atstumasTarpSegmentu}{5 * pirmoSegmAtstumas,-3}{atstumasTarpSegmentu}";
var firstSegment10 = $"{pirmoSegmAtstumas * 6 ,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas * 7 ,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas * 8 ,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas * 9 ,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas * 10,-3}{atstumasTarpSegmentu}";
var firstSegment15 = $"{pirmoSegmAtstumas * 11,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas * 12,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas * 13,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas * 14,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas * 15,-3}{atstumasTarpSegmentu}";
var firstSegment20 = $"{pirmoSegmAtstumas * 16,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas * 17,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas*18  ,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas*19  ,-3}{atstumasTarpSegmentu}{pirmoSegmAtstumas*20  ,-3}";
//Isvedame i ekrana segementu atstumus nuo tasko A;
Console.WriteLine($"{firstSegment5}{firstSegment10}{firstSegment15}{firstSegment20}");


var pirmoSegmAtstumasSpr = Convert.ToString(pirmoSegmAtstumas);
pirmoSegmAtstumasSpr = " | ";

//Piesiame antra grafiko linija su " | " vertikaliais bruksniais
var secondSegment5 = $"{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}";
var secondSegment10 = $"{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}";
var secondSegment15 = $"{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}";
var secondSegment20 = $"{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }{atstumasTarpSegmentu}{pirmoSegmAtstumasSpr }";
//Isvedame dvi tokias linija viena paskui kita
Console.WriteLine($"{secondSegment5}" +
                   $"{secondSegment10}" +
                   $"{secondSegment15}" +
                   $"{secondSegment20}");
Console.WriteLine($"{secondSegment5}" +
                   $"{secondSegment10}" +
                   $"{secondSegment15}" +
                   $"{secondSegment20}");

//palyginame segmento atstymus su susitikimo astumu plius vieno segmento atstumas.
//Si patikirnima naudosime kai reikes pazymeti susitikimo vieta.

bool arSusitikimoTaske1 = kelioAtstumas / 20 > susitikimoAtstumasKm + kelioAtstumas / 20;
bool arSusitikimoTaske2 = kelioAtstumas / 20 * 2 > susitikimoAtstumasKm + kelioAtstumas / 20;
bool arSusitikimoTaske3 = kelioAtstumas / 20 * 3 > susitikimoAtstumasKm + kelioAtstumas / 20;
bool arSusitikimoTaske4 = kelioAtstumas / 20 * 4 > susitikimoAtstumasKm + kelioAtstumas / 20;
bool arSusitikimoTaske5= kelioAtstumas  / 20 * 5 > susitikimoAtstumasKm + kelioAtstumas / 20;
bool arSusitikimoTaske6 = kelioAtstumas / 20 * 6 > susitikimoAtstumasKm + kelioAtstumas / 20;
bool arSusitikimoTaske7 = kelioAtstumas / 20 * 7 > susitikimoAtstumasKm + kelioAtstumas / 20;
bool arSusitikimoTaske8 = kelioAtstumas / 20 * 8 > susitikimoAtstumasKm + kelioAtstumas / 20;
bool arSusitikimoTaske9 = kelioAtstumas / 20 * 9 > susitikimoAtstumasKm + kelioAtstumas / 20;
bool arSusitikimoTaske10 = kelioAtstumas / 20  * 10> susitikimoAtstumasKm + kelioAtstumas / 20;
bool arSusitikimoTaske11 = kelioAtstumas / 20  * 11> susitikimoAtstumasKm + kelioAtstumas / 20;
bool arSusitikimoTaske12 = kelioAtstumas / 20  * 12> susitikimoAtstumasKm + kelioAtstumas / 20;
bool arSusitikimoTaske13 = kelioAtstumas / 20  * 13> susitikimoAtstumasKm + kelioAtstumas / 20;
bool arSusitikimoTaske14 = kelioAtstumas / 20  * 14> susitikimoAtstumasKm + kelioAtstumas / 20;
bool arSusitikimoTaske15 = kelioAtstumas / 20  * 15> susitikimoAtstumasKm + kelioAtstumas / 20;
bool arSusitikimoTaske16 = kelioAtstumas / 20  * 16> susitikimoAtstumasKm + kelioAtstumas / 20;
bool arSusitikimoTaske17 = kelioAtstumas / 20  * 17> susitikimoAtstumasKm + kelioAtstumas / 20;
bool arSusitikimoTaske18 = kelioAtstumas / 20  * 18> susitikimoAtstumasKm + kelioAtstumas / 20;
bool arSusitikimoTaske19 = kelioAtstumas / 20 *  19 > susitikimoAtstumasKm + kelioAtstumas / 20;
bool arSusitikimoTaske20 = kelioAtstumas > susitikimoAtstumasKm + kelioAtstumas / 20;


//darome dar viena palyginima, auksciau gauta bool palyginame su susitikimo kelio ir bendro segementu atstumu.
//Kol susitikimoAtstumasKm yra mazesnis uz kelioAtstumas/20 * [segmento atstumas] tol nupiesiame apatini bruksni. Taip pat palyginame su arSusitikimoTaske,
//kad nebutu piesiama V zyme tolimesniuose segmentuose

//pvz kelio atstumas yra 100km, o susitikimo atstumas 40km. kelioZyme1 is pirmo palyginimo gauname rezultata False,
//tada lyginame su arSusitikimoTaske1 ir gauname True, nes arSusitikimoTaske1 bus False
var kelioZyme1 = ((susitikimoAtstumasKm < kelioAtstumas / 20) == arSusitikimoTaske1).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme2 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 2) == arSusitikimoTaske2).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme3 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 3) == arSusitikimoTaske3).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme4 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 4) == arSusitikimoTaske4).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme5 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 5) == arSusitikimoTaske5).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme6 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 6) == arSusitikimoTaske6).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme7 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 7) == arSusitikimoTaske7).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme8 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 8) == arSusitikimoTaske8).ToString().Replace("True", "_").Replace("False", "V");
//kelio zymeje gauname pirmo palyginimo rezultata true ir palyginame su arSusitikimoTaske9 ir gauname false, todel nubraizoma zyme
var kelioZyme9 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 9) == arSusitikimoTaske9).ToString().Replace("True", "_").Replace("False", "V");
//toliau gauname True ir True is abieju paluginimu todel piesiama apatinis bruksnis
var kelioZyme10 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 10) == arSusitikimoTaske10).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme11 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 11) == arSusitikimoTaske11).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme12 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 12) == arSusitikimoTaske12).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme13 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 13) == arSusitikimoTaske13).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme14 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 14) == arSusitikimoTaske14).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme15 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 15) == arSusitikimoTaske15).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme16 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 16) == arSusitikimoTaske16).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme17 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 17) == arSusitikimoTaske17).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme18 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 18) == arSusitikimoTaske18).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme19 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 19) == arSusitikimoTaske19).ToString().Replace("True", "_").Replace("False", "V");
var kelioZyme20 = ((susitikimoAtstumasKm < kelioAtstumas) == arSusitikimoTaske20).ToString().Replace("True", "_").Replace("False", "V");

//sukuriame atskiras kintamasias kur per viduri istatome kelioZyme ir po 3 apatinius bruksnius is abieju pusiu
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


//sukuriamae string kintamuosius su A ir B taskais bei vertikaliu bruksniu
pirmoSegmAtstumasSpr = "|";
var pirmoSegmAtstumasSprA = "_A";
var pirmoSegmAtstumasSprB = "B_";

//Sukuriame piesimo karkasa kur sudedame visus kintamuosius 
var fourthSegment5 = $"{pirmoSegmAtstumasSprA}{atstumasTarpSegmentu1}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu2}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu3}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu4}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu5}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu6}";
var fourthSegment10 = $"{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu7}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu8}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu9}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu10}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu11}";
var fourthSegment15 = $"{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu12}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu13}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu14}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu15}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu16}";
var fourthSegment20 = $"{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu17}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu18}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu19}{pirmoSegmAtstumasSpr}{atstumasTarpSegmentu20}{pirmoSegmAtstumasSprB}";

//Isvedame i ekrana susitikimo atstumo zyme
Console.WriteLine($"{fourthSegment5}" +
                   $"{fourthSegment10}" +
                   $"{fourthSegment15}" +
                   $"{fourthSegment20}");

//Console.WriteLine($"{susitikimoAtstumas,6}km");
//var susitikimoAtstumoZyme = $"{susitikimoAtstumas}km";


//Sukuriame dar viena palyginimo salyga kuri patikrina ar susitikimoAtstumasKm yra mazesnis uz segmentu sumos atstuma,
//bei yra lygus su arSusitikimoTaske rezultatu
//Jeigu rezultatas false paliekame tuscia kintamaji string, jeigu true piesiame astuonis bruksnius
//iskyrus pirmojo segemento, kur piesiame keturis bruksnius
var susPatikrinimas1 = ((susitikimoAtstumasKm < kelioAtstumas / 20) == arSusitikimoTaske1).ToString().Replace ("False", "").Replace("True", "----");
var susPatikrinimas2  = ((susitikimoAtstumasKm < kelioAtstumas / 20* 2) == arSusitikimoTaske1).ToString().Replace("False", "").Replace("True", "--------");
var susPatikrinimas3  = ((susitikimoAtstumasKm < kelioAtstumas / 20* 3) == arSusitikimoTaske1).ToString().Replace("False", "").Replace("True", "--------");
var susPatikrinimas4  = ((susitikimoAtstumasKm < kelioAtstumas / 20* 4) == arSusitikimoTaske1).ToString().Replace("False", "").Replace("True", "--------");
var susPatikrinimas5  = ((susitikimoAtstumasKm < kelioAtstumas / 20* 5) == arSusitikimoTaske1).ToString().Replace("False", "").Replace("True", "--------");
var susPatikrinimas6  = ((susitikimoAtstumasKm < kelioAtstumas / 20* 6) == arSusitikimoTaske1).ToString().Replace("False", "").Replace("True", "--------");
var susPatikrinimas7  = ((susitikimoAtstumasKm < kelioAtstumas / 20* 7) == arSusitikimoTaske1).ToString().Replace("False", "").Replace("True", "--------");
var susPatikrinimas8  = ((susitikimoAtstumasKm < kelioAtstumas / 20* 8) == arSusitikimoTaske1).ToString().Replace("False", "").Replace("True", "--------");
var susPatikrinimas9  = ((susitikimoAtstumasKm < kelioAtstumas / 20* 9) == arSusitikimoTaske1).ToString().Replace("False", "").Replace("True", "--------");
var susPatikrinimas10 = ((susitikimoAtstumasKm < kelioAtstumas / 20* 10)== arSusitikimoTaske1).ToString().Replace("False", "").Replace("True", "--------");
var susPatikrinimas11 = ((susitikimoAtstumasKm < kelioAtstumas / 20* 11)== arSusitikimoTaske1).ToString().Replace("False", "").Replace("True", "--------");
var susPatikrinimas12 = ((susitikimoAtstumasKm < kelioAtstumas / 20* 12)== arSusitikimoTaske1).ToString().Replace("False", "").Replace("True", "--------");
var susPatikrinimas13 = ((susitikimoAtstumasKm < kelioAtstumas / 20* 13)== arSusitikimoTaske1).ToString().Replace("False", "").Replace("True", "--------");
var susPatikrinimas14 = ((susitikimoAtstumasKm < kelioAtstumas / 20* 14)== arSusitikimoTaske1).ToString().Replace("False", "").Replace("True", "--------");
var susPatikrinimas15 = ((susitikimoAtstumasKm < kelioAtstumas / 20* 15)== arSusitikimoTaske1).ToString().Replace("False", "").Replace("True", "--------");
var susPatikrinimas16 = ((susitikimoAtstumasKm < kelioAtstumas / 20* 16)== arSusitikimoTaske1).ToString().Replace("False", "").Replace("True", "--------");
var susPatikrinimas17 = ((susitikimoAtstumasKm < kelioAtstumas / 20* 17)== arSusitikimoTaske1).ToString().Replace("False", "").Replace("True", "--------");
var susPatikrinimas18 = ((susitikimoAtstumasKm < kelioAtstumas / 20* 18)== arSusitikimoTaske1).ToString().Replace("False", "").Replace("True", "--------");
var susPatikrinimas19 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 19) == arSusitikimoTaske1).ToString().Replace("False", "").Replace("True", "--------");
var susPatikrinimas20 = ((susitikimoAtstumasKm < kelioAtstumas ) == arSusitikimoTaske1).ToString().Replace("False", "").Replace("True", "--------");


//auksciau gauta susPatikrinimas rezultatas isnaudojame dar vienoje salygoje.
//Siuo atveju jeigu gauname True rezultata tai arba paliekame tuscia string arba braizome 8 bruksnius
//Jeigu gauneme false tada piesiame septynis bruksnius su vertikalia linija pazyminti susitikimo atstuma
//Tokiu budu nupiesiame visa susitkimo atstumo atkarpa bei pazymime susitikimo atstumo pabaiga
var  susKelias1  = ((susitikimoAtstumasKm < kelioAtstumas / 20) == arSusitikimoTaske1).ToString().Replace("True", susPatikrinimas1).Replace("False", "---|");
var  susKelias2  = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 2) == arSusitikimoTaske2).ToString().Replace("True",   susPatikrinimas2 ).Replace("False", "-------|");
var  susKelias3  = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 3) == arSusitikimoTaske3).ToString().Replace("True",   susPatikrinimas3 ).Replace("False", "-------|");
var  susKelias4  = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 4) == arSusitikimoTaske4).ToString().Replace("True",   susPatikrinimas4 ).Replace("False", "-------|");
var  susKelias5  = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 5) == arSusitikimoTaske5).ToString().Replace("True",   susPatikrinimas5 ).Replace("False", "-------|");
var  susKelias6  = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 6) == arSusitikimoTaske6).ToString().Replace("True",   susPatikrinimas6 ).Replace("False", "-------|");
var  susKelias7  = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 7) == arSusitikimoTaske7).ToString().Replace("True",   susPatikrinimas7 ).Replace("False", "-------|");
var  susKelias8  = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 8) == arSusitikimoTaske8).ToString().Replace("True",   susPatikrinimas8 ).Replace("False", "-------|");
var  susKelias9  = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 9) == arSusitikimoTaske9).ToString().Replace("True",   susPatikrinimas9 ).Replace("False", "-------|");
var  susKelias10 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 10) == arSusitikimoTaske10).ToString().Replace("True", susPatikrinimas10).Replace("False", "-------|");
var  susKelias11 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 11) == arSusitikimoTaske11).ToString().Replace("True", susPatikrinimas11).Replace("False", "-------|");
var  susKelias12 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 12) == arSusitikimoTaske12).ToString().Replace("True", susPatikrinimas12).Replace("False", "-------|");
var  susKelias13 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 13) == arSusitikimoTaske13).ToString().Replace("True", susPatikrinimas13).Replace("False", "-------|");
var  susKelias14 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 14) == arSusitikimoTaske14).ToString().Replace("True", susPatikrinimas14).Replace("False", "-------|");
var  susKelias15 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 15) == arSusitikimoTaske15).ToString().Replace("True", susPatikrinimas15).Replace("False", "-------|");
var  susKelias16 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 16) == arSusitikimoTaske16).ToString().Replace("True", susPatikrinimas16).Replace("False", "-------|");
var  susKelias17 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 17) == arSusitikimoTaske17).ToString().Replace("True", susPatikrinimas17).Replace("False", "-------|");
var  susKelias18 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 18) == arSusitikimoTaske18).ToString().Replace("True", susPatikrinimas18).Replace("False", "-------|");
var  susKelias19 = ((susitikimoAtstumasKm < kelioAtstumas / 20 * 19) == arSusitikimoTaske19).ToString().Replace("True", susPatikrinimas19).Replace("False", "-------|");
var  susKelias20 = ((susitikimoAtstumasKm < kelioAtstumas) == arSusitikimoTaske20).ToString().Replace("True", susPatikrinimas20).Replace("False", "-------|");


//sudedame visas kintamuju reiksmes i karkasa bei isvedame i ekrana
var susKeliasA = "|";

var fifthSegment5 = $" {susKeliasA}{susKelias1}{susKelias2}{susKelias3}{susKelias4}{susKelias5}";
var fifthSegment10 = $"{susKelias6}{susKelias7}{susKelias8}{susKelias9}{susKelias10}";
var fifthSegment15 = $"{susKelias11}{susKelias12}{susKelias13}{susKelias14}{susKelias15}";
var fifthSegment20 = $"{susKelias16}{susKelias17}{susKelias18}{susKelias19}{susKelias20}";

var fullSegment = ($"{fifthSegment5}" +
                   $"{fifthSegment10}" +
                   $"{fifthSegment15}" +
                   $"{fifthSegment20}");


Console.WriteLine(fullSegment);
//Taip pat isvedame i ekrana susitikimo vieta, susitikimo laika, bendra kelio atstuma, abieju masinu susitikimo laika minutemis
Console.WriteLine("  susitikimo vieta {0:0.00}km",susitikimoAtstumasKm);
Console.WriteLine("  susitikimo laikas po {0:0.00}val.", susitikimoLaikasH);
Console.WriteLine($"\n |---------------------------------------------------------------------------{kelioAtstumas,5} km ---------------------------------------------------------------------------|");
Console.WriteLine($"\n |>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>{laikasA,5} min >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>|");
Console.WriteLine($" |<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<{laikasB,5} min <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<|");
