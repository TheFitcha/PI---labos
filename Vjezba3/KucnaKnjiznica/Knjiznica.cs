using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KucnaKnjiznicaLib;

namespace KucnaKnjiznica
{
    public partial class Knjige : Form
    {
        private Knjiznica knjiznica = new Knjiznica();
        public Knjige()
        {
            InitializeComponent();
        }

        private void Knjige_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
        public void Osvjezi()
        {
            dostupnoDataGrid.DataSource = knjiznica.DohvatiDostupneKnjige().ToList();
            posudenoDataGrid.DataSource = knjiznica.DohvatiKnjigeNaPosudbi().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Knjiga odabranaKnjiga = knjiznica.DohvatiDostupneKnjige().Find(x => x.ISBN == dostupnoDataGrid.SelectedRows[0].Cells["ISBN"].Value.ToString());
                NovaPosudba np = new NovaPosudba(odabranaKnjiga, knjiznica);
                np.FormClosing += np_FormClosing;
                np.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Odaberite knjigu!");
            }
        }

        private void np_FormClosing(object sender, FormClosingEventArgs e)
        {
            Osvjezi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                knjiznica.VratiKnjigu(knjiznica.DohvatiKnjigeNaPosudbi().Find(x => x.ISBN == posudenoDataGrid.SelectedRows[0].Cells["ISBN"].Value.ToString()));
                Osvjezi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Odaberite knjigu!");
            }
        }
    }
}
