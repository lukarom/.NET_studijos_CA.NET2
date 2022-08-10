using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_31_OOP_konstruktoriai
{
    internal class Customer
    {
        //Tuscio konstruktoriaus deklaravimas  
        public Customer()
        {
            Vardas = "Stiurtas";
        }

        public Customer(string vardas)
        {
            Vardas = vardas;

        }

        public string Vardas { get; set; }
    }
}
