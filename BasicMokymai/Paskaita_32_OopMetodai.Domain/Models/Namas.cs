using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_32_OopMetodai.Domain.Models
{
    public class Namas
    {
        public Namas()
        {
            ZmoniuVardai = new List<string>();
            Zmones = new List<Zmogus>()
            {
                new Zmogus (){ Vardas = "Petras"},
                new Zmogus (){ Vardas = "Ieva"},
                new Zmogus (){ Vardas = "Jonas"}
            };

            foreach(var zmogus in Zmones)
            {
                ZmoniuVardai.Add(zmogus.Vardas);
            }
        }

        private Namas(string adresas) :this()
        {
            Adresas = adresas;
        }
        public Namas(int kambariuSkaicius, string adresas) : this(adresas)
        {
            KambariuSkaicius = kambariuSkaicius;
            
        }
        private List<Zmogus> Zmones { get; set; }
        private List<string> zmoniuVardai;

        public List<string> ZmoniuVardai
        {
            get { return zmoniuVardai; }
            set {zmoniuVardai = value; }
        }

        public int KambariuSkaicius { get; private set; }

        public string Adresas { get; set; }

    }
}
