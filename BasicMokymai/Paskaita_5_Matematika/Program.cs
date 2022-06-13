
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