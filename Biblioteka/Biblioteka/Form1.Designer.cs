namespace Biblioteka
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
            this.lista_libri = new System.Windows.Forms.ListBox();
            this.lista_utenti = new System.Windows.Forms.ListBox();
            this.Descrizione_libro = new System.Windows.Forms.TextBox();
            this.Disponibilità_libro = new System.Windows.Forms.TextBox();
            this.genera_libri = new System.Windows.Forms.Button();
            this.genera_utenti = new System.Windows.Forms.Button();
            this.prestito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista_libri
            // 
            this.lista_libri.FormattingEnabled = true;
            this.lista_libri.Location = new System.Drawing.Point(12, 12);
            this.lista_libri.Name = "lista_libri";
            this.lista_libri.Size = new System.Drawing.Size(207, 147);
            this.lista_libri.TabIndex = 0;
            // 
            // lista_utenti
            // 
            this.lista_utenti.FormattingEnabled = true;
            this.lista_utenti.Location = new System.Drawing.Point(518, 12);
            this.lista_utenti.Name = "lista_utenti";
            this.lista_utenti.Size = new System.Drawing.Size(211, 147);
            this.lista_utenti.TabIndex = 1;
            // 
            // Descrizione_libro
            // 
            this.Descrizione_libro.Location = new System.Drawing.Point(284, 31);
            this.Descrizione_libro.Name = "Descrizione_libro";
            this.Descrizione_libro.Size = new System.Drawing.Size(183, 20);
            this.Descrizione_libro.TabIndex = 2;
            // 
            // Disponibilità_libro
            // 
            this.Disponibilità_libro.Location = new System.Drawing.Point(284, 94);
            this.Disponibilità_libro.MaxLength = 489932767;
            this.Disponibilità_libro.Name = "Disponibilità_libro";
            this.Disponibilità_libro.Size = new System.Drawing.Size(183, 20);
            this.Disponibilità_libro.TabIndex = 3;
            // 
            // genera_libri
            // 
            this.genera_libri.Location = new System.Drawing.Point(62, 165);
            this.genera_libri.Name = "genera_libri";
            this.genera_libri.Size = new System.Drawing.Size(94, 55);
            this.genera_libri.TabIndex = 4;
            this.genera_libri.Text = "genera_libri";
            this.genera_libri.UseVisualStyleBackColor = true;
            // 
            // genera_utenti
            // 
            this.genera_utenti.Location = new System.Drawing.Point(585, 165);
            this.genera_utenti.Name = "genera_utenti";
            this.genera_utenti.Size = new System.Drawing.Size(93, 55);
            this.genera_utenti.TabIndex = 5;
            this.genera_utenti.Text = "genera_utenti";
            this.genera_utenti.UseVisualStyleBackColor = true;
            this.genera_utenti.Click += new System.EventHandler(this.genera_utenti_Click);
            // 
            // prestito
            // 
            this.prestito.Location = new System.Drawing.Point(294, 136);
            this.prestito.Name = "prestito";
            this.prestito.Size = new System.Drawing.Size(173, 84);
            this.prestito.TabIndex = 6;
            this.prestito.Text = "Prende il select.index nella listbox dei libri e lo presta all\'utente";
            this.prestito.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 584);
            this.Controls.Add(this.prestito);
            this.Controls.Add(this.genera_utenti);
            this.Controls.Add(this.genera_libri);
            this.Controls.Add(this.Disponibilità_libro);
            this.Controls.Add(this.Descrizione_libro);
            this.Controls.Add(this.lista_utenti);
            this.Controls.Add(this.lista_libri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista_libri;
        private System.Windows.Forms.ListBox lista_utenti;
        private System.Windows.Forms.TextBox Descrizione_libro;
        private System.Windows.Forms.TextBox Disponibilità_libro;
        private System.Windows.Forms.Button genera_libri;
        private System.Windows.Forms.Button genera_utenti;
        private System.Windows.Forms.Button prestito;
    }
}

