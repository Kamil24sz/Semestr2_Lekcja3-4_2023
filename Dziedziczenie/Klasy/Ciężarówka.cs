using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Klasy
{
    public class Ciężarówka : Pojazd
    {
        //właściwości
        public int ŁadownośćPrzyczepy;

        //Konstruktor
        public Ciężarówka(int moc, string kolor, string marka, int ładownośćPrzyczepy) : base (moc, kolor, marka)
        {
            ŁadownośćPrzyczepy = ładownośćPrzyczepy;
        }

        //nadpisywanie metod
        public override void UruchomSilnik()
        {
            Console.WriteLine("Silnik 1 włączony");
            Console.WriteLine("Silnik 2 włączony");

            CzySilnikWłączony = true;
        }

    }
}
