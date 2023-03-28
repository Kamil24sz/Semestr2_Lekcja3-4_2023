using Dziedziczenie.Klasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SamochódOsobowy s1 = new SamochódOsobowy(100, "niebieski", "Opel");
            SamochódOsobowy s2 = new SamochódOsobowy(100, "niebieski", "Opel");
            Autobus a1 = new Autobus(300, "niebiesko-białe", "mercedes", 60);
            Ciężarówka c1 = new Ciężarówka(500, "szary", "Man", 2000);

            Console.WriteLine(s1.ToString());
            Console.WriteLine(a1.ToString());
            Console.WriteLine(c1.ToString());

            s1.UruchomSilnik();
            a1.UruchomSilnik();
            c1.UruchomSilnik();

            //Wszystkie klasy dziedziczą z bardzo ogólnej klasy Object i dzięki temu
            //każdy obiekt dziedziczy pewne metody

            //reprezentacja tekstowa obiektu
            Console.WriteLine(s1.ToString());

            //zwraca unikalny numer dla obiektu
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());

            //reprezentacja tekstowa obiektu
            Console.WriteLine(s1.GetType());

            //Statyczny element nie należy do żadnego konkretnego obiektu - należy on ogólnie do klasy
            Console.WriteLine(SamochódOsobowy.LicznikSamochodów);

            //Właściwość zwykła - wywołujemy z poziomu obiektu
            Console.WriteLine(s2.SN);

            //Właściwiść statyczna - wywołujemy z poziomu klasy
            Console.WriteLine(SamochódOsobowy.serial);
           

            Console.ReadLine();
        }
    }
}
