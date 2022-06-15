
Console.WriteLine("Hello, Loginiai Operatoriai");

Console.WriteLine(" && (AND), || (OR), ! (NOT), ^ (XOR) ");

bool tiesa = true;
bool melas = !tiesa;

Console.WriteLine($"tiesa = {tiesa}");
Console.WriteLine($"melas = {melas}");
Console.WriteLine($"!melas = {!melas}");

Console.WriteLine("AND &&");
Console.WriteLine($"tiesa AND tiesa {tiesa && tiesa}");
Console.WriteLine($"tiesa AND melas {tiesa && melas}");
Console.WriteLine($"melas AND tiesa {melas && tiesa}");
Console.WriteLine($"melas AND melas {melas && melas}");

Console.WriteLine("OR ||");
Console.WriteLine($"tiesa OR tiesa {tiesa || tiesa}");
Console.WriteLine($"tiesa OR melas {tiesa || melas}");
Console.WriteLine($"melas OR tiesa {melas || tiesa}");
Console.WriteLine($"melas OR melas {melas || melas}");

Console.WriteLine("XOR ^");
Console.WriteLine($"tiesa XoR tiesa {tiesa ^ tiesa}");
Console.WriteLine($"tiesa XOR melas {tiesa ^ melas}");
Console.WriteLine($"melas XOR tiesa {melas ^ tiesa}");
Console.WriteLine($"melas XOR melas {melas ^ melas}");

Console.WriteLine("NAND ! &&");
Console.WriteLine($"tiesa NAND tiesa {!(tiesa && tiesa)}");
Console.WriteLine($"tiesa NAND melas {!(tiesa && melas)}");
Console.WriteLine($"melas NAND tiesa {!(melas && tiesa)}");
Console.WriteLine($"melas NAND melas {!(melas && melas)}");

Console.WriteLine("NOR ! ||");
Console.WriteLine($"tiesa NOR tiesa {!(tiesa || tiesa)}");
Console.WriteLine($"tiesa NOR melas {!(tiesa || melas)}");
Console.WriteLine($"melas NOR tiesa {!(melas || tiesa)}");
Console.WriteLine($"melas NOR melas {!(melas || melas)}");

Console.WriteLine("NXOR ! ^");
Console.WriteLine($"tiesa NXoR tiesa {!(tiesa ^ tiesa)}");
Console.WriteLine($"tiesa NXOR melas {!(tiesa ^ melas)}");
Console.WriteLine($"melas NXOR tiesa {!(melas ^ tiesa)}");
Console.WriteLine($"melas NXOR melas {!(melas ^ melas)}");


/*Console.WriteLine("Iveskite du skaicius");
var pirmasSkaicius = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Pirmas skaicius: {pirmasSkaicius}");
var antrasSkaicius = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Antras skaicius: {antrasSkaicius}");

Console.WriteLine($"Ar lygus skaicisi: {pirmasSkaicius == antrasSkaicius}");*/


////// Antra uzduotis
/*Console.WriteLine("Iveskite du skaicius");
var pirmasSkaicius = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Pirmas skaicius: {pirmasSkaicius}");
var antrasSkaicius = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Antras skaicius: {antrasSkaicius}");
bool lyginisPirmas = pirmasSkaicius % 2 == 0;
bool lyginisAntras = antrasSkaicius % 2 == 0;


Console.WriteLine($"Ar lyginiai skaiciai: {lyginisPirmas && lyginisAntras}");*/





//a)

/*Console.Write($"{(false && false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false && false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true && false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true && false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true && true) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false && true) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false && true) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false && false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true && false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true && false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true && true) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false && true) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false && true) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false && false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true && false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true && false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true && true) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false && true) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false && true) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false && false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true && false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true && false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true && true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false && true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false && true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false && false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false && false).ToString().Replace("True", " - ").Replace("False", "_")}");

//b)
Console.WriteLine();
Console.Write($"{(false || false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false || false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  || false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  || false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  || true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false || true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false || true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false || false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  || false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  || false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  || true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false || true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false || true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false || false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  || false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  || false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  || true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false || true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false || true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false || false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  || false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  || false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  || true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false || true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false || true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false || false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false || false).ToString().Replace("True", "-").Replace("False", "_")}");

//c)
Console.WriteLine();
Console.Write($"{(false ^ false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false ^ false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  ^ false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  ^ false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  ^ true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false ^ true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false ^ true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false ^ false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  ^ false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  ^ false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  ^ true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false ^ true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false ^ true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false ^ false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  ^ false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  ^ false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  ^ true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false ^ true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false ^ true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false ^ false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  ^ false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  ^ false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(true  ^ true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false ^ true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false ^ true).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false ^ false).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(false ^ false).ToString().Replace("True", "-").Replace("False", "_")}");

//d)
Console.WriteLine();
Console.Write($"{(!(false && false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false && false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  && false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  && false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  && true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false && true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false && true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false && false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  && false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  && false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  && true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false && true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false && true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false && false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  && false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  && false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  && true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false && true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false && true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false && false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  && false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  && false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  && true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false && true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false && true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false && false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false && false)).ToString().Replace("True", "-").Replace("False", "_")}");

//e)
Console.WriteLine();
Console.Write($"{(!(false || false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false || false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  || false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  || false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  || true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false || true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false || true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false || false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  || false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  || false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  || true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false || true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false || true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false || false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  || false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  || false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  || true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false || true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false || true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false || false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  || false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  || false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(true  || true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false || true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false || true )).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false || false)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(false || false)).ToString().Replace("True", "-").Replace("False", "_")}");

//f)
Console.WriteLine();
Console.Write($"{(!false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false) .ToString().Replace("True", "-").Replace("False", "_")}");

//g
Console.WriteLine();
Console.Write($"{(!false || false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false || false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true  || false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true  || false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true  || true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false || true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false || true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false || false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true  || false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true  || false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true  || true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false || true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false || true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false || false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true  || false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true  || false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true  || true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false || true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false || true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false || false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true  || false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true  || false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!true  || true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false || true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false || true ) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false || false) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!false || false) .ToString().Replace("True", "-").Replace("False", "_")}");

//h)
Console.WriteLine();
Console.Write($"{(!((false || false) && false)) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((false || false) && false)) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((true  || false) && true )) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((true  || false) && true )) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((true  || true ) && true )) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((false || true ) && false)) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((false || true ) && false)) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((false || false) && false)) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((true  || false) && true )) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((true  || false) && true )) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((true  || true ) && true )) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((false || true ) && false)) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((false || true ) && false)) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((false || false) && false)) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((true  || false) && true )) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((true  || false) && true )) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((true  || true ) && true )) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((false || true ) && false)) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((false || true ) && false)) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((false || false) && false)) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((true  || false) && true )) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((true  || false) && true )) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((true  || true ) && true )) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((false || true ) && false)) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((false || true ) && false)) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((false || false) && false)) .ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!((false || false) && false)) .ToString().Replace("True", "-").Replace("False", "_")}");*/


