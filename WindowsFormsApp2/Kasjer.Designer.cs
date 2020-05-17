namespace WindowsFormsApp2
{
    partial class Kasjer
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
            this.Powitanie_kasjer = new System.Windows.Forms.Label();
            this.Przycisk_kasjer_sprawdzDostepnosc = new System.Windows.Forms.Button();
            this.Przycisk_Kasjer_kupBilet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Powitanie_kasjer
            // 
            this.Powitanie_kasjer.AutoSize = true;
            this.Powitanie_kasjer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Powitanie_kasjer.Location = new System.Drawing.Point(272, 81);
            this.Powitanie_kasjer.Name = "Powitanie_kasjer";
            this.Powitanie_kasjer.Size = new System.Drawing.Size(242, 24);
            this.Powitanie_kasjer.TabIndex = 2;
            this.Powitanie_kasjer.Text = "Witaj na pulpicie kasjera!";
            // 
            // Przycisk_kasjer_sprawdzDostepnosc
            // 
            this.Przycisk_kasjer_sprawdzDostepnosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Przycisk_kasjer_sprawdzDostepnosc.Location = new System.Drawing.Point(138, 231);
            this.Przycisk_kasjer_sprawdzDostepnosc.Name = "Przycisk_kasjer_sprawdzDostepnosc";
            this.Przycisk_kasjer_sprawdzDostepnosc.Size = new System.Drawing.Size(228, 52);
            this.Przycisk_kasjer_sprawdzDostepnosc.TabIndex = 3;
            this.Przycisk_kasjer_sprawdzDostepnosc.Text = "Sprawdź dostępność";
            this.Przycisk_kasjer_sprawdzDostepnosc.UseVisualStyleBackColor = true;
            this.Przycisk_kasjer_sprawdzDostepnosc.Click += new System.EventHandler(this.Przycisk_kasjer_sprawdzDostepnosc_Click);
            // 
            // Przycisk_Kasjer_kupBilet
            // 
            this.Przycisk_Kasjer_kupBilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Przycisk_Kasjer_kupBilet.Location = new System.Drawing.Point(397, 231);
            this.Przycisk_Kasjer_kupBilet.Name = "Przycisk_Kasjer_kupBilet";
            this.Przycisk_Kasjer_kupBilet.Size = new System.Drawing.Size(228, 52);
            this.Przycisk_Kasjer_kupBilet.TabIndex = 4;
            this.Przycisk_Kasjer_kupBilet.Text = "Kup bilet";
            this.Przycisk_Kasjer_kupBilet.UseVisualStyleBackColor = true;
            // 
            // Kasjer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Przycisk_Kasjer_kupBilet);
            this.Controls.Add(this.Przycisk_kasjer_sprawdzDostepnosc);
            this.Controls.Add(this.Powitanie_kasjer);
            this.Name = "Kasjer";
            this.Text = "Kasjer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Powitanie_kasjer;
        private System.Windows.Forms.Button Przycisk_kasjer_sprawdzDostepnosc;
        private System.Windows.Forms.Button Przycisk_Kasjer_kupBilet;
    }
}