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
    public partial class DetaljiRacuna : Form
    {
        private Racun racun;
        public DetaljiRacuna(Racun racun)
        {
            InitializeComponent();
            this.racun = racun;
        }

        private void DetaljiRacuna_Load(object sender, EventArgs e)
        {
            IBANBox.Text = racun.IBAN;
            vlasnikBox.Text = racun.Vlasnik;
            stanjeBox.Text = racun.Stanje.ToString();
            ukPrometBox.Text = racun.IzracunajUkupanPromet().ToString();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
