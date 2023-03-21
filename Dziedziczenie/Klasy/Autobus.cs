using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Klasy
{
    public class Autobus : Pojazd
    {
        //właściwości
        public int IlośćMiejsc;
        
        //konstruktor
        public Autobus(int moc, string kolor, string marka, int ilośćMiejsc) : base (moc, kolor, marka)
        {
            IlośćMiejsc = ilośćMiejsc;
        }

    }
}
