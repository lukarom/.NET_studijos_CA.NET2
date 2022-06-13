
using System.Text;

Console.WriteLine("Hello, Priskyrimo Operatoriai! = += -= *= /=");
int skaicius;
int kitasskaicius = 10;
int nelyginisSkaicius = 5;
skaicius = 10;
kitasskaicius = skaicius;
Console.WriteLine($"skaicius = {skaicius}, kitasskaicius = {kitasskaicius}");

kitasskaicius += nelyginisSkaicius; //kitasskaicius = kitasskaicius + nelyginisskaicius
Console.WriteLine($"kitasskaicius = {kitasskaicius}");

kitasskaicius -= nelyginisSkaicius; //kitasskaicius = kitasskaicius - nelyginisskaicius
Console.WriteLine($"kitasskaicius = {kitasskaicius}");

kitasskaicius *= nelyginisSkaicius; //kitasskaicius = kitasskaicius * nelyginisskaicius
Console.WriteLine($"kitasskaicius = {kitasskaicius}");

kitasskaicius = 21;

kitasskaicius /= nelyginisSkaicius; //kitasskaicius = kitasskaicius / nelyginisskaicius
Console.WriteLine($"kitasskaicius = {kitasskaicius}");

double doubleSkaicius = 21;
doubleSkaicius /= (double)nelyginisSkaicius; //doubleskaicius dalinamas is integer skaiciaus
Console.WriteLine($"doubleskaicius = {doubleSkaicius}");

Console.WriteLine("Hello, Priskyrimo Operatoriai! + - * / % ++ --");

//Sudetis
int suma = skaicius + kitasskaicius;

Console.WriteLine("  sudetis = skaicius + kitasskaicius = {0}", suma);

//Atimtis 
int atimtis = skaicius - kitasskaicius;
Console.WriteLine("  sudetis = skaicius - kitasskaicius = {0}", atimtis);

//Daugyba
int daugyba = skaicius * kitasskaicius;
Console.WriteLine("  sudetis = skaicius * kitasskaicius = {0}", daugyba);

//Dalyba
double dalyba1 = (double)skaicius / kitasskaicius;
Console.WriteLine("  sudetis = skaicius / kitasskaicius = {0}", dalyba1);

//Dalyba su liekana

var dalybaSuLiekana = nelyginisSkaicius % 2;
Console.WriteLine($"   dalybaSuLiekana = nelyginisSkaicius %2 = {dalybaSuLiekana}");

//skaicius ++
skaicius++;
Console.WriteLine($"     skaicius={skaicius}");

//skaicius--
skaicius--;
Console.WriteLine($"    skaicius={skaicius}");


// Trapecijos ploto skaiciavimas
double side1 = 5.5;
double side2 = 3.25;
double height = 4.6;

double area = (side1 + side2) / 2 * height;
double area1 = (side1 + side2) / 2 * height;

Console.OutputEncoding = Encoding.UTF8;
int nulis = 0;
int int10 = 10;
long long10 = 10;
double double10 = 10;
//Console.WriteLine($"int10 /nulis = {int10/nulis}"); // luzta

///Console.WriteLine($"long10 /nulis = {long10 / nulis}"); // luzta

Console.WriteLine($"double10 /nulis = {double10 / nulis}"); // grazina begalybe - ty begalybes implementacija

double a1 = double.NaN;

//+++++++++ Overflow and Underflow  // geriau uzdeti varnele properties->program->advanced
short s1 = 30_000;
short s2 = 30_000;
short s3 = (short)(s1 + s2);
