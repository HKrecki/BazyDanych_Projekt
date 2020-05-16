namespace WindowsFormsApp2
{
    partial class KierownikZmiany_anulujBilet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Powitanie_anulowanieBiletu = new System.Windows.Forms.Label();
            this.daneKlienta_groupBox = new System.Windows.Forms.GroupBox();
            this.nazwisko_TextBox = new System.Windows.Forms.TextBox();
            this.Imie_TextBox = new System.Windows.Forms.TextBox();
            this.daneTransakcji_groupBox = new System.Windows.Forms.GroupBox();
            this.numerBiletu_TextBox = new System.Windows.Forms.TextBox();
            this.Zatwierdź = new System.Windows.Forms.Button();
            this.daneKlienta_groupBox.SuspendLayout();
            this.daneTransakcji_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Powitanie_anulowanieBiletu
            // 
            this.Powitanie_anulowanieBiletu.AutoSize = true;
            this.Powitanie_anulowanieBiletu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Powitanie_anulowanieBiletu.Location = new System.Drawing.Point(286, 60);
            this.Powitanie_anulowanieBiletu.Name = "Powitanie_anulowanieBiletu";
            this.Powitanie_anulowanieBiletu.Size = new System.Drawing.Size(177, 24);
            this.Powitanie_anulowanieBiletu.TabIndex = 1;
            this.Powitanie_anulowanieBiletu.Text = "Anulowanie biletu";
            // 
            // daneKlienta_groupBox
            // 
            this.daneKlienta_groupBox.Controls.Add(this.nazwisko_TextBox);
            this.daneKlienta_groupBox.Controls.Add(this.Imie_TextBox);
            this.daneKlienta_groupBox.Location = new System.Drawing.Point(40, 117);
            this.daneKlienta_groupBox.Name = "daneKlienta_groupBox";
            this.daneKlienta_groupBox.Size = new System.Drawing.Size(724, 129);
            this.daneKlienta_groupBox.TabIndex = 2;
            this.daneKlienta_groupBox.TabStop = false;
            this.daneKlienta_groupBox.Text = "Dane klienta";
            this.daneKlienta_groupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nazwisko_TextBox
            // 
            this.nazwisko_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwisko_TextBox.Location = new System.Drawing.Point(29, 72);
            this.nazwisko_TextBox.Name = "nazwisko_TextBox";
            this.nazwisko_TextBox.Size = new System.Drawing.Size(293, 28);
            this.nazwisko_TextBox.TabIndex = 2;
            this.nazwisko_TextBox.Tag = "";
            this.nazwisko_TextBox.Text = "Nazwisko";
            this.nazwisko_TextBox.TextChanged += new System.EventHandler(this.nazwisko_TextBox_TextChanged);
            // 
            // Imie_TextBox
            // 
            this.Imie_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Imie_TextBox.Location = new System.Drawing.Point(29, 19);
            this.Imie_TextBox.Name = "Imie_TextBox";
            this.Imie_TextBox.Size = new System.Drawing.Size(293, 28);
            this.Imie_TextBox.TabIndex = 1;
            this.Imie_TextBox.Tag = "";
            this.Imie_TextBox.Text = "Imię";
            this.Imie_TextBox.TextChanged += new System.EventHandler(this.nazwisko_TextBox_TextChanged);
            // 
            // daneTransakcji_groupBox
            // 
            this.daneTransakcji_groupBox.Controls.Add(this.numerBiletu_TextBox);
            this.daneTransakcji_groupBox.Location = new System.Drawing.Point(40, 274);
            this.daneTransakcji_groupBox.Name = "daneTransakcji_groupBox";
            this.daneTransakcji_groupBox.Size = new System.Drawing.Size(724, 84);
            this.daneTransakcji_groupBox.TabIndex = 3;
            this.daneTransakcji_groupBox.TabStop = false;
            this.daneTransakcji_groupBox.Text = "Dane transakcji";
            this.daneTransakcji_groupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numerBiletu_TextBox
            // 
            this.numerBiletu_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numerBiletu_TextBox.Location = new System.Drawing.Point(29, 38);
            this.numerBiletu_TextBox.Name = "numerBiletu_TextBox";
            this.numerBiletu_TextBox.Size = new System.Drawing.Size(293, 28);
            this.numerBiletu_TextBox.TabIndex = 2;
            this.numerBiletu_TextBox.Tag = "";
            this.numerBiletu_TextBox.Text = "Numer transakcji";
            // 
            // Zatwierdź
            // 
            this.Zatwierdź.Location = new System.Drawing.Point(624, 384);
            this.Zatwierdź.Name = "Zatwierdź";
            this.Zatwierdź.Size = new System.Drawing.Size(140, 43);
            this.Zatwierdź.TabIndex = 4;
            this.Zatwierdź.Text = "Zatwierdź";
            this.Zatwierdź.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Zatwierdź.UseVisualStyleBackColor = true;
            this.Zatwierdź.Click += new System.EventHandler(this.Zatwierdź_Click);
            // 
            // KierownikZmiany_anulujBilet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Zatwierdź);
            this.Controls.Add(this.daneTransakcji_groupBox);
            this.Controls.Add(this.daneKlienta_groupBox);
            this.Controls.Add(this.Powitanie_anulowanieBiletu);
            this.Name = "KierownikZmiany_anulujBilet";
            this.Text = "KierownikZmiany_anulujBilet";
            this.daneKlienta_groupBox.ResumeLayout(false);
            this.daneKlienta_groupBox.PerformLayout();
            this.daneTransakcji_groupBox.ResumeLayout(false);
            this.daneTransakcji_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Powitanie_anulowanieBiletu;
        private System.Windows.Forms.GroupBox daneKlienta_groupBox;
        private System.Windows.Forms.TextBox Imie_TextBox;
        private System.Windows.Forms.TextBox nazwisko_TextBox;
        private System.Windows.Forms.GroupBox daneTransakcji_groupBox;
        private System.Windows.Forms.TextBox numerBiletu_TextBox;
        private System.Windows.Forms.Button Zatwierdź;
    }
}