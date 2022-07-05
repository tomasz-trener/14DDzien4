using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02ZadanieKalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJeden_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "1"; 
        }

        private void btnDwa_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "2";
        }

        private void btnPrzyciskKalkulatora_Click(object sender, EventArgs e)
        {
            // Button tenWcisnietyPrzycisk= (Button)sender;
            // Button b = sender as Button;
            //  string s = b.Text;

            // txtWyswietlacz.Text += s;
            txtWyswietlacz.Text+= ((Button)sender).Text;
        }

        private void btnRownaSie_Click(object sender, EventArgs e)
        {
            OperacjeNaLiczbach onl = new OperacjeNaLiczbach();

            try
            {
                double d = onl.PodajWynik(txtWyswietlacz.Text); // to instrukcja niebezpieczna 
                txtWyswietlacz.Text = Convert.ToString(d);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntCzysc_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text = "";
        }
    }
}
