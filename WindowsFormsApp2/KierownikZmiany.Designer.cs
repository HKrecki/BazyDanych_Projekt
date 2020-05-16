namespace WindowsFormsApp2
{
    partial class KierownikZmiany
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
            this.Powitanie_kierownikZmiany = new System.Windows.Forms.Label();
            this.Przycisk_anulujBilet = new System.Windows.Forms.Button();
            this.Przycisk_zmienTerminPrzejazdu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Powitanie_kierownikZmiany
            // 
            this.Powitanie_kierownikZmiany.AutoSize = true;
            this.Powitanie_kierownikZmiany.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Powitanie_kierownikZmiany.Location = new System.Drawing.Point(220, 69);
            this.Powitanie_kierownikZmiany.Name = "Powitanie_kierownikZmiany";
            this.Powitanie_kierownikZmiany.Size = new System.Drawing.Size(346, 24);
            this.Powitanie_kierownikZmiany.TabIndex = 1;
            this.Powitanie_kierownikZmiany.Text = "Witaj na pulpicie kierownika zmiany!";
            this.Powitanie_kierownikZmiany.Click += new System.EventHandler(this.Powitanie_admin_Click);
            // 
            // Przycisk_anulujBilet
            // 
            this.Przycisk_anulujBilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Przycisk_anulujBilet.Location = new System.Drawing.Point(120, 215);
            this.Przycisk_anulujBilet.Name = "Przycisk_anulujBilet";
            this.Przycisk_anulujBilet.Size = new System.Drawing.Size(228, 52);
            this.Przycisk_anulujBilet.TabIndex = 2;
            this.Przycisk_anulujBilet.Text = "Anuluj bilet";
            this.Przycisk_anulujBilet.UseVisualStyleBackColor = true;
            this.Przycisk_anulujBilet.Click += new System.EventHandler(this.Przycisk_anulujBilet_Click);
            // 
            // Przycisk_zmienTerminPrzejazdu
            // 
            this.Przycisk_zmienTerminPrzejazdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Przycisk_zmienTerminPrzejazdu.Location = new System.Drawing.Point(433, 214);
            this.Przycisk_zmienTerminPrzejazdu.Name = "Przycisk_zmienTerminPrzejazdu";
            this.Przycisk_zmienTerminPrzejazdu.Size = new System.Drawing.Size(228, 53);
            this.Przycisk_zmienTerminPrzejazdu.TabIndex = 3;
            this.Przycisk_zmienTerminPrzejazdu.Text = "Zmień termin przejazdu";
            this.Przycisk_zmienTerminPrzejazdu.UseVisualStyleBackColor = true;
            this.Przycisk_zmienTerminPrzejazdu.Click += new System.EventHandler(this.Przycisk_zmienTerminPrzejazdu_Click);
            // 
            // KierownikZmiany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Przycisk_zmienTerminPrzejazdu);
            this.Controls.Add(this.Przycisk_anulujBilet);
            this.Controls.Add(this.Powitanie_kierownikZmiany);
            this.Name = "KierownikZmiany";
            this.Text = "Kierownik_zmiany";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Powitanie_kierownikZmiany;
        private System.Windows.Forms.Button Przycisk_anulujBilet;
        private System.Windows.Forms.Button Przycisk_zmienTerminPrzejazdu;
    }
}