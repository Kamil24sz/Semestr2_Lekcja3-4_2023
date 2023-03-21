using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr2_Lekcja3_2023
{
    public class Pisak
    {
        //właściwości
        public string Kolor;
        public double Grubość;
        public decimal Cena;

        //konstruktor
        //zmniejszają objętość kodu
        //likwidują obiekty duchy
        //może być więcej niż 1 konstruktor
        public Pisak(string kolor, double grubość, decimal cena) {
            Kolor = kolor;
            Grubość = grubość;
            Cena = cena;
        }

        public Pisak(string kolor, double grubość)
        {
            Kolor = kolor;
            Grubość = grubość;
            Cena = 2m;
        }

        //metoda wypisująca informacje
        public void Info()
        {
            Console.WriteLine($"Pisak jest koloru {Kolor}");
            Console.WriteLine($"Pisak ma grubość {Grubość}");
            Console.WriteLine($"Pisak kosztuje {Cena}");
        }
    }
}
