using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib2;

namespace AutobusniKolodvor2
{
    public partial class KupiKartu : Form
    {
        private Linija odabranaLinija;
        private AutobusniKolodvor ak = new AutobusniKolodvor();
        public KupiKartu(Linija linija)
        {
            InitializeComponent();
            odabranaLinija = linija;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VrstaKarte vk;
            if(vrstaKarteCombo.GetItemText(vrstaKarteCombo.SelectedItem) == "Regularna")
            {
                vk = VrstaKarte.Regularna;
            }
            else
            {
                vk = VrstaKarte.Studentska;
            }
            Karta kupljenaKarta = ak.KupiKartu(odabranaLinija, vk, povratnaCheck.Checked, prtljagaCheck.Checked);
            string povratna = kupljenaKarta.Povratna ? "Da" : "Ne";
            string prtljaga = kupljenaKarta.Prtljaga ? "Da" : "Ne";
            ispisBox.AppendText($"Broj karte: {kupljenaKarta.BrojKarte}" + Environment.NewLine +
                $"Relacija: {kupljenaKarta.Linija.Polaziste} - {kupljenaKarta.Linija.Odrediste}" + Environment.NewLine +
                $"Udaljenost: {kupljenaKarta.Linija.Udaljenost}" + Environment.NewLine +
                $"Autoprijevoznik: {kupljenaKarta.Linija.Autoprijevoznik}" + Environment.NewLine +
                $"Vrsta karte: {kupljenaKarta.Vrsta}" + Environment.NewLine +
                $"Povratna karta: {povratna}" + Environment.NewLine +
                $"Naplati prtljagu: {prtljaga}" + Environment.NewLine +
                $"--------------------------------------------" + Environment.NewLine +
                $"Cijena karte: {kupljenaKarta.Cijena}");
        }

        private void KupiKartu_Load(object sender, EventArgs e)
        {
            vrstaKarteCombo.Items.Add("Regularna");
            vrstaKarteCombo.Items.Add("Studentska");
        }
    }
}
