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
            
        }

        private void generaLibriButton_Click(object sender, EventArgs e)
        {
            Seeder.generateLibri();
        }

        private void generaUtentiButton_Click(object sender, EventArgs e)
        {
            Seeder.generateUtenti();
        }
       
        private void prestitoButton_Click(object sender, EventArgs e)
        {
            Utente user = listboxUtenti.Items[listboxUtenti.SelectedIndex] as Utente;
            Libro book = listboxLibri.Items[listboxLibri.SelectedIndex] as Libro;
            book.prestaLibro(user);
        }

        private void describeLibroButton_Click(object sender, EventArgs e)
        {
            Libro book = listboxLibri.Items[listboxLibri.SelectedIndex] as Libro;
            book.describeLibro();
        }

        private void describeUtenteButton_Click(object sender, EventArgs e)
        {
            Utente user = listboxUtenti.Items[listboxUtenti.SelectedIndex] as Utente;
            user.describeUtente();
        }

        private void describeLibriPrestitoButton_Click(object sender, EventArgs e)
        {
            Utente user = listboxUtenti.Items[listboxUtenti.SelectedIndex] as Utente;
            user.describeLibriPrestito();
        }

        private void listboxLibri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
