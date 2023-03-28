using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Klasy
{
    public class Pojazd
    {
        //Właściwości
        public int Moc;
        public string Kolor;
        public string Marka;
        public bool CzySilnikWłączony;

        public Pojazd(int moc, string kolor, string marka)
        {
            Moc = moc;
            Kolor = kolor;
            Marka = marka;
            CzySilnikWłączony = false;
        }

        //Metody
        public override string ToString()
        {
            return $"Pojazd marki {Marka} w kolorze {Kolor} o mocy {Moc}KM";
        }
        public virtual void UruchomSilnik()
        {
            Console.WriteLine("Silnik pojazdu uruchomiony");
            CzySilnikWłączony = true;
        }

    }
}
