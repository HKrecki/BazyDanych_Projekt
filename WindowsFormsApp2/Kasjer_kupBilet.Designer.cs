namespace WindowsFormsApp2
{
    partial class Kasjer_kupBilet
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
            this.Kasjer_KupBilet_powitanie = new System.Windows.Forms.Label();
            this.ZakupBiletu_DaneKlienta_box = new System.Windows.Forms.GroupBox();
            this.ZakupBiletu_Znizka_textBox = new System.Windows.Forms.TextBox();
            this.ZakupBiletu_Telefon_textBox = new System.Windows.Forms.TextBox();
            this.ZakupBiletu_adres_textBox = new System.Windows.Forms.TextBox();
            this.ZakupBiletu_Nazwisko_textBox = new System.Windows.Forms.TextBox();
            this.ZakupBiletu_Imie_textBox = new System.Windows.Forms.TextBox();
            this.ZakupBiletu_DaneTrasy_box = new System.Windows.Forms.GroupBox();
            this.ZakupBiletu_godzina = new System.Windows.Forms.TextBox();
            this.ZakupBiletu_data = new System.Windows.Forms.TextBox();
            this.ZakupBiletu_stacjaPrzyjazdu = new System.Windows.Forms.TextBox();
            this.ZakupBiletu_stacjaOdjazdu = new System.Windows.Forms.TextBox();
            this.Zatwierdź = new System.Windows.Forms.Button();
            this.ZakupBiletu_Pesel_textBox = new System.Windows.Forms.TextBox();
            this.ZakupBiletu_DaneKlienta_box.SuspendLayout();
            this.ZakupBiletu_DaneTrasy_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Kasjer_KupBilet_powitanie
            // 
            this.Kasjer_KupBilet_powitanie.AutoSize = true;
            this.Kasjer_KupBilet_powitanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kasjer_KupBilet_powitanie.Location = new System.Drawing.Point(298, 59);
            this.Kasjer_KupBilet_powitanie.Name = "Kasjer_KupBilet_powitanie";
            this.Kasjer_KupBilet_powitanie.Size = new System.Drawing.Size(194, 24);
            this.Kasjer_KupBilet_powitanie.TabIndex = 3;
            this.Kasjer_KupBilet_powitanie.Text = "Zakup nowgo biletu";
            this.Kasjer_KupBilet_powitanie.Click += new System.EventHandler(this.Powitanie_kasjer_Click);
            // 
            // ZakupBiletu_DaneKlienta_box
            // 
            this.ZakupBiletu_DaneKlienta_box.Controls.Add(this.ZakupBiletu_Pesel_textBox);
            this.ZakupBiletu_DaneKlienta_box.Controls.Add(this.ZakupBiletu_Znizka_textBox);
            this.ZakupBiletu_DaneKlienta_box.Controls.Add(this.ZakupBiletu_Telefon_textBox);
            this.ZakupBiletu_DaneKlienta_box.Controls.Add(this.ZakupBiletu_adres_textBox);
            this.ZakupBiletu_DaneKlienta_box.Controls.Add(this.ZakupBiletu_Nazwisko_textBox);
            this.ZakupBiletu_DaneKlienta_box.Controls.Add(this.ZakupBiletu_Imie_textBox);
            this.ZakupBiletu_DaneKlienta_box.Location = new System.Drawing.Point(56, 104);
            this.ZakupBiletu_DaneKlienta_box.Name = "ZakupBiletu_DaneKlienta_box";
            this.ZakupBiletu_DaneKlienta_box.Size = new System.Drawing.Size(675, 172);
            this.ZakupBiletu_DaneKlienta_box.TabIndex = 4;
            this.ZakupBiletu_DaneKlienta_box.TabStop = false;
            this.ZakupBiletu_DaneKlienta_box.Text = "Dane klienta";
            // 
            // ZakupBiletu_Znizka_textBox
            // 
            this.ZakupBiletu_Znizka_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZakupBiletu_Znizka_textBox.Location = new System.Drawing.Point(376, 125);
            this.ZakupBiletu_Znizka_textBox.Name = "ZakupBiletu_Znizka_textBox";
            this.ZakupBiletu_Znizka_textBox.Size = new System.Drawing.Size(293, 28);
            this.ZakupBiletu_Znizka_textBox.TabIndex = 5;
            this.ZakupBiletu_Znizka_textBox.Tag = "";
            this.ZakupBiletu_Znizka_textBox.Text = "Zniżka";
            // 
            // ZakupBiletu_Telefon_textBox
            // 
            this.ZakupBiletu_Telefon_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZakupBiletu_Telefon_textBox.Location = new System.Drawing.Point(376, 72);
            this.ZakupBiletu_Telefon_textBox.Name = "ZakupBiletu_Telefon_textBox";
            this.ZakupBiletu_Telefon_textBox.Size = new System.Drawing.Size(293, 28);
            this.ZakupBiletu_Telefon_textBox.TabIndex = 4;
            this.ZakupBiletu_Telefon_textBox.Tag = "";
            this.ZakupBiletu_Telefon_textBox.Text = "Numer telefonu";
            // 
            // ZakupBiletu_adres_textBox
            // 
            this.ZakupBiletu_adres_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZakupBiletu_adres_textBox.Location = new System.Drawing.Point(6, 125);
            this.ZakupBiletu_adres_textBox.Name = "ZakupBiletu_adres_textBox";
            this.ZakupBiletu_adres_textBox.Size = new System.Drawing.Size(293, 28);
            this.ZakupBiletu_adres_textBox.TabIndex = 3;
            this.ZakupBiletu_adres_textBox.Tag = "";
            this.ZakupBiletu_adres_textBox.Text = "Adres";
            // 
            // ZakupBiletu_Nazwisko_textBox
            // 
            this.ZakupBiletu_Nazwisko_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZakupBiletu_Nazwisko_textBox.Location = new System.Drawing.Point(6, 72);
            this.ZakupBiletu_Nazwisko_textBox.Name = "ZakupBiletu_Nazwisko_textBox";
            this.ZakupBiletu_Nazwisko_textBox.Size = new System.Drawing.Size(293, 28);
            this.ZakupBiletu_Nazwisko_textBox.TabIndex = 2;
            this.ZakupBiletu_Nazwisko_textBox.Tag = "";
            this.ZakupBiletu_Nazwisko_textBox.Text = "Nazwisko";
            // 
            // ZakupBiletu_Imie_textBox
            // 
            this.ZakupBiletu_Imie_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZakupBiletu_Imie_textBox.Location = new System.Drawing.Point(6, 19);
            this.ZakupBiletu_Imie_textBox.Name = "ZakupBiletu_Imie_textBox";
            this.ZakupBiletu_Imie_textBox.Size = new System.Drawing.Size(293, 28);
            this.ZakupBiletu_Imie_textBox.TabIndex = 1;
            this.ZakupBiletu_Imie_textBox.Tag = "";
            this.ZakupBiletu_Imie_textBox.Text = "Imię";
            // 
            // ZakupBiletu_DaneTrasy_box
            // 
            this.ZakupBiletu_DaneTrasy_box.Controls.Add(this.ZakupBiletu_godzina);
            this.ZakupBiletu_DaneTrasy_box.Controls.Add(this.ZakupBiletu_data);
            this.ZakupBiletu_DaneTrasy_box.Controls.Add(this.ZakupBiletu_stacjaPrzyjazdu);
            this.ZakupBiletu_DaneTrasy_box.Controls.Add(this.ZakupBiletu_stacjaOdjazdu);
            this.ZakupBiletu_DaneTrasy_box.Location = new System.Drawing.Point(56, 282);
            this.ZakupBiletu_DaneTrasy_box.Name = "ZakupBiletu_DaneTrasy_box";
            this.ZakupBiletu_DaneTrasy_box.Size = new System.Drawing.Size(675, 100);
            this.ZakupBiletu_DaneTrasy_box.TabIndex = 5;
            this.ZakupBiletu_DaneTrasy_box.TabStop = false;
            this.ZakupBiletu_DaneTrasy_box.Text = "Dane przejazdu";
            // 
            // ZakupBiletu_godzina
            // 
            this.ZakupBiletu_godzina.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZakupBiletu_godzina.Location = new System.Drawing.Point(376, 63);
            this.ZakupBiletu_godzina.Name = "ZakupBiletu_godzina";
            this.ZakupBiletu_godzina.Size = new System.Drawing.Size(293, 28);
            this.ZakupBiletu_godzina.TabIndex = 4;
            this.ZakupBiletu_godzina.Tag = "";
            this.ZakupBiletu_godzina.Text = "Godzina";
            // 
            // ZakupBiletu_data
            // 
            this.ZakupBiletu_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZakupBiletu_data.Location = new System.Drawing.Point(376, 19);
            this.ZakupBiletu_data.Name = "ZakupBiletu_data";
            this.ZakupBiletu_data.Size = new System.Drawing.Size(293, 28);
            this.ZakupBiletu_data.TabIndex = 3;
            this.ZakupBiletu_data.Tag = "";
            this.ZakupBiletu_data.Text = "Data";
            // 
            // ZakupBiletu_stacjaPrzyjazdu
            // 
            this.ZakupBiletu_stacjaPrzyjazdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZakupBiletu_stacjaPrzyjazdu.Location = new System.Drawing.Point(6, 63);
            this.ZakupBiletu_stacjaPrzyjazdu.Name = "ZakupBiletu_stacjaPrzyjazdu";
            this.ZakupBiletu_stacjaPrzyjazdu.Size = new System.Drawing.Size(293, 28);
            this.ZakupBiletu_stacjaPrzyjazdu.TabIndex = 2;
            this.ZakupBiletu_stacjaPrzyjazdu.Tag = "";
            this.ZakupBiletu_stacjaPrzyjazdu.Text = "Stacja przyjazdu";
            // 
            // ZakupBiletu_stacjaOdjazdu
            // 
            this.ZakupBiletu_stacjaOdjazdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZakupBiletu_stacjaOdjazdu.Location = new System.Drawing.Point(6, 19);
            this.ZakupBiletu_stacjaOdjazdu.Name = "ZakupBiletu_stacjaOdjazdu";
            this.ZakupBiletu_stacjaOdjazdu.Size = new System.Drawing.Size(293, 28);
            this.ZakupBiletu_stacjaOdjazdu.TabIndex = 1;
            this.ZakupBiletu_stacjaOdjazdu.Tag = "";
            this.ZakupBiletu_stacjaOdjazdu.Text = "Stacja odjazdu";
            // 
            // Zatwierdź
            // 
            this.Zatwierdź.Location = new System.Drawing.Point(591, 395);
            this.Zatwierdź.Name = "Zatwierdź";
            this.Zatwierdź.Size = new System.Drawing.Size(140, 43);
            this.Zatwierdź.TabIndex = 6;
            this.Zatwierdź.Text = "Zatwierdź";
            this.Zatwierdź.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Zatwierdź.UseVisualStyleBackColor = true;
            this.Zatwierdź.Click += new System.EventHandler(this.Zatwierdź_Click);
            // 
            // ZakupBiletu_Pesel_textBox
            // 
            this.ZakupBiletu_Pesel_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZakupBiletu_Pesel_textBox.Location = new System.Drawing.Point(376, 19);
            this.ZakupBiletu_Pesel_textBox.Name = "ZakupBiletu_Pesel_textBox";
            this.ZakupBiletu_Pesel_textBox.Size = new System.Drawing.Size(293, 28);
            this.ZakupBiletu_Pesel_textBox.TabIndex = 6;
            this.ZakupBiletu_Pesel_textBox.Tag = "";
            this.ZakupBiletu_Pesel_textBox.Text = "PESEL";
            // 
            // Kasjer_kupBilet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Zatwierdź);
            this.Controls.Add(this.ZakupBiletu_DaneTrasy_box);
            this.Controls.Add(this.ZakupBiletu_DaneKlienta_box);
            this.Controls.Add(this.Kasjer_KupBilet_powitanie);
            this.Name = "Kasjer_kupBilet";
            this.Text = "Kasjer_kupBilet";
            this.ZakupBiletu_DaneKlienta_box.ResumeLayout(false);
            this.ZakupBiletu_DaneKlienta_box.PerformLayout();
            this.ZakupBiletu_DaneTrasy_box.ResumeLayout(false);
            this.ZakupBiletu_DaneTrasy_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kasjer_KupBilet_powitanie;
        private System.Windows.Forms.GroupBox ZakupBiletu_DaneKlienta_box;
        private System.Windows.Forms.TextBox ZakupBiletu_Znizka_textBox;
        private System.Windows.Forms.TextBox ZakupBiletu_Telefon_textBox;
        private System.Windows.Forms.TextBox ZakupBiletu_adres_textBox;
        private System.Windows.Forms.TextBox ZakupBiletu_Nazwisko_textBox;
        private System.Windows.Forms.TextBox ZakupBiletu_Imie_textBox;
        private System.Windows.Forms.GroupBox ZakupBiletu_DaneTrasy_box;
        private System.Windows.Forms.TextBox ZakupBiletu_godzina;
        private System.Windows.Forms.TextBox ZakupBiletu_data;
        private System.Windows.Forms.TextBox ZakupBiletu_stacjaPrzyjazdu;
        private System.Windows.Forms.TextBox ZakupBiletu_stacjaOdjazdu;
        private System.Windows.Forms.Button Zatwierdź;
        private System.Windows.Forms.TextBox ZakupBiletu_Pesel_textBox;
    }
}