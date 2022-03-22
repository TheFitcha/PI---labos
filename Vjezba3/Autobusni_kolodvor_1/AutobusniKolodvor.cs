using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib;

namespace Autobusni_kolodvor_1
{
    public partial class AutobusniKolodvor : Form
    {
        public static DataGridViewRow odabranaLinija;
        public AutobusniKolodvor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Linija linija = new Linija();
            linija.Id = int.Parse(odabranaLinija.Cells["Id"].Value.ToString());
            linija.Polaziste = polazisteBox.Text;
            linija.Odrediste = odredisteBox.Text;
            linija.Udaljenost = int.Parse(udaljenostBox.Text);
            linija.Autoprijevoznik = autoprijevoznikBox.Text;
            VrstaKarte vrstaKarte;
            if (regularnaRadio.Checked)
            {
                vrstaKarte = VrstaKarte.Regularna;
            }
            else
            {
                vrstaKarte = VrstaKarte.Studentska;
            }
            Karta novaKarta = AutobusniKolodvorLib.AutobusniKolodvor.KreirajKartu(linija, vrstaKarte, povratnaCheck.Checked, prtljagaCheck.Checked);

            brKarteBox.Text = novaKarta.BrojKarte.ToString();
            cijenaKarteBox.Text = novaKarta.Cijena.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopisLinija pl = new PopisLinija();
            pl.FormClosing += pl_FormClosing;
            pl.ShowDialog();
        }
        private void pl_FormClosing(object sender, FormClosingEventArgs e)
        {
            polazisteBox.Text = odabranaLinija.Cells["Polaziste"].Value.ToString();
            odredisteBox.Text = odabranaLinija.Cells["Odrediste"].Value.ToString();
            udaljenostBox.Text = odabranaLinija.Cells["Udaljenost"].Value.ToString();
            autoprijevoznikBox.Text = odabranaLinija.Cells["Autoprijevoznik"].Value.ToString();
        }
    }
}
