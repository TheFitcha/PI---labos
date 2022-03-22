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
    public partial class Form1 : Form
    {
        private AutobusniKolodvor ak = new AutobusniKolodvor();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ak.DohvatiLinije().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ak.DohvatiLinije(odredisteBox.Text);
        }

        private void kupiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Linija odabranaLinija = new Linija();
                DataGridViewRow odabraniRed = dataGridView1.SelectedRows[0];
                odabranaLinija.Polaziste = odabraniRed.Cells["Polaziste"].Value.ToString();
                odabranaLinija.Odrediste = odabraniRed.Cells["Odrediste"].Value.ToString();
                odabranaLinija.Udaljenost = int.Parse(odabraniRed.Cells["Udaljenost"].Value.ToString());
                odabranaLinija.Id = int.Parse(odabraniRed.Cells["Id"].Value.ToString());
                odabranaLinija.Autoprijevoznik = odabraniRed.Cells["Autoprijevoznik"].Value.ToString();
                KupiKartu kk = new KupiKartu(odabranaLinija);
                kk.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Odaberite red!");
            }
        }
 
    }
}
