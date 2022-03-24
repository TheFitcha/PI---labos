using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KucnaKnjiznicaLib;

namespace KucnaKnjiznica
{
    public partial class NovaPosudba : Form
    {
        private Knjiga knjiga;
        private Knjiznica knjiznica;
        public NovaPosudba(Knjiga knjiga, Knjiznica knjiznica)
        {
            InitializeComponent();
            this.knjiga = knjiga;
            this.knjiznica = knjiznica;
        }

        private void NovaPosudba_Load(object sender, EventArgs e)
        {
            ISBNBox.Text = knjiga.ISBN;
            naslovBox.Text = knjiga.Naslov;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            knjiznica.PosudiKnjigu(knjiga, osobaBox.Text);
            Close();
        }
    }
}
