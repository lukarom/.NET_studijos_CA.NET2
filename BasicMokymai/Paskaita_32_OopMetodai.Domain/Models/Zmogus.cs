using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_32_OopMetodai.Domain.Models
{
    /*
     * Access Modifiers (Prieinamumo modifikuotojai)
     * internal: Tipa ar nari galima pasiekti naudojant bet kur koda tame paciame assembly(Projekto) kode, bet ne is kito assembly kodo
     * protected: (Eisime kada prieisime paveldimumo/inheritence tema)
     */
    internal class Zmogus
    {
        public Zmogus 
        public string Vardas { get; set; }

        public Namas Namas { get; set; }
    }
}
