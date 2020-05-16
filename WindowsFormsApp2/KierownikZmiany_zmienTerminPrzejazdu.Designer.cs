namespace WindowsFormsApp2
{
    partial class KierownikZmiany_zmienTerminPrzejazdu
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
            this.Powitanie_zmianaTerminuPrzejazdu = new System.Windows.Forms.Label();
            this.daneKlienta_zmianaTerminu = new System.Windows.Forms.GroupBox();
            this.nazwisko_zmianaTerminu = new System.Windows.Forms.TextBox();
            this.Imie_zmianaTerminu = new System.Windows.Forms.TextBox();
            this.ZmianaTerminu_data = new System.Windows.Forms.GroupBox();
            this.nowaData_ZmianaTerminu = new System.Windows.Forms.TextBox();
            this.staraData_ZmianaTerminu = new System.Windows.Forms.TextBox();
            this.Zatwierdź = new System.Windows.Forms.Button();
            this.NumerBiletu_GroupBox = new System.Windows.Forms.GroupBox();
            this.NumerBiletu_TextBox = new System.Windows.Forms.TextBox();
            this.daneKlienta_zmianaTerminu.SuspendLayout();
            this.ZmianaTerminu_data.SuspendLayout();
            this.NumerBiletu_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Powitanie_zmianaTerminuPrzejazdu
            // 
            this.Powitanie_zmianaTerminuPrzejazdu.AutoSize = true;
            this.Powitanie_zmianaTerminuPrzejazdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Powitanie_zmianaTerminuPrzejazdu.Location = new System.Drawing.Point(269, 40);
            this.Powitanie_zmianaTerminuPrzejazdu.Name = "Powitanie_zmianaTerminuPrzejazdu";
            this.Powitanie_zmianaTerminuPrzejazdu.Size = new System.Drawing.Size(252, 24);
            this.Powitanie_zmianaTerminuPrzejazdu.TabIndex = 2;
            this.Powitanie_zmianaTerminuPrzejazdu.Text = "Zmiana terminu przejazdu";
            // 
            // daneKlienta_zmianaTerminu
            // 
            this.daneKlienta_zmianaTerminu.Controls.Add(this.nazwisko_zmianaTerminu);
            this.daneKlienta_zmianaTerminu.Controls.Add(this.Imie_zmianaTerminu);
            this.daneKlienta_zmianaTerminu.Location = new System.Drawing.Point(35, 88);
            this.daneKlienta_zmianaTerminu.Name = "daneKlienta_zmianaTerminu";
            this.daneKlienta_zmianaTerminu.Size = new System.Drawing.Size(724, 129);
            this.daneKlienta_zmianaTerminu.TabIndex = 3;
            this.daneKlienta_zmianaTerminu.TabStop = false;
            this.daneKlienta_zmianaTerminu.Text = "Dane klienta";
            // 
            // nazwisko_zmianaTerminu
            // 
            this.nazwisko_zmianaTerminu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwisko_zmianaTerminu.Location = new System.Drawing.Point(29, 72);
            this.nazwisko_zmianaTerminu.Name = "nazwisko_zmianaTerminu";
            this.nazwisko_zmianaTerminu.Size = new System.Drawing.Size(293, 28);
            this.nazwisko_zmianaTerminu.TabIndex = 2;
            this.nazwisko_zmianaTerminu.Tag = "";
            this.nazwisko_zmianaTerminu.Text = "Nazwisko";
            // 
            // Imie_zmianaTerminu
            // 
            this.Imie_zmianaTerminu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Imie_zmianaTerminu.Location = new System.Drawing.Point(29, 19);
            this.Imie_zmianaTerminu.Name = "Imie_zmianaTerminu";
            this.Imie_zmianaTerminu.Size = new System.Drawing.Size(293, 28);
            this.Imie_zmianaTerminu.TabIndex = 1;
            this.Imie_zmianaTerminu.Tag = "";
            this.Imie_zmianaTerminu.Text = "Imię";
            // 
            // ZmianaTerminu_data
            // 
            this.ZmianaTerminu_data.Controls.Add(this.nowaData_ZmianaTerminu);
            this.ZmianaTerminu_data.Controls.Add(this.staraData_ZmianaTerminu);
            this.ZmianaTerminu_data.Location = new System.Drawing.Point(385, 223);
            this.ZmianaTerminu_data.Name = "ZmianaTerminu_data";
            this.ZmianaTerminu_data.Size = new System.Drawing.Size(374, 129);
            this.ZmianaTerminu_data.TabIndex = 4;
            this.ZmianaTerminu_data.TabStop = false;
            this.ZmianaTerminu_data.Text = "Zmiana terminu";
            // 
            // nowaData_ZmianaTerminu
            // 
            this.nowaData_ZmianaTerminu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nowaData_ZmianaTerminu.Location = new System.Drawing.Point(29, 72);
            this.nowaData_ZmianaTerminu.Name = "nowaData_ZmianaTerminu";
            this.nowaData_ZmianaTerminu.Size = new System.Drawing.Size(293, 28);
            this.nowaData_ZmianaTerminu.TabIndex = 2;
            this.nowaData_ZmianaTerminu.Tag = "";
            this.nowaData_ZmianaTerminu.Text = "Nowa data";
            // 
            // staraData_ZmianaTerminu
            // 
            this.staraData_ZmianaTerminu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.staraData_ZmianaTerminu.Location = new System.Drawing.Point(29, 19);
            this.staraData_ZmianaTerminu.Name = "staraData_ZmianaTerminu";
            this.staraData_ZmianaTerminu.Size = new System.Drawing.Size(293, 28);
            this.staraData_ZmianaTerminu.TabIndex = 1;
            this.staraData_ZmianaTerminu.Tag = "";
            this.staraData_ZmianaTerminu.Text = "Poprzednia data";
            // 
            // Zatwierdź
            // 
            this.Zatwierdź.Location = new System.Drawing.Point(619, 395);
            this.Zatwierdź.Name = "Zatwierdź";
            this.Zatwierdź.Size = new System.Drawing.Size(140, 43);
            this.Zatwierdź.TabIndex = 5;
            this.Zatwierdź.Text = "Zatwierdź";
            this.Zatwierdź.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Zatwierdź.UseVisualStyleBackColor = true;
            this.Zatwierdź.Click += new System.EventHandler(this.Zatwierdź_Click);
            // 
            // NumerBiletu_GroupBox
            // 
            this.NumerBiletu_GroupBox.Controls.Add(this.NumerBiletu_TextBox);
            this.NumerBiletu_GroupBox.Location = new System.Drawing.Point(35, 223);
            this.NumerBiletu_GroupBox.Name = "NumerBiletu_GroupBox";
            this.NumerBiletu_GroupBox.Size = new System.Drawing.Size(344, 129);
            this.NumerBiletu_GroupBox.TabIndex = 5;
            this.NumerBiletu_GroupBox.TabStop = false;
            this.NumerBiletu_GroupBox.Text = "Numer biletu";
            // 
            // NumerBiletu_TextBox
            // 
            this.NumerBiletu_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumerBiletu_TextBox.Location = new System.Drawing.Point(29, 19);
            this.NumerBiletu_TextBox.Name = "NumerBiletu_TextBox";
            this.NumerBiletu_TextBox.Size = new System.Drawing.Size(293, 28);
            this.NumerBiletu_TextBox.TabIndex = 1;
            this.NumerBiletu_TextBox.Tag = "";
            this.NumerBiletu_TextBox.Text = "Numer biletu";
            // 
            // KierownikZmiany_zmienTerminPrzejazdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumerBiletu_GroupBox);
            this.Controls.Add(this.Zatwierdź);
            this.Controls.Add(this.ZmianaTerminu_data);
            this.Controls.Add(this.daneKlienta_zmianaTerminu);
            this.Controls.Add(this.Powitanie_zmianaTerminuPrzejazdu);
            this.Name = "KierownikZmiany_zmienTerminPrzejazdu";
            this.Text = "KierownikZmiany_zmienTerminPrzejazdu";
            this.daneKlienta_zmianaTerminu.ResumeLayout(false);
            this.daneKlienta_zmianaTerminu.PerformLayout();
            this.ZmianaTerminu_data.ResumeLayout(false);
            this.ZmianaTerminu_data.PerformLayout();
            this.NumerBiletu_GroupBox.ResumeLayout(false);
            this.NumerBiletu_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Powitanie_zmianaTerminuPrzejazdu;
        private System.Windows.Forms.GroupBox daneKlienta_zmianaTerminu;
        private System.Windows.Forms.TextBox nazwisko_zmianaTerminu;
        private System.Windows.Forms.TextBox Imie_zmianaTerminu;
        private System.Windows.Forms.GroupBox ZmianaTerminu_data;
        private System.Windows.Forms.TextBox nowaData_ZmianaTerminu;
        private System.Windows.Forms.TextBox staraData_ZmianaTerminu;
        private System.Windows.Forms.Button Zatwierdź;
        private System.Windows.Forms.GroupBox NumerBiletu_GroupBox;
        private System.Windows.Forms.TextBox NumerBiletu_TextBox;
    }
}