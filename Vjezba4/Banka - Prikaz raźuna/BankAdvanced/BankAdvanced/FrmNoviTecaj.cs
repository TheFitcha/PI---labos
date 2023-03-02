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
    public partial class FrmNoviTecaj : Form
    {
        public FrmNoviTecaj()
        {
            InitializeComponent();
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
            cmbValuta.DataSource = MjenjacnicaDB.Valute.ToList();
            txtVrijednost.Text = "0";
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            double vrijednost = double.Parse(txtVrijednost.Text);
            var odabranaValuta = cmbValuta.SelectedItem as Valuta;
            MjenjacnicaDB.PopisTecajeva.KreirajNoviTecaj(odabranaValuta, vrijednost);
            
            Close();
        }
    }
}
