﻿namespace Biblioteka
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listboxLibri = new System.Windows.Forms.ListBox();
            this.listboxUtenti = new System.Windows.Forms.ListBox();
            this.descrizioneLibroTxt = new System.Windows.Forms.TextBox();
            this.disponibilitàLibroTxt = new System.Windows.Forms.TextBox();
            this.generateLibriButton = new System.Windows.Forms.Button();
            this.generateUtentiButton = new System.Windows.Forms.Button();
            this.prestitoButton = new System.Windows.Forms.Button();
            this.describeUtenteButton = new System.Windows.Forms.Button();
            this.describeLibroButton = new System.Windows.Forms.Button();
            this.descrizioneUtenteTxt = new System.Windows.Forms.TextBox();
            this.descrizioneLibriPrestitoTxt = new System.Windows.Forms.TextBox();
            this.describeLibriPrestitoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listboxLibri
            // 
            this.listboxLibri.FormattingEnabled = true;
            this.listboxLibri.Location = new System.Drawing.Point(10, 11);
            this.listboxLibri.Name = "listboxLibri";
            this.listboxLibri.Size = new System.Drawing.Size(226, 160);
            this.listboxLibri.TabIndex = 0;
            this.listboxLibri.SelectedIndexChanged += new System.EventHandler(this.listboxLibri_SelectedIndexChanged);
            // 
            // listboxUtenti
            // 
            this.listboxUtenti.FormattingEnabled = true;
            this.listboxUtenti.Location = new System.Drawing.Point(518, 11);
            this.listboxUtenti.Name = "listboxUtenti";
            this.listboxUtenti.Size = new System.Drawing.Size(226, 160);
            this.listboxUtenti.TabIndex = 1;
            // 
            // descrizioneLibroTxt
            // 
            this.descrizioneLibroTxt.Location = new System.Drawing.Point(10, 241);
            this.descrizioneLibroTxt.Multiline = true;
            this.descrizioneLibroTxt.Name = "descrizioneLibroTxt";
            this.descrizioneLibroTxt.Size = new System.Drawing.Size(226, 82);
            this.descrizioneLibroTxt.TabIndex = 2;
            this.descrizioneLibroTxt.Text = "qui descrivo il libro selezionato";
            // 
            // disponibilitàLibroTxt
            // 
            this.disponibilitàLibroTxt.Location = new System.Drawing.Point(284, 11);
            this.disponibilitàLibroTxt.MaxLength = 489932767;
            this.disponibilitàLibroTxt.Multiline = true;
            this.disponibilitàLibroTxt.Name = "disponibilitàLibroTxt";
            this.disponibilitàLibroTxt.Size = new System.Drawing.Size(188, 82);
            this.disponibilitàLibroTxt.TabIndex = 3;
            this.disponibilitàLibroTxt.Text = "qui mostro la disponibilità del libro e l\'esito del prestito";
            // 
            // generateLibriButton
            // 
            this.generateLibriButton.Location = new System.Drawing.Point(10, 176);
            this.generateLibriButton.Name = "generateLibriButton";
            this.generateLibriButton.Size = new System.Drawing.Size(75, 41);
            this.generateLibriButton.TabIndex = 4;
            this.generateLibriButton.Text = "genera libri";
            this.generateLibriButton.UseVisualStyleBackColor = true;
            this.generateLibriButton.Click += new System.EventHandler(this.generaLibriButton_Click);
            // 
            // generateUtentiButton
            // 
            this.generateUtentiButton.Location = new System.Drawing.Point(668, 176);
            this.generateUtentiButton.Name = "generateUtentiButton";
            this.generateUtentiButton.Size = new System.Drawing.Size(75, 41);
            this.generateUtentiButton.TabIndex = 5;
            this.generateUtentiButton.Text = "genera utenti";
            this.generateUtentiButton.UseVisualStyleBackColor = true;
            this.generateUtentiButton.Click += new System.EventHandler(this.generaUtentiButton_Click);
            // 
            // prestitoButton
            // 
            this.prestitoButton.Location = new System.Drawing.Point(284, 156);
            this.prestitoButton.Name = "prestitoButton";
            this.prestitoButton.Size = new System.Drawing.Size(188, 81);
            this.prestitoButton.TabIndex = 6;
            this.prestitoButton.Text = "Prende il SelectedIndex nella listbox dei libri e lo presta all\'utente selezionat" +
    "o";
            this.prestitoButton.UseVisualStyleBackColor = true;
            this.prestitoButton.Click += new System.EventHandler(this.prestitoButton_Click);
            // 
            // describeUtenteButton
            // 
            this.describeUtenteButton.Location = new System.Drawing.Point(518, 176);
            this.describeUtenteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.describeUtenteButton.Name = "describeUtenteButton";
            this.describeUtenteButton.Size = new System.Drawing.Size(56, 41);
            this.describeUtenteButton.TabIndex = 7;
            this.describeUtenteButton.Text = "descrivi utente";
            this.describeUtenteButton.UseVisualStyleBackColor = true;
            this.describeUtenteButton.Click += new System.EventHandler(this.describeUtenteButton_Click);
            // 
            // describeLibroButton
            // 
            this.describeLibroButton.Location = new System.Drawing.Point(178, 176);
            this.describeLibroButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.describeLibroButton.Name = "describeLibroButton";
            this.describeLibroButton.Size = new System.Drawing.Size(56, 41);
            this.describeLibroButton.TabIndex = 8;
            this.describeLibroButton.Text = "descrivi libro";
            this.describeLibroButton.UseVisualStyleBackColor = true;
            this.describeLibroButton.Click += new System.EventHandler(this.describeLibroButton_Click);
            // 
            // descrizioneUtenteTxt
            // 
            this.descrizioneUtenteTxt.Location = new System.Drawing.Point(518, 241);
            this.descrizioneUtenteTxt.Multiline = true;
            this.descrizioneUtenteTxt.Name = "descrizioneUtenteTxt";
            this.descrizioneUtenteTxt.Size = new System.Drawing.Size(226, 82);
            this.descrizioneUtenteTxt.TabIndex = 9;
            this.descrizioneUtenteTxt.Text = "qui descrivo l\'utente selezionato";
            // 
            // descrizioneLibriPrestitoTxt
            // 
            this.descrizioneLibriPrestitoTxt.Location = new System.Drawing.Point(518, 329);
            this.descrizioneLibriPrestitoTxt.Multiline = true;
            this.descrizioneLibriPrestitoTxt.Name = "descrizioneLibriPrestitoTxt";
            this.descrizioneLibriPrestitoTxt.Size = new System.Drawing.Size(226, 82);
            this.descrizioneLibriPrestitoTxt.TabIndex = 10;
            this.descrizioneLibriPrestitoTxt.Text = "qui mostro tutti i libri che l\'utente selezionato ha in prestito";
            // 
            // describeLibriPrestitoButton
            // 
            this.describeLibriPrestitoButton.Location = new System.Drawing.Point(578, 176);
            this.describeLibriPrestitoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.describeLibriPrestitoButton.Name = "describeLibriPrestitoButton";
            this.describeLibriPrestitoButton.Size = new System.Drawing.Size(75, 41);
            this.describeLibriPrestitoButton.TabIndex = 11;
            this.describeLibriPrestitoButton.Text = "mostra libri in prestito";
            this.describeLibriPrestitoButton.UseVisualStyleBackColor = true;
            this.describeLibriPrestitoButton.Click += new System.EventHandler(this.describeLibriPrestitoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 423);
            this.Controls.Add(this.describeLibriPrestitoButton);
            this.Controls.Add(this.descrizioneLibriPrestitoTxt);
            this.Controls.Add(this.descrizioneUtenteTxt);
            this.Controls.Add(this.describeLibroButton);
            this.Controls.Add(this.describeUtenteButton);
            this.Controls.Add(this.prestitoButton);
            this.Controls.Add(this.generateUtentiButton);
            this.Controls.Add(this.generateLibriButton);
            this.Controls.Add(this.disponibilitàLibroTxt);
            this.Controls.Add(this.descrizioneLibroTxt);
            this.Controls.Add(this.listboxUtenti);
            this.Controls.Add(this.listboxLibri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxLibri;
        private System.Windows.Forms.ListBox listboxUtenti;
        private System.Windows.Forms.TextBox descrizioneLibroTxt;
        private System.Windows.Forms.TextBox disponibilitàLibroTxt;
        private System.Windows.Forms.Button generateLibriButton;
        private System.Windows.Forms.Button generateUtentiButton;
        private System.Windows.Forms.Button prestitoButton;
        private System.Windows.Forms.Button describeUtenteButton;
        private System.Windows.Forms.Button describeLibroButton;
        private System.Windows.Forms.TextBox descrizioneUtenteTxt;
        private System.Windows.Forms.TextBox descrizioneLibriPrestitoTxt;
        private System.Windows.Forms.Button describeLibriPrestitoButton;
    }
}

