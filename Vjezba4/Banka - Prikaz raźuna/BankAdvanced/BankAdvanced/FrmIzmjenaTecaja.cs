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
    public partial class FrmIzmjenaTecaja : Form
    {
        public Tecaj OdabraniTecaj { get; set; }
        public FrmIzmjenaTecaja(Tecaj tecaj)
        {
            InitializeComponent();
            OdabraniTecaj = tecaj;
        }

        private void txtValuta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmIzmjenaTecaja_Load(object sender, EventArgs e)
        {
            txtReferentnaValuta.Text = MjenjacnicaDB.ReferentnaValuta.ToString();
            txtValuta.Text = OdabraniTecaj.Valuta.ToString();
            txtVrijednost.Text = OdabraniTecaj.Vrijednost.ToString();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            double novaVrijednost = double.Parse(txtVrijednost.Text);
            OdabraniTecaj.Vrijednost = novaVrijednost;
            Close();
        }
    }
}
