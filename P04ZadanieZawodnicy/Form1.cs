using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04ZadanieZawodnicy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            ManagerZawodnikow mz = new ManagerZawodnikow();
            lbDane.DataSource = (Zawodnik[])mz.WczytajZawodnikow();
            lbDane.DisplayMember = "DaneZeWzrostem";

            //for (int i = 0; i < zawodnicy.Length; i++)
            //    lbDane.Items.Add(zawodnicy[i].Nazwisko);

            //txtSredniWzrost.Text =
            //    Convert.ToString(mz.PodajSredniWzrost());
            txtSredniWzrost.Text =
                String.Format("{0:000.00}",mz.PodajSredniWzrost());

        }
    }
}
