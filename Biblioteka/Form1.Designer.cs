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
            this.prestitoButton = new System.Windows.Forms.Button();
            this.descrizioneUtenteTxt = new System.Windows.Forms.TextBox();
            this.descrizioneLibriPrestitoTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listboxLibri
            // 
            this.listboxLibri.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listboxLibri.FormattingEnabled = true;
            this.listboxLibri.Location = new System.Drawing.Point(10, 20);
            this.listboxLibri.Name = "listboxLibri";
            this.listboxLibri.Size = new System.Drawing.Size(226, 212);
            this.listboxLibri.TabIndex = 0;
            this.listboxLibri.SelectedIndexChanged += new System.EventHandler(this.listboxLibri_SelectedIndexChanged);
            // 
            // listboxUtenti
            // 
            this.listboxUtenti.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listboxUtenti.FormattingEnabled = true;
            this.listboxUtenti.Location = new System.Drawing.Point(518, 20);
            this.listboxUtenti.Name = "listboxUtenti";
            this.listboxUtenti.Size = new System.Drawing.Size(226, 212);
            this.listboxUtenti.TabIndex = 1;
            this.listboxUtenti.SelectedIndexChanged += new System.EventHandler(this.listboxUtenti_SelectedIndexChanged);
            // 
            // descrizioneLibroTxt
            // 
            this.descrizioneLibroTxt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.descrizioneLibroTxt.Location = new System.Drawing.Point(10, 256);
            this.descrizioneLibroTxt.Multiline = true;
            this.descrizioneLibroTxt.Name = "descrizioneLibroTxt";
            this.descrizioneLibroTxt.ReadOnly = true;
            this.descrizioneLibroTxt.Size = new System.Drawing.Size(226, 155);
            this.descrizioneLibroTxt.TabIndex = 2;
            this.descrizioneLibroTxt.Text = "qui descrivo il libro selezionato";
            // 
            // prestitoButton
            // 
            this.prestitoButton.BackColor = System.Drawing.Color.Yellow;
            this.prestitoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.prestitoButton.Location = new System.Drawing.Point(301, 179);
            this.prestitoButton.Name = "prestitoButton";
            this.prestitoButton.Size = new System.Drawing.Size(150, 81);
            this.prestitoButton.TabIndex = 6;
            this.prestitoButton.Text = "Presta il libro selezionato all\'utente selezionato";
            this.prestitoButton.UseVisualStyleBackColor = false;
            this.prestitoButton.Click += new System.EventHandler(this.prestitoButton_Click);
            // 
            // descrizioneUtenteTxt
            // 
            this.descrizioneUtenteTxt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.descrizioneUtenteTxt.Location = new System.Drawing.Point(518, 256);
            this.descrizioneUtenteTxt.Multiline = true;
            this.descrizioneUtenteTxt.Name = "descrizioneUtenteTxt";
            this.descrizioneUtenteTxt.ReadOnly = true;
            this.descrizioneUtenteTxt.Size = new System.Drawing.Size(226, 82);
            this.descrizioneUtenteTxt.TabIndex = 9;
            this.descrizioneUtenteTxt.Text = "qui descrivo l\'utente selezionato";
            // 
            // descrizioneLibriPrestitoTxt
            // 
            this.descrizioneLibriPrestitoTxt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.descrizioneLibriPrestitoTxt.Location = new System.Drawing.Point(518, 329);
            this.descrizioneLibriPrestitoTxt.Multiline = true;
            this.descrizioneLibriPrestitoTxt.Name = "descrizioneLibriPrestitoTxt";
            this.descrizioneLibriPrestitoTxt.ReadOnly = true;
            this.descrizioneLibriPrestitoTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descrizioneLibriPrestitoTxt.Size = new System.Drawing.Size(226, 82);
            this.descrizioneLibriPrestitoTxt.TabIndex = 10;
            this.descrizioneLibriPrestitoTxt.Text = "qui mostro tutti i libri che l\'utente selezionato ha in prestito";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(776, 433);
            this.Controls.Add(this.descrizioneLibriPrestitoTxt);
            this.Controls.Add(this.descrizioneUtenteTxt);
            this.Controls.Add(this.prestitoButton);
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
        private System.Windows.Forms.TextBox descrizioneLibroTxt;
        private System.Windows.Forms.Button prestitoButton;
        private System.Windows.Forms.TextBox descrizioneUtenteTxt;
        private System.Windows.Forms.TextBox descrizioneLibriPrestitoTxt;
        public System.Windows.Forms.ListBox listboxLibri;
        public System.Windows.Forms.ListBox listboxUtenti;
    }
}

