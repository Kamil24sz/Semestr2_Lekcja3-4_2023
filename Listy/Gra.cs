using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listy
{
    public class Gra
    {
        public string Nazwa;
        public decimal Cena;

        public Gra(string nazwa, decimal cena)
        {
            Nazwa = nazwa;
            Cena = cena;
        }

        public override string ToString()
        {
            return $"Gra {Nazwa} kosztuje {Cena}";
        }
    }
}
