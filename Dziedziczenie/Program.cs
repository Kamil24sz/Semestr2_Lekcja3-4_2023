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
            Autobus a1 = new Autobus(300, "niebiesko-białe", "mercedes", 60);
            Ciężarówka c1 = new Ciężarówka(500, "szary", "Man", 2000);

            s1.Info();
            a1.Info();
            c1.Info();

            Console.ReadLine();
        }
    }
}
