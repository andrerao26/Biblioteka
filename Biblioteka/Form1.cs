﻿using System;
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
            Seeder.generateLibri(listboxLibri);
        }

        private void generaUtentiButton_Click(object sender, EventArgs e)
        {
            Seeder.generateUtenti(listboxUtenti);
        }
       
        private void prestitoButton_Click(object sender, EventArgs e)
        {
            Utente user = listboxUtenti.SelectedItem as Utente;
            Libro book = listboxLibri.SelectedItem as Libro;

            if (book.prestaLibro(user))
            {
                disponibilitàLibroTxt.Text = "Il prestito del libro " + book.titolo + " è stato effettuato con successo a " + user.ToString();
                descrizioneUtenteTxt.Text = user.describeUtente();
                descrizioneLibriPrestitoTxt.Text = user.describeLibriPrestito();
            }
            else
            {
                disponibilitàLibroTxt.Text = "Il prestito del libro " + book.titolo + " non è andato a buon fine. \r\n" +
                                             "Il libro è già attualmente in prestito a " + book.possessore.ToString();
            }
        }

        private void describeLibroButton_Click(object sender, EventArgs e)
        {
            Libro book = listboxLibri.SelectedItem as Libro;
            descrizioneLibroTxt.Text = book.describeLibro();
        }

        private void describeUtenteButton_Click(object sender, EventArgs e)
        {
            Utente user = listboxUtenti.SelectedItem as Utente;
            descrizioneUtenteTxt.Text = user.describeUtente();
        }

        private void describeLibriPrestitoButton_Click(object sender, EventArgs e)
        {
            Utente user = listboxUtenti.SelectedItem as Utente;
            descrizioneLibriPrestitoTxt.Text = user.describeLibriPrestito();
        }

        private void listboxUtenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            descrizioneUtenteTxt.Text = "qui descrivo l'utente selezionato";
            descrizioneLibriPrestitoTxt.Text = "qui mostro tutti i libri che l'utente selezionato ha in prestito";
        }

        private void listboxLibri_SelectedIndexChanged(object sender, EventArgs e)
        {
            descrizioneLibroTxt.Text = "qui descrivo il libro selezionato";
        }
    }
}
