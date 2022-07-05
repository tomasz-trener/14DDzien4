using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieZawodnicy
{
    internal class Zawodnik
    {

        public int Id_zawodnika;
        public int Id_trenera;
        public string Imie;
        public string Nazwisko { get; set; }
        public string Kraj;
        public DateTime DataUrodzenia;
        public int Wzrost;
        public int Waga;

        public string Test { get { return "aa"; } }
        public string ImieNazwiskoKraj 
        { 
            get 
            { 
                return 
                    Imie + " " + 
                    Nazwisko + " " + 
                    Kraj; 
            } 
        }

        public string DaneZeWzrostem
        {
            get { return ImieNazwiskoKraj + " " + Wzrost; }
        }

        public Zawodnik(string[] komorki)
        {
            Id_zawodnika = Convert.ToInt32(komorki[0]);

            //if (komorki[1] != "")
            if (!string.IsNullOrWhiteSpace(komorki[1]))
                Id_trenera = Convert.ToInt32(komorki[1]);

            Imie = komorki[2];
            Nazwisko = komorki[3];
            Kraj = komorki[4];
            DataUrodzenia = Convert.ToDateTime(komorki[5]);
            Wzrost = Convert.ToInt32(komorki[6]);
            Waga = Convert.ToInt32(komorki[7]);
        }
    }
}
