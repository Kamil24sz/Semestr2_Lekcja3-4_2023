using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gra fortnite = new Gra("Fortnite", 0);
            Gra fifa = new Gra("Fifa 2022", 250);
            Gra cyberPunk = new Gra("Cyber Punk", 300);

            //tablica
            Gra[] gry = new Gra[] {fortnite, fifa, cyberPunk};

            for(int i = 0; i < gry.Length; i++)
            {
                Console.WriteLine(gry[i]);
            }

            //lista - nie trzeba podawać rozmiaru listy, lista jest rozciągliwa
            List<Gra> gry2 = new List<Gra>();
            gry2.Add(fortnite);
            gry2.Add(fifa);
            gry2.Add(cyberPunk);

            foreach(Gra g in gry2)
            {
                Console.WriteLine(g.ToString());
            }

            Console.ReadLine();
        }
    }
}
