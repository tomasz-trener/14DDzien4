using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadaniePogoda
{

    enum Jednostka
    {
        Celcjusz,
        Farenheit,
        Kelvin
    }

    internal class ManagerPogody
    {
        const string adresUrl = "https://www.google.com/search?q=pogoda+";
        const char znak = '°';
        const char znakKoncowy = '>';
        public double PodajTemperature(string miasto, Jednostka jd)
        {
            WebClient wc = new WebClient();
           
            string s= wc.DownloadString(adresUrl+miasto);
            //File.WriteAllText("c:\\dane\\pogoda.txt", s);

            int indx = s.IndexOf(znak);
            int akutalnaPozycja = indx - 1;

            while (s[akutalnaPozycja] != znakKoncowy)
                akutalnaPozycja--;

            string wynik = s.Substring(akutalnaPozycja + 1, indx - akutalnaPozycja + 1);

            //throw new NotImplementedException();
            // przerwa do godz 13 

            // usuniecie 2 ostatnich znaków 
            int wynikInt = Convert.ToInt32(wynik.Substring(0, wynik.Length - 2));

            return ZamienTemperature(wynikInt,jd);
        }

        private double ZamienTemperature(double n, Jednostka jd)
        {
            if (jd == Jednostka.Celcjusz)
                return n;

            if (jd == Jednostka.Kelvin)
                return n + 273.15;

            if (jd == Jednostka.Farenheit)
                return n*1.8 + 32;

            throw new NotImplementedException("Nieznana jednostka");



        }
    }
}
