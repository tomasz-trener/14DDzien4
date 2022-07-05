using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01AplikacjaOkienkowaWstep
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Form1 f = new Form1(); // delkeracja zmiennej o nazwie f i od razu przypisanie do tej zmiennej nowej instacji klasy Form1 

            //Form1 f; // Deklaracja zmienej o nazwie f i nic. To znaczy, że ta zmienna wksazuje na nic 
            //f = new Form1();

            //Application.Run(f);

            //new Form1(); // stwozrenie nowego obiektu typu Form1 , on sobie lata w pamieci ale nie mam do niego uchwytu w postaci zmiennj 
            // nie moge pozniej sie do niego dowlac (nie moge z niego skorzystac) 

            Application.Run(new Form1()); // dla wygody, zeby nie trzeba bylo tworzyc zminnej bo i tak z niej nie korzystamy 
        }
    }
}
