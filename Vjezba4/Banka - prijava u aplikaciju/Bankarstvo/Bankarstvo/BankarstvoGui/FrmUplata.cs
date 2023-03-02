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
    public partial class FrmUplata : Form
    {
        private Racun Racun;
        public FrmUplata(Racun odabraniRacun)
        {
            InitializeComponent();
            Racun = odabraniRacun;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProvedi_Click(object sender, EventArgs e)
        {
            string ibanPlatitelja = txtPlatitelj.Text;
            double iznos = double.Parse(txtIznos.Text);

            if (ibanPlatitelja != "" && iznos > 0)
            {
                Racun.Uplati(ibanPlatitelja, iznos);
                Close();
            }
            else
            {
                MessageBox.Show("Unesite ispravne podatke!)");
            }
        }

        private void FrmUplata_Load(object sender, EventArgs e)
        {
            txtPrimatelj.Text = Racun.ToString();
        }
    }
}
