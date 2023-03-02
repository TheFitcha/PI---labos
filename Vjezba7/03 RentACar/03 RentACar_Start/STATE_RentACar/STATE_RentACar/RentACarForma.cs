using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_RentACar
{
    public partial class RentACarForma : Form
    {
        private Vozilo _vozilo;
        public RentACarForma()
        {
            InitializeComponent();
        }

        private void RentACarForma_Load(object sender, EventArgs e)
        {
            _vozilo = new Vozilo("VŽ-100-NO", "Ford focus, 1.6 tdi");

            txtRegistracija.Text = _vozilo.Registracija;
            txtOpisModela.Text = _vozilo.Model;
            Osvjezi();
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            _vozilo.RezervirajVozilo();
            txtDatumRezervacije.Text = _vozilo.DatumRezervacije.ToString();
            Osvjezi();
        }

        private void btnPredaj_Click(object sender, EventArgs e)
        {
            _vozilo.PredajVozilo();
            txtDatumPredavanja.Text = _vozilo.DatumPredavanja.ToString();
            Osvjezi();
        }

        private void btnPregledaj_Click(object sender, EventArgs e)
        {
            _vozilo.PregledajVozilo(txtPregledNapravio.Text);
            Osvjezi();
        }

        private void btnUciniRaspolozivim_Click(object sender, EventArgs e)
        {
            _vozilo.UciniRaspolozivim();
            Osvjezi();
        }

        private void btnAktivirajVozilo_Click(object sender, EventArgs e)
        {
            _vozilo.AktivirajVozilo();
            Osvjezi();
        }

        private void btnDeaktivirajVozilo_Click(object sender, EventArgs e)
        {
            _vozilo.DeaktivirajVozilo();
            Osvjezi();
        }

        private void Osvjezi()
        {
            txtStatusVozila.Text = _vozilo.Stanje.TrenutniStatus.ToString();
            btnAktivirajVozilo.Enabled = _vozilo.Stanje.TrenutniStatus == StatusVozila.UKvaru;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
    