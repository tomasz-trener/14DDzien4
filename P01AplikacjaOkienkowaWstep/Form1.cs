using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01AplikacjaOkienkowaWstep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPowitanieDwa_Click(object sender, EventArgs e)
        {

            string s = "ala ma kota";
            s = s.ToUpper();

            MessageBox.Show(s);


        }

        private void btnWyswietlTekst_Click(object sender, EventArgs e)
        {
            string s = txtPoleTekstowe.Text;
            MessageBox.Show(s);
        }
    }
}
