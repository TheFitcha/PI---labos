using BankaLib;
using MjenjacnicaLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAdvanced
{
    public partial class FrmPregledTecaja : Form
    {
        public FrmPregledTecaja()
        {
            InitializeComponent();
        }

        private void FrmPregledTecaja_Load(object sender, EventArgs e)
        {
            OsvjeziPrikaz();
        }

        private void OsvjeziPrikaz()
        {
            tecajiDataGridView.DataSource = MjenjacnicaDB.PopisTecajeva.VratiSveTecajeve();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodajTecaj_Click(object sender, EventArgs e)
        {
            var form = new FrmNoviTecaj();
            form.ShowDialog();
            OsvjeziPrikaz();
        }

        private void btnIzmijeniTecaj_Click(object sender, EventArgs e)
        {
            var tecaj = DohvatiOdabraniTecaj();
            var form = new FrmIzmjenaTecaja(tecaj);
            form.ShowDialog();
            OsvjeziPrikaz();
        }

        private Tecaj DohvatiOdabraniTecaj()
        {
            if (tecajiDataGridView.CurrentRow != null)
            {
                return tecajiDataGridView.CurrentRow.DataBoundItem as Tecaj;
            }
            return null;
        }
    }
}
