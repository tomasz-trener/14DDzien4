using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03ZadaniePogoda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           cbMiasto.DataSource= File.ReadAllLines("miasta.txt");
        }

        private void btnPodajTemperature_Click(object sender, EventArgs e)
        {
            bool cel = rbCelcjusz.Checked;
            bool far = rbFahrenheit.Checked;
            bool kel = rbKelvin.Checked;

            string jd2;
            Jednostka jd;
            if (cel)
                //jd2 = "cell"; 
                jd = Jednostka.Celcjusz;
            else if (far)
                jd = Jednostka.Farenheit;
            else if (kel)
                jd = Jednostka.Kelvin;
            else
                throw new NotImplementedException("Nieznana jednostka");

            ManagerPogody mp = new ManagerPogody();
            double wynik = mp.PodajTemperature(cbMiasto.Text, jd);

           // lblTemperatura.Text = Convert.ToString(wynik);
           // lblTemperatura.Text = wynik.ToString();
            //lblTemperatura.Text = $"{wynik}"; // niezalecany sposób konwersji
            lblTemperatura.Text = $"Temperatura to {wynik} w mieście {cbMiasto.Text}";
            lblTemperatura.Text = String.Format("Temperatura to {0} w miescie {1}",
               Convert.ToString(wynik), cbMiasto.Text);

            // dlaczego to $"{wynik}" jest niebezpieczne
             



        }

        private void btnWczytajMiasta_Click(object sender, EventArgs e)
        {  
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "pliki tekstowe (*.txt)|*.txt|wszystkie pliki (*.*)|*.*";
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                cbMiasto.DataSource = File.ReadAllLines(ofd.FileName);
            }
        }
    }
}
