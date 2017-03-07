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
            this.listboxLibri = new System.Windows.Forms.ListBox();
            this.listboxUtenti = new System.Windows.Forms.ListBox();
            this.descrizioneLibroTxt = new System.Windows.Forms.TextBox();
            this.disponibilitàLibroTxt = new System.Windows.Forms.TextBox();
            this.generaLibriButton = new System.Windows.Forms.Button();
            this.generaUtentiButton = new System.Windows.Forms.Button();
            this.prestitoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listboxLibri
            // 
            this.listboxLibri.FormattingEnabled = true;
            this.listboxLibri.ItemHeight = 16;
            this.listboxLibri.Location = new System.Drawing.Point(13, 13);
            this.listboxLibri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listboxLibri.Name = "listboxLibri";
            this.listboxLibri.Size = new System.Drawing.Size(275, 180);
            this.listboxLibri.TabIndex = 0;
            // 
            // listboxUtenti
            // 
            this.listboxUtenti.FormattingEnabled = true;
            this.listboxUtenti.ItemHeight = 16;
            this.listboxUtenti.Location = new System.Drawing.Point(690, 13);
            this.listboxUtenti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listboxUtenti.Name = "listboxUtenti";
            this.listboxUtenti.Size = new System.Drawing.Size(280, 180);
            this.listboxUtenti.TabIndex = 1;
            // 
            // descrizioneLibroTxt
            // 
            this.descrizioneLibroTxt.Location = new System.Drawing.Point(379, 13);
            this.descrizioneLibroTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descrizioneLibroTxt.Multiline = true;
            this.descrizioneLibroTxt.Name = "descrizioneLibroTxt";
            this.descrizioneLibroTxt.Size = new System.Drawing.Size(250, 70);
            this.descrizioneLibroTxt.TabIndex = 2;
            this.descrizioneLibroTxt.Text = "qui descrivo il libro selezionato";
            // 
            // disponibilitàLibroTxt
            // 
            this.disponibilitàLibroTxt.Location = new System.Drawing.Point(379, 123);
            this.disponibilitàLibroTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.disponibilitàLibroTxt.MaxLength = 489932767;
            this.disponibilitàLibroTxt.Multiline = true;
            this.disponibilitàLibroTxt.Name = "disponibilitàLibroTxt";
            this.disponibilitàLibroTxt.Size = new System.Drawing.Size(250, 70);
            this.disponibilitàLibroTxt.TabIndex = 3;
            this.disponibilitàLibroTxt.Text = "qui mostro la disponibilità del libro";
            // 
            // generaLibriButton
            // 
            this.generaLibriButton.Location = new System.Drawing.Point(13, 201);
            this.generaLibriButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generaLibriButton.Name = "generaLibriButton";
            this.generaLibriButton.Size = new System.Drawing.Size(125, 68);
            this.generaLibriButton.TabIndex = 4;
            this.generaLibriButton.Text = "genera libri";
            this.generaLibriButton.UseVisualStyleBackColor = true;
            this.generaLibriButton.Click += new System.EventHandler(this.generaLibriButton_Click);
            // 
            // generaUtentiButton
            // 
            this.generaUtentiButton.Location = new System.Drawing.Point(846, 201);
            this.generaUtentiButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generaUtentiButton.Name = "generaUtentiButton";
            this.generaUtentiButton.Size = new System.Drawing.Size(124, 68);
            this.generaUtentiButton.TabIndex = 5;
            this.generaUtentiButton.Text = "genera utenti";
            this.generaUtentiButton.UseVisualStyleBackColor = true;
            this.generaUtentiButton.Click += new System.EventHandler(this.generaUtentiButton_Click);
            // 
            // prestitoButton
            // 
            this.prestitoButton.Location = new System.Drawing.Point(379, 201);
            this.prestitoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prestitoButton.Name = "prestitoButton";
            this.prestitoButton.Size = new System.Drawing.Size(250, 100);
            this.prestitoButton.TabIndex = 6;
            this.prestitoButton.Text = "Prende il select.index nella listbox dei libri e lo presta all\'utente selezionato" +
    "";
            this.prestitoButton.UseVisualStyleBackColor = true;
            this.prestitoButton.Click += new System.EventHandler(this.prestitoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 719);
            this.Controls.Add(this.prestitoButton);
            this.Controls.Add(this.generaUtentiButton);
            this.Controls.Add(this.generaLibriButton);
            this.Controls.Add(this.disponibilitàLibroTxt);
            this.Controls.Add(this.descrizioneLibroTxt);
            this.Controls.Add(this.listboxUtenti);
            this.Controls.Add(this.listboxLibri);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button generaLibriButton;
        private System.Windows.Forms.Button generaUtentiButton;
        private System.Windows.Forms.Button prestitoButton;
    }
}

