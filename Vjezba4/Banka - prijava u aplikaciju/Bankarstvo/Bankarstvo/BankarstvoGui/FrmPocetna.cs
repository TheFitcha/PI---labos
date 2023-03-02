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
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
        }

        private void FrmPocetna_Load(object sender, EventArgs e)
        {
            PokreniPrijavnuFormu();
        }

        private static void PokreniPrijavnuFormu()
        {
            var prijavnaForma = new FrmPrijava();
            prijavnaForma.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Autentifikator.Odjavi();
            PokreniPrijavnuFormu();
        }

        private void pogledajProfiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmProfilKorisnika();
            form.ShowDialog();
        }

        private void pregledRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmRacuni();
            form.ShowDialog();
        }
    }
}
