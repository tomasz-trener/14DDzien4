using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieZawodnicy
{
    internal class ManagerZawodnikow
    {
        const string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
        private Zawodnik[] zawodnicy;

        public Zawodnik[] WczytajZawodnikow()
        {
            string[] wiersze = new WebClient().DownloadString(url).Split('\n');

            int liczbaWierszy = wiersze.Length - 1;
            Zawodnik[] zawodnicy = new Zawodnik[liczbaWierszy];

            for (int i = 1; i <= liczbaWierszy; i++)
            {
                string[] komorki = wiersze[i].Split(';');
                Zawodnik z = new Zawodnik(komorki);
                zawodnicy[i - 1] = z;
            }

            // zawodnicy z ciała klasy : this
            // domyślnie z metody 
            this.zawodnicy = zawodnicy;
            return zawodnicy;
        }

        public double PodajSredniWzrost()
        {
            double suma = 0;
            foreach (var z in zawodnicy)
                suma += z.Wzrost;
            
           // return Math.Round(suma / zawodnicy.Length,2);
            return suma / zawodnicy.Length;
        }
    }
}
