using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieKalkulator
{
    internal class OperacjeNaLiczbach
    {
        public double PodajWynik(string rownanie)
        {
            string[] tab1 = rownanie.Split('+');
            string[] tab2 = rownanie.Split('-');
            string[] tab3 = rownanie.Split('*');
            string[] tab4 = rownanie.Split('/');

            if(tab1.Length == 2)
                return Convert.ToInt32(tab1[0]) + Convert.ToInt32(tab1[1]);
            else if (tab2.Length == 2)
                return Convert.ToInt32(tab2[0]) - Convert.ToInt32(tab2[1]);
            else if (tab3.Length == 2)
                return Convert.ToInt32(tab3[0]) * Convert.ToInt32(tab3[1]);
            else if(tab4.Length == 2)
                return Convert.ToDouble(tab4[0]) / Convert.ToDouble(tab4[1]);

            //return 0;
            throw new Exception("Niepoprawne dzialanie");
        }


    }
}
