using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bodovi;

namespace Bodovi_i_aktivnosti
{
    public partial class FrmNoviBodovi : Form
    {
        private Student student;
        private Provjera provjera;
        public FrmNoviBodovi(Student student, Provjera provjera)
        {
            InitializeComponent();
            this.student = student;
            this.provjera = provjera;
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pohraniBtn_Click(object sender, EventArgs e)
        {
            BodoviNaProvjeri bnp = student.BodoviNaProvjerama.Find(x => x.Provjera == provjera);
            bool postoji = true;
            if(bnp == null)
            {
                bnp = new BodoviNaProvjeri();
                postoji = false;
            }
            bnp.Provjera = provjera;
            bnp.Bodovi = int.Parse(brBodTextBox.Text);
            if (!postoji)
            {
                student.BodoviNaProvjerama.Add(bnp);
            }
            Close();
        }

        private void FrmNoviBodovi_Load(object sender, EventArgs e)
        {
            imeStudentaLbl.Text = student.ImePrezime;
            nazProvLbl.Text = provjera.Naziv;
            maxBrBodLbl.Text = $"/ {provjera.MoguciBodovi}";
        }
    }
}
