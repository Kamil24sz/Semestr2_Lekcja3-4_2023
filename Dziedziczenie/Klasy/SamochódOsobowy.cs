using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Klasy
{
    public class SamochódOsobowy : Pojazd
    {
        //właściwość - statatyczna
        public static int LicznikSamochodów = 0;
        public static string serial = "OPELAA2023C";

        //zwykła właściwość
        public string SN;

        //Konstruktor
        public SamochódOsobowy(int moc, string kolor, string marka) : base(moc, kolor, marka)
        {
            LicznikSamochodów++;
            SN = serial + LicznikSamochodów.ToString();
        }

    }
}