// kita uzduotis

bool A1 = false;
bool A2 = false;
bool A3 = true;
bool A4 = true;

var B1 = false;
var B2 = true;
var B3 = false;
var B4 = true;

bool funkcija1 = A1 || B1;
bool funkcija2 = A2 || B2;
bool funkcija3 = A3 || B3;
bool funkcija4 = A4 || B4;

Console.WriteLine("a");
Console.WriteLine($"F(A,B) " +
    $"\n  {funkcija1.ToString().Replace("True", "1").Replace("False", "0")} " +
    $"\n  {funkcija2.ToString().Replace("True", "1").Replace("False", "0")} " +
    $"\n  {funkcija3.ToString().Replace("True", "1").Replace("False", "0")} " +
    $"\n  {funkcija4.ToString().Replace("True", "1").Replace("False", "0")} ");


A1 = false;
A2 = false;
A3 = true;
A4 = true;

B1 = false;
B2 = true;
B3 = false;
B4 = true;

//b
funkcija1 = !(A1 ^ B1) || !A1;
funkcija2 = !(A2 ^ B2) || !A2;
funkcija3 = !(A3 ^ B3) || !A3;
funkcija4 = !(A4 ^ B4) || !A4;

Console.WriteLine("b");
Console.WriteLine($"F(A,B) " +
    $"\n  {funkcija1.ToString().Replace("True", "1").Replace("False", "0")} " +
    $"\n  {funkcija2.ToString().Replace("True", "1").Replace("False", "0")} " +
    $"\n  {funkcija3.ToString().Replace("True", "1").Replace("False", "0")} " +
    $"\n  {funkcija4.ToString().Replace("True", "1").Replace("False", "0")} ");

//c

funkcija1 = A1 ^ B1 ^ !A1;
funkcija2 = A2 ^ B2 ^ !A2;
funkcija3 = A3 ^ B3 ^ !A3;
funkcija4 = A4 ^ B4 ^ !A4;

Console.WriteLine("b");
Console.WriteLine($"F(A,B) " +
    $"\n  {funkcija1.ToString().Replace("True", "1").Replace("False", "0")} " +
    $"\n  {funkcija2.ToString().Replace("True", "1").Replace("False", "0")} " +
    $"\n  {funkcija3.ToString().Replace("True", "1").Replace("False", "0")} " +
    $"\n  {funkcija4.ToString().Replace("True", "1").Replace("False", "0")} ");

//d
A1 = false;
A2 = false;
A3 = false;
A4 = false;
bool A5 = true;
bool A6 = true;
bool A7 = true;
bool A8 = true;

B1 = false;
B2 = false;
B3 = true;
B4 = true;
bool B5 = false;
bool B6 = false;
bool B7 = true;
bool B8 = true;

bool C1 = false;
bool C2 = true;
bool C3 = false;
bool C4 = true;
bool C5 = false;
bool C6 = true;
bool C7 = false;
bool C8 = true;

funkcija1 =      !A1 && B1 && C1;
funkcija2 =      !A2 && B2 && C2;
funkcija3 =      !A3 && B3 && C3;
funkcija4 =      !A4 && B4 && C4;
bool funkcija5 = !A5 && B5 && C5;
bool funkcija6 = !A6 && B2 && C6;
bool funkcija7 = !A7 && B3 && C7;
bool funkcija8 = !A8 && B4 && C8;

Console.WriteLine("b");
Console.WriteLine($"F(A,B) " +
    $"\n  {funkcija1.ToString().Replace("True", "1").Replace("False", "0")} " +
    $"\n  {funkcija2.ToString().Replace("True", "1").Replace("False", "0")} " +
    $"\n  {funkcija3.ToString().Replace("True", "1").Replace("False", "0")} " +
    $"\n  {funkcija4.ToString().Replace("True", "1").Replace("False", "0")} " +
    $"\n  {funkcija5.ToString().Replace("True", "1").Replace("False", "0")} " +
    $"\n  {funkcija6.ToString().Replace("True", "1").Replace("False", "0")} " +
    $"\n  {funkcija7.ToString().Replace("True", "1").Replace("False", "0")} " +
    $"\n  {funkcija8.ToString().Replace("True", "1").Replace("False", "0")} ");