using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                listboxLibri.Items.Add(Seeder.generateLibro());
                listboxUtenti.Items.Add(Seeder.generateUtente());
            }
        }

        private void prestitoButton_Click(object sender, EventArgs e)
        {
            Utente user = listboxUtenti.SelectedItem as Utente;
            Libro book = listboxLibri.SelectedItem as Libro;

            if (user == null || book == null)
            {
                MessageBox.Show("Selezionare almeno un libro e un utente", "Selezionare un libro o un utente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                book.prestaLibro(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            descrizioneUtenteTxt.Text = user.describeUtente();
            descrizioneLibriPrestitoTxt.Text = user.describeLibriPrestito();
            descrizioneLibroTxt.Text = book.describeLibro();
        }

        private void describeLibriPrestitoButton_Click(object sender, EventArgs e)
        {
            Utente user = listboxUtenti.SelectedItem as Utente;
            descrizioneLibriPrestitoTxt.Text = user.describeLibriPrestito();
        }

        private void listboxUtenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utente user = listboxUtenti.SelectedItem as Utente;
            descrizioneUtenteTxt.Text = user.describeUtente();
            descrizioneLibriPrestitoTxt.Text = user.describeLibriPrestito();
        }

        private void listboxLibri_SelectedIndexChanged(object sender, EventArgs e)
        {
            Libro book = listboxLibri.SelectedItem as Libro;
            descrizioneLibroTxt.Text = book.describeLibro();
        }
    }
}
