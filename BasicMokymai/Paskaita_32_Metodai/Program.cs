using Paskaita_32_OopMetodai.Domain.Models;

namespace Paskaita_32_Metodai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello OOP Metodai!");
            var namas1 = new Namas(5);
            foreach (var namoGyventojuVardai in namas1.ZmoniuVardai) 
            {
                Console.WriteLine($"Namo gyventoju vardai: {namoGyventojuVardai}");
            };
        }
    }
}