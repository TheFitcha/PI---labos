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
    public partial class FrmIsplata : Form
    {
        private Racun Racun; 
        public FrmIsplata(Racun odabraniRacun)
        {
            InitializeComponent();
            Racun = odabraniRacun;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmIsplata_Load(object sender, EventArgs e)
        {
            txtPlatitelj.Text = Racun.ToString();
        }

        private void btnProvedi_Click(object sender, EventArgs e)
        {
            string ibanPrimatelja = txtPrimatelj.Text;
            double iznos = double.Parse(txtIznos.Text);

            if (ibanPrimatelja != "" && iznos > 0)
            {
                try
                {
                    Racun.Isplati(ibanPrimatelja, iznos);
                    Close();
                }
                catch (TransactionException ex)
                {
                    MessageBox.Show(ex.Poruka);
                }
            }
            else
            {
                MessageBox.Show("Unesite ispravne podatke!");
            }
        }
    }
}
