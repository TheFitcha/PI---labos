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
    public partial class Form1 : Form
    {
        private List<Student> studenti = new List<Student>();
        private Student odabraniStudent;
        private Provjera odabranaProvjera;
        private List<Provjera> popisProvjera = new List<Provjera>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrikaziStudente();
            osvjeziPopisProvjera();
        }

        private void PrikaziStudente()
        {
            BindingSource bs = new BindingSource(studenti, "");
            popisStudDataGrid.DataSource = bs;
            popisStudDataGrid.Columns[0].Width = 150;
            popisStudDataGrid.Columns[1].Width = 150;
        }

        private void popisStudDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (popisStudDataGrid.CurrentRow != null)
            {
                odabraniStudent = popisStudDataGrid.CurrentRow.DataBoundItem as Student;
            }
        }

        

        private void osvjeziPopisProvjera()
        {
            provjereCombo.Items.Clear();
            foreach(Provjera provjera in popisProvjera)
            {
                provjereCombo.Items.Add($"{provjera.Naziv} ({provjera.MoguciBodovi})");
            }
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            Student noviStudent = new Student();
            noviStudent.ImePrezime = imePrezimeStudBox.Text;
            studenti.Add(noviStudent);
            PrikaziStudente();
        }

        private void dodajProvjeruBtn_Click(object sender, EventArgs e)
        {
            Provjera novaProvjera = new Provjera();
            novaProvjera.Naziv = nazivProvjereBox.Text;
            novaProvjera.MoguciBodovi = Convert.ToInt32(moguciBodoviBox.Text);
            popisProvjera.Add(novaProvjera);
            osvjeziPopisProvjera();
        }

        private void ocijeniStudentaBtn_Click(object sender, EventArgs e)
        {
            
            FrmNoviBodovi fnb = new FrmNoviBodovi(odabraniStudent, odabranaProvjera);
            fnb.FormClosing += fnb_Closing;
            fnb.ShowDialog();
        }
        private void fnb_Closing(object sender, FormClosingEventArgs e)
        {
            PrikaziStudente();
        }

        private void provjereCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = provjereCombo.Text;
            string subs = selectedItem.Substring(0, selectedItem.Length - 5);
            odabranaProvjera = popisProvjera.Find(x => x.Naziv.Contains(selectedItem.Substring(0, selectedItem.Length-5)));
        }
    }
}
