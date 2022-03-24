using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankaLib;

namespace Filtriranje_transakcija
{
    public partial class PopisTransakcija : Form
    {
        public PopisTransakcija()
        {
            InitializeComponent();
        }

        private void PopisTransakcija_Load(object sender, EventArgs e)
        {
            racuniDataGrid.DataSource = Banka.DohvatiPopisRacuna().ToList();
            foreach(Racun nazivRacuna in Banka.DohvatiPopisRacuna())
            {
                racunCombo.Items.Add(nazivRacuna.IBAN);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sveCheck.Checked = true;
            uplateRadio.Checked = false;
            isplateRadio.Checked = false;
            racunCombo.SelectedIndex = -1;
            racuniDataGrid.DataSource = Banka.DohvatiPopisRacuna().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Racun odabraniRacun = Banka.DohvatiRacun(racunCombo.Text);
            if (sveCheck.Checked)
            {
                racuniDataGrid.DataSource = odabraniRacun.DohvatiTransakcije().ToList();
            }
            else if (uplateRadio.Checked)
            {
                racuniDataGrid.DataSource = odabraniRacun.DohvatiUplate().ToList();
            }
            else
            {
                racuniDataGrid.DataSource = odabraniRacun.DohvatiIsplate().ToList();    
            }
        }

        private void isplateRadio_MouseDown(object sender, MouseEventArgs e)
        {
            sveCheck.Checked = false;
            uplateRadio.Checked = false;
        }

        private void uplateRadio_MouseDown(object sender, MouseEventArgs e)
        {
            sveCheck.Checked = false;
            isplateRadio.Checked = false;
        }

        private void sveCheck_MouseDown(object sender, MouseEventArgs e)
        {
            isplateRadio.Checked = false;
            uplateRadio.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Racun zaDetalje = Banka.DohvatiRacun(racunCombo.Text);
            if(zaDetalje == null)
            {
                MessageBox.Show("Odaberite racun!");
                return;
            }
            DetaljiRacuna dr = new DetaljiRacuna(zaDetalje);
            dr.ShowDialog();
        }
    }
}
