using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prijevodi
{
    public partial class Form1 : Form
    {
        private BazaJezika bazaJezika;
        private Rjecnik rjecnik;
        public Form1()
        {
            InitializeComponent();
            bazaJezika = new BazaJezika();
            rjecnik = new Rjecnik();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ishodisniJezici.DataSource = bazaJezika.DohvatiSveJezike();
            odredisniJezici.DataSource = bazaJezika.DohvatiSveJezike();
        }

        private void prevediBtn_Click(object sender, EventArgs e)
        {
            try
            {
                prijevodTextBox.Text = rjecnik.Prevedi(recenicaZaPrijevodText.Text);

            }
            catch
            {
                MessageBox.Show("Pogreska prilikom prevodenja!");
            }
        }

        private void popisRijecBtn_Click(object sender, EventArgs e)
        {
            PopisRijeci formPopisRijeci = new PopisRijeci(rjecnik);
            formPopisRijeci.ShowDialog();
        }

        private void dodajRijecBtn_Click(object sender, EventArgs e)
        {
            rjecnik.DodajNovuRijec(new Rijec(novaRijecText.Text, prijevodNoveRijeciText.Text));
            novaRijecText.Clear();
            prijevodNoveRijeciText.Clear();
        }
    }
}
