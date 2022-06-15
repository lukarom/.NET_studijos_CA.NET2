namespace Paskaita_6_Termometras
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Hello, Termomemtras");

             Console.WriteLine("Iveskite temperatura pagal celsiju: ");
             var tempCels = int.Parse(Console.ReadLine());
             var tempFarenheit = tempCels * (double)9 / 5 + 32;
             var tempKelvin = tempCels + 273.15;
             Console.WriteLine($"Temperatura pagal Farenheita: {tempFarenheit}");
             Console.WriteLine($"Temperatura pagal Kelvina: {tempKelvin}");

             var tempCels1 = (tempFarenheit - 32) * (double)5 / 9;
             Console.WriteLine($"Celsijau temperatura perskaiciuota is Farenheitu: {tempCels1}");
             bool tempCelsCheck = tempCels1 == tempCels;
             Console.WriteLine($"Ar ivesta ir peskaiciuota is Farenheito temperaturos vienodos: {tempCelsCheck}");


             var tempCels2 = tempKelvin - 273.15;
             Console.WriteLine($"Celsijau temperatura perskaiciuota is Kelvinu: {tempCels2}");
             bool tempCelsCheck2 = tempCels2 == tempCels;
             Console.WriteLine($"Ar ivesta ir peskaiciuota is Farenheito temperaturos vienodos: {tempCelsCheck2}");

             var tempFarenKelv = (tempFarenheit - 32) * 5 / 9 + 273.15;
             Console.WriteLine($"Isverciame Farenheitus i Kelvinus: {tempFarenKelv} ");

            // Farenheit temperature based on Celsius entry
            var TempFarenheit8 = Convert.ToString((tempCels + 40) * (double)9 / 5 + 32);
            var TempFarenheit7 = Convert.ToString((tempCels + 35) * (double)9 / 5 + 32);
            var TempFarenheit6 = Convert.ToString((tempCels + 30) * (double)9 / 5 + 32);
            var TempFarenheit5 = Convert.ToString((tempCels + 25) * (double)9 / 5 + 32);
            var TempFarenheit4 = Convert.ToString((tempCels + 20) * (double)9 / 5 + 32);
            var TempFarenheit3 = Convert.ToString((tempCels + 15) * (double)9 / 5 + 32);
            var TempFarenheit2 = Convert.ToString((tempCels + 10) * (double)9 / 5 + 32);
            var TempFarenheit1 = Convert.ToString((tempCels + 5) * (double)9 / 5 + 32);
            var TempFarenheit0 = Convert.ToString((tempFarenheit));
            var TempFarenheit_1 = Convert.ToString((tempCels - 5 ) * (double)9 / 5 + 32);
            var TempFarenheit_2 = Convert.ToString((tempCels - 10) * (double)9 / 5 + 32);
            var TempFarenheit_3 = Convert.ToString((tempCels - 15) * (double)9 / 5 + 32);
            var TempFarenheit_4 = Convert.ToString((tempCels - 20) * (double)9 / 5 + 32);
            var TempFarenheit_5 = Convert.ToString((tempCels - 25) * (double)9 / 5 + 32);
            var TempFarenheit_6 = Convert.ToString((tempCels - 30) * (double)9 / 5 + 32);
            var TempFarenheit_7 = Convert.ToString((tempCels - 35) * (double)9 / 5 + 32);
            var TempFarenheit_8 = Convert.ToString((tempCels - 40) * (double)9 / 5 + 32);

            TempFarenheit8.Equals(TempFarenheit0);
            // Celsius temperature based on entry
            var TempCels8 = tempCels + 40;
            var TempCels7 = tempCels + 35;
            var TempCels6 = tempCels + 30;
            var TempCels5 = tempCels + 25;
            var TempCels4 = tempCels + 20;
            var TempCels3 = tempCels + 15;
            var TempCels2 = tempCels + 10;
            var TempCels1 = tempCels + 5;
            var TempCels0 = tempCels;
            var TempCels_1 = tempCels - 5;
            var TempCels_2 = tempCels - 10;
            var TempCels_3 = tempCels - 15;
            var TempCels_4 = tempCels - 20;
            var TempCels_5 = tempCels - 25;
            var TempCels_6 = tempCels - 30;
            var TempCels_7 = tempCels - 35;
            var TempCels_8 = tempCels - 40;


            var middleLine8 = " - | | - ";
            var middleLine7 = " - | | - ";
            var middleLine6 = " - | | - ";
            var middleLine5 = " - | | - ";
            var middleLine4 = " - | | - ";
            var middleLine3 = " - | | - ";
            var middleLine2 = " - | | - ";
            var middleLine1 = " - | | - ";
            var middleLine0 = " - | | - ";
            var middleLine_1 = " - | | - ";
            var middleLine_2 = " - | | - ";
            var middleLine_3 = " - | | - ";
            var middleLine_4 = " - | | - ";
            var middleLine_5 = " - | | - ";
            var middleLine_6 = " - | | - ";
            var middleLine_7 = " - | | - ";
            var middleLine_8 = " - | | - ";
            var middleLineSpecial = " - |#| - ";


            //drawing the thermometer
            var firstLineTerm = "|---------------------|";
            var secondLineTerm = "|    ^F    _    ^C    |";
            var thermLine8 = $"| {TempFarenheit8,4} {middleLine8} {TempCels8,4} | ";
            var thermLine7 = $"| {TempFarenheit7,4} {middleLine7} {TempCels7,4} | ";
            var thermLine6 = $"| {TempFarenheit6,4} {middleLine6} {TempCels6,4} | ";
            var thermLine5 = $"| {TempFarenheit5,4} {middleLine5} {TempCels5,4} | ";
            var thermLine4 = $"| {TempFarenheit4,4} {middleLine4} {TempCels4,4} | ";
            var thermLine3 = $"| {TempFarenheit3,4} {middleLine3} {TempCels3,4} | ";
            var thermLine2 = $"| {TempFarenheit2,4} {middleLine2} {TempCels2,4} | ";
            var thermLine1 = $"| {TempFarenheit1,4} {middleLine1} {TempCels1,4} | ";
            var thermLine0 = $"| {TempFarenheit0,4} {middleLine0} {TempCels0,4} | ";
            var thermLine_1 = $"| {TempFarenheit_1,4} {middleLine_1} {TempCels_1,4} | ";
            var thermLine_2 = $"| {TempFarenheit_2,4} {middleLine_2} {TempCels_2,4} | ";
            var thermLine_3 = $"| {TempFarenheit_3,4} {middleLine_3} {TempCels_3,4} | ";
            var thermLine_4 = $"| {TempFarenheit_4,4} {middleLine_4} {TempCels_4,4} | ";
            var thermLine_5 = $"| {TempFarenheit_5,4} {middleLine_5} {TempCels_5,4} | ";
            var thermLine_6 = $"| {TempFarenheit_6,4} {middleLine_6} {TempCels_6,4} | ";
            var thermLine_7 = $"| {TempFarenheit_7,4} {middleLine_7} {TempCels_7,4} | ";
            var thermLine_8 = $"| {TempFarenheit_8,4} {middleLine_8} {TempCels_8,4} | ";
            var bottLine1 = $"|        '***'        | ";
            var bottLine2 = $"|       (*****)       | ";
            var bottLine3 = $"|        '___'        | ";
            var bottLine4 = $"|_____________________| ";



           thermLine0 = thermLine0.Replace(middleLine0, middleLineSpecial);
           thermLine_1= thermLine_1.Replace(middleLine_1, middleLineSpecial);
           thermLine_2=thermLine_2.Replace(middleLine_2, middleLineSpecial);
           thermLine_3=thermLine_3.Replace(middleLine_3, middleLineSpecial);
           thermLine_4=thermLine_4.Replace(middleLine_4, middleLineSpecial);
           thermLine_5=thermLine_5.Replace(middleLine_5, middleLineSpecial);
           thermLine_6=thermLine_6.Replace(middleLine_6, middleLineSpecial);
           thermLine_7=thermLine_7.Replace(middleLine_7, middleLineSpecial);
           thermLine_8=thermLine_8.Replace(middleLine_8, middleLineSpecial);


            Console.WriteLine(
                  $"{firstLineTerm}" +
                  $"\n{secondLineTerm}" +
                $"\n{thermLine8}" +
                $"\n{thermLine7}" +
                $"\n{thermLine6}" +
                $"\n{thermLine5}" +
                $"\n{thermLine4}" +
                $"\n{thermLine3}" +
                $"\n{thermLine2}" +
                $"\n{thermLine1}" +
                $"\n{thermLine0}" +
                $"\n{thermLine_1}" +
                $"\n{thermLine_2}" +
                $"\n{thermLine_3}" +
                $"\n{thermLine_4}" +
                $"\n{thermLine_5}" +
                $"\n{thermLine_6}" +
                $"\n{thermLine_7}" +
                $"\n{bottLine1}" +
                $"\n{bottLine2}" +
                $"\n{bottLine3}" +
                $"\n{bottLine4}");

            var newTempCels = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Iveskite temperatura: {Console.ReadLine}");

            








        }
    }
}