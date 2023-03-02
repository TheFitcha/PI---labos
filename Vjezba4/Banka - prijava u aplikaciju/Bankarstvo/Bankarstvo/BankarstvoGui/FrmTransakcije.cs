using BankarstvoLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankarstvoGui
{
    public partial class FrmTransakcije : Form
    {
        private Racun OdabraniRacun;
        public FrmTransakcije(Racun odabraniRacun)
        {
            InitializeComponent();
            OdabraniRacun = odabraniRacun;
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmTransakcije_Load(object sender, EventArgs e)
        {
            PrikaziTransakcije();
        }

        private void PrikaziTransakcije()
        {
            if (OdabraniRacun != null)
            {
                dgvTransakcije.DataSource = OdabraniRacun.DohvatiSveTransakcije();
            }
        }

        private void btnUplati_Click(object sender, EventArgs e)
        {
            var uplatiForm = new FrmUplata(OdabraniRacun);
            uplatiForm.ShowDialog();
            PrikaziTransakcije();
        }

        private void btnIsplati_Click(object sender, EventArgs e)
        {
            var isplatiForm = new FrmIsplata(OdabraniRacun);
            isplatiForm.ShowDialog();
            PrikaziTransakcije();
        }
    }
}
