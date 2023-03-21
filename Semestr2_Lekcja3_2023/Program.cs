using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr2_Lekcja3_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tworzymy 3 pisaki

            //pisak 1
            Pisak czarnyPisak = new Pisak("czarny", 0.5, 3m);

            //pisak 2
            Pisak niebieskiPisak = new Pisak("niebieski", 1.5);

            //pisak 3
            Pisak czerwonyPisak = new Pisak("czerwony", 0.25, 2m);

            //tablica przechowująca pisaki
            Pisak[] pisaki = new Pisak[] { czarnyPisak, niebieskiPisak, czerwonyPisak };

            //pętla wywołująca metodę na każdym z elementów tablicy pisaki
            foreach(Pisak p in pisaki)
                p.Info();


            Console.ReadLine();

        }
    }
}
