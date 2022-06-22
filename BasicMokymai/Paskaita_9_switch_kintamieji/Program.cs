namespace Paskaita_9_switch_kintamieji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Iveskite puodeliu kieki:");

            //int puodeliuKiekis = Convert.ToInt32(Console.ReadLine());
            //int nemokamiPuodeliai = puodeliuKiekis / 3;
            //if (puodeliuKiekis <= 2 && puodeliuKiekis >= 0)
            //{
            //    Console.WriteLine("Nepriklauso nemokama kava");
            //}
            //else if (puodeliuKiekis > 3)
            //{
            //    Console.WriteLine($"Priklauso {nemokamiPuodeliai} nemokami puodeliai");
            //}

            //Uzduotis 2

            //Console.WriteLine("Iveskite pirmaji sveika skaiciu");
            //int pirmasSkaicius = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Iveskite antraji sveika skaiciu");
            //int antrasSkaicius = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Iveskite treciaji sveika skaiciu");
            //int treciasSkaicius = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Iveskite ketvirtaji sveika skaiciu");
            //int ketvirtasSkaicius = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine(pirmasSkaicius == 0 ? "N/A" : pirmasSkaicius < 0 ? pirmasSkaicius : -pirmasSkaicius);
            //Console.WriteLine(antrasSkaicius == 0 ? "N/A" : antrasSkaicius < 0 ? antrasSkaicius : -antrasSkaicius);
            //Console.WriteLine(treciasSkaicius == 0 ? "N/A" : treciasSkaicius < 0 ? treciasSkaicius : -treciasSkaicius);
            //Console.WriteLine(ketvirtasSkaicius == 0 ? "N/A" : ketvirtasSkaicius < 0 ? ketvirtasSkaicius : -ketvirtasSkaicius);

            //int hardSkaicius = 12;

            //Console.WriteLine("Iveskite skaiciu nuo 1 iki 20");




            //int sk1 = Convert.ToInt32(Console.ReadLine());
            //if (sk1 != hardSkaicius)
            //{
            //    int sk2 = Convert.ToInt32(Console.ReadLine());
            //    if (sk2 != hardSkaicius)
            //    {
            //        int sk3 = Convert.ToInt32(Console.ReadLine());
            //        if (sk3 != hardSkaicius)
            //        {
            //            int sk4 = Convert.ToInt32(Console.ReadLine());
            //            if (sk4 != hardSkaicius)
            //            {
            //                int sk5 = Convert.ToInt32(Console.ReadLine());
            //                if (sk5 != hardSkaicius)
            //                {
            //                    int sk6 = Convert.ToInt32(Console.ReadLine());
            //                    if (sk6 != hardSkaicius)
            //                    {
            //                        Console.ReadLine();
            //                    }
            //                    if (sk6 < hardSkaicius)
            //                    {
            //                        Console.WriteLine("Skaicius ir per mazas");
            //                    }
            //                    if (sk6 > hardSkaicius)
            //                    {
            //                        Console.WriteLine("Skaicius ir per didelis");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Teisingai");
            //                    }
            //                }
            //                if (sk5 < hardSkaicius)
            //                {
            //                    Console.WriteLine("Skaicius ir per mazas");
            //                }
            //                if (sk5 > hardSkaicius)
            //                {
            //                    Console.WriteLine("Skaicius ir per didelis");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Teisingai");
            //                }
            //            }
            //            if (sk4 < hardSkaicius)
            //            {
            //                Console.WriteLine("Skaicius ir per mazas");
            //            }
            //            if (sk4 > hardSkaicius)
            //            {
            //                Console.WriteLine("Skaicius ir per didelis");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Teisingai");
            //            }
            //        }
            //        if (sk3 < hardSkaicius)
            //        {
            //            Console.WriteLine("Skaicius ir per mazas");
            //        }
            //        if (sk3 > hardSkaicius)
            //        {
            //            Console.WriteLine("Skaicius ir per didelis");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Teisingai");
            //        }
            //    }
            //    if (sk2 < hardSkaicius)
            //    {
            //        Console.WriteLine("Skaicius ir per mazas");
            //    }
            //    if (sk2 > hardSkaicius)
            //    {
            //        Console.WriteLine("Skaicius ir per didelis");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Teisingai");
            //    }
            //}
            //if (sk1 < hardSkaicius)
            //{
            //    Console.WriteLine("Skaicius ir per mazas");
            //}
            //if (sk1 > hardSkaicius)
            //{
            //    Console.WriteLine("Skaicius ir per didelis");
            //}
            //else
            //{
            //    Console.WriteLine("Teisingai");
            //}


            //Console.WriteLine();

            //Console.WriteLine("Iveskite du skaicius ir matematine operacija:");

            //int pirmasSk = Convert.ToInt32(Console.ReadLine());
            //int antrasSk = Convert.ToInt32(Console.ReadLine());
            //var matOper = Console.ReadLine();

            //if (matOper == "+")
            //{
            //    Console.WriteLine(pirmasSk + antrasSk);
            //}
            //else if (matOper == "-")
            //{
            //    Console.WriteLine(pirmasSk - antrasSk);
            //}
            //else if (matOper == "/")
            //{
            //    Console.WriteLine((double)pirmasSk / antrasSk);
            //}
            //else if (matOper == "*")
            //{
            //    Console.WriteLine(pirmasSk * antrasSk);
            //}
            //else
            //{
            //    Console.WriteLine("netinkamas ivedimas");
            //}

            //switch(matOper)
            //{
            //    case "+": 
            //        Console.WriteLine(pirmasSk + antrasSk);
            //        break;
            //    case "-":
            //        Console.WriteLine(pirmasSk - antrasSk);
            //        break;
            //    case "/":
            //        Console.WriteLine((double)pirmasSk / antrasSk);
            //        break;
            //    case "*":
            //        Console.WriteLine((double)pirmasSk * antrasSk);
            //        break;
            //}

            Console.WriteLine("Iveskite pirmo draugo varda:");
            var var1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Iveskite antro draugo varda:");
            var var2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Iveskite trecio draugo varda:");
            var var3 = Convert.ToString(Console.ReadLine()); 
            Console.WriteLine("Iveskite pirmo draugo amziu:");
            int amz1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antro draugo amziu:");
            int amz2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecio draugo amziu:");
            int amz3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"   Pirmojo draugo vardas: {var1} ir amzius {amz1}" +
                $"\n   Antrojo draugo vardas: {var2} ir amzius {amz2}" +
                $"\n   Treciojo draugo vardas: {var3} ir amzius {amz3}");

            Console.WriteLine($" Draugu amziaus vidurkis: {(double)(amz1 + amz2 + amz3) / 3}");

            if (amz1 >= amz2 && amz1 >= amz3)
            {
                if (amz1 != amz2 && amz1 != amz3)
                {
                    Console.WriteLine($"{var1} yra vyriausias");
                }
                else if (amz1 == amz2 && amz1 == amz3)
                {
                    Console.WriteLine($"visi broliai yra vienodo amziaus");
                }
                else if (amz1 == amz2)
                {
                    Console.WriteLine($"{var1} ir {var2} yra vienodo amziaus");
                }
                else if (amz1 == amz3)
                {
                    Console.WriteLine($"{var1} ir {var3} yra vienodo amziaus");
                }
                else if (amz2 == amz3)
                {
                    Console.WriteLine($"{var2} ir {var3} yra vienodo amziaus");
                }
                
                
            }
            else if (amz2 >= amz1 && amz2 >=amz3) {

                if (amz2 != amz1 && amz2 != amz3)
                {
                    Console.WriteLine($"{var2} yra vyriausias");
                }
                else if (amz1 == amz2 && amz1 == amz3)
                {
                    Console.WriteLine($"visi broliai yra vienodo amziaus");
                }
                else if (amz1 == amz2)
                {
                    Console.WriteLine($"{var1} ir {var2} yra vienodo amziaus");
                }
                else if (amz1 == amz3)
                {
                    Console.WriteLine($"{var1} ir {var3} yra vienodo amziaus");
                }
                else if (amz2 == amz3)
                {
                    Console.WriteLine($"{var2} ir {var3} yra vienodo amziaus");
                }
                
                
            }
            else if (amz3 >= amz1 && amz3 >= amz2)
            {
                if (amz3 != amz1 && amz3 != amz2)
                {
                    Console.WriteLine($"{var3} yra vyriausias");
                }
                else if (amz1 == amz2 && amz1 == amz3)
                {
                    Console.WriteLine($"visi broliai yra vienodo amziaus");
                }
                else if (amz1 == amz2)
                {
                    Console.WriteLine($"{var1} ir {var2} yra vienodo amziaus");
                }
                else if (amz1 == amz3)
                {
                    Console.WriteLine($"{var1} ir {var3} yra vienodo amziaus");
                }
                else if (amz2 == amz3)
                {
                    Console.WriteLine($"{var2} ir {var3} yra vienodo amziaus");
                }
                
                

            }
            
        }
    }
}