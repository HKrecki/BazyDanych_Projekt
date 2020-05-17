namespace WindowsFormsApp2
{
    partial class Kasjer_sprawdzDostepnosc
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
            this.Kasjer_SprawdzDostepnosc_Zatwierdz_pushButton = new System.Windows.Forms.Button();
            this.ilosc_miejsc = new System.Windows.Forms.Label();
            this.Kasjer_sprawdzDostepnosc_powitanie = new System.Windows.Forms.Label();
            this.Kasjer_SprawdzDostepnosc_StacjaOdjazdu_textBox = new System.Windows.Forms.TextBox();
            this.Kasjer_SprawdzDostepnosc_StacjaPrzyjazdu_textBox = new System.Windows.Forms.TextBox();
            this.Kasjer_SprawdzDostepnosc_data_textBox = new System.Windows.Forms.TextBox();
            this.Kasjer_SprawdzDostepnosc_DanePolaczenia_box = new System.Windows.Forms.GroupBox();
            this.Log_kom = new System.Windows.Forms.Label();
            this.Kasjer_SprawdzDostepnosc_DanePolaczenia_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Kasjer_SprawdzDostepnosc_Zatwierdz_pushButton
            // 
            this.Kasjer_SprawdzDostepnosc_Zatwierdz_pushButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kasjer_SprawdzDostepnosc_Zatwierdz_pushButton.Location = new System.Drawing.Point(533, 274);
            this.Kasjer_SprawdzDostepnosc_Zatwierdz_pushButton.Name = "Kasjer_SprawdzDostepnosc_Zatwierdz_pushButton";
            this.Kasjer_SprawdzDostepnosc_Zatwierdz_pushButton.Size = new System.Drawing.Size(228, 52);
            this.Kasjer_SprawdzDostepnosc_Zatwierdz_pushButton.TabIndex = 5;
            this.Kasjer_SprawdzDostepnosc_Zatwierdz_pushButton.Text = "Zatwierdź";
            this.Kasjer_SprawdzDostepnosc_Zatwierdz_pushButton.UseVisualStyleBackColor = true;
            this.Kasjer_SprawdzDostepnosc_Zatwierdz_pushButton.Click += new System.EventHandler(this.Kasjer_SprawdzDostepnosc_Zatwierdz_pushButton_Click);
            // 
            // ilosc_miejsc
            // 
            this.ilosc_miejsc.AutoSize = true;
            this.ilosc_miejsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ilosc_miejsc.Location = new System.Drawing.Point(32, 287);
            this.ilosc_miejsc.Name = "ilosc_miejsc";
            this.ilosc_miejsc.Size = new System.Drawing.Size(17, 25);
            this.ilosc_miejsc.TabIndex = 7;
            this.ilosc_miejsc.Text = " ";
            // 
            // Kasjer_sprawdzDostepnosc_powitanie
            // 
            this.Kasjer_sprawdzDostepnosc_powitanie.AutoSize = true;
            this.Kasjer_sprawdzDostepnosc_powitanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kasjer_sprawdzDostepnosc_powitanie.Location = new System.Drawing.Point(264, 88);
            this.Kasjer_sprawdzDostepnosc_powitanie.Name = "Kasjer_sprawdzDostepnosc_powitanie";
            this.Kasjer_sprawdzDostepnosc_powitanie.Size = new System.Drawing.Size(250, 24);
            this.Kasjer_sprawdzDostepnosc_powitanie.TabIndex = 3;
            this.Kasjer_sprawdzDostepnosc_powitanie.Text = "Sprawdzenie dostępności";
            // 
            // Kasjer_SprawdzDostepnosc_StacjaOdjazdu_textBox
            // 
            this.Kasjer_SprawdzDostepnosc_StacjaOdjazdu_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kasjer_SprawdzDostepnosc_StacjaOdjazdu_textBox.Location = new System.Drawing.Point(29, 19);
            this.Kasjer_SprawdzDostepnosc_StacjaOdjazdu_textBox.Name = "Kasjer_SprawdzDostepnosc_StacjaOdjazdu_textBox";
            this.Kasjer_SprawdzDostepnosc_StacjaOdjazdu_textBox.Size = new System.Drawing.Size(293, 28);
            this.Kasjer_SprawdzDostepnosc_StacjaOdjazdu_textBox.TabIndex = 1;
            this.Kasjer_SprawdzDostepnosc_StacjaOdjazdu_textBox.Tag = "";
            this.Kasjer_SprawdzDostepnosc_StacjaOdjazdu_textBox.Text = "Stacja odjazdu";
            // 
            // Kasjer_SprawdzDostepnosc_StacjaPrzyjazdu_textBox
            // 
            this.Kasjer_SprawdzDostepnosc_StacjaPrzyjazdu_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kasjer_SprawdzDostepnosc_StacjaPrzyjazdu_textBox.Location = new System.Drawing.Point(29, 72);
            this.Kasjer_SprawdzDostepnosc_StacjaPrzyjazdu_textBox.Name = "Kasjer_SprawdzDostepnosc_StacjaPrzyjazdu_textBox";
            this.Kasjer_SprawdzDostepnosc_StacjaPrzyjazdu_textBox.Size = new System.Drawing.Size(293, 28);
            this.Kasjer_SprawdzDostepnosc_StacjaPrzyjazdu_textBox.TabIndex = 2;
            this.Kasjer_SprawdzDostepnosc_StacjaPrzyjazdu_textBox.Tag = "";
            this.Kasjer_SprawdzDostepnosc_StacjaPrzyjazdu_textBox.Text = "Stacja przyjazdu";
            // 
            // Kasjer_SprawdzDostepnosc_data_textBox
            // 
            this.Kasjer_SprawdzDostepnosc_data_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kasjer_SprawdzDostepnosc_data_textBox.Location = new System.Drawing.Point(396, 19);
            this.Kasjer_SprawdzDostepnosc_data_textBox.Name = "Kasjer_SprawdzDostepnosc_data_textBox";
            this.Kasjer_SprawdzDostepnosc_data_textBox.Size = new System.Drawing.Size(293, 28);
            this.Kasjer_SprawdzDostepnosc_data_textBox.TabIndex = 3;
            this.Kasjer_SprawdzDostepnosc_data_textBox.Tag = "";
            this.Kasjer_SprawdzDostepnosc_data_textBox.Text = "Data";
            this.Kasjer_SprawdzDostepnosc_data_textBox.TextChanged += new System.EventHandler(this.Kasjer_SprawdzDostepnosc_data_textBox_TextChanged);
            // 
            // Kasjer_SprawdzDostepnosc_DanePolaczenia_box
            // 
            this.Kasjer_SprawdzDostepnosc_DanePolaczenia_box.Controls.Add(this.Kasjer_SprawdzDostepnosc_data_textBox);
            this.Kasjer_SprawdzDostepnosc_DanePolaczenia_box.Controls.Add(this.Kasjer_SprawdzDostepnosc_StacjaPrzyjazdu_textBox);
            this.Kasjer_SprawdzDostepnosc_DanePolaczenia_box.Controls.Add(this.Kasjer_SprawdzDostepnosc_StacjaOdjazdu_textBox);
            this.Kasjer_SprawdzDostepnosc_DanePolaczenia_box.Location = new System.Drawing.Point(37, 140);
            this.Kasjer_SprawdzDostepnosc_DanePolaczenia_box.Name = "Kasjer_SprawdzDostepnosc_DanePolaczenia_box";
            this.Kasjer_SprawdzDostepnosc_DanePolaczenia_box.Size = new System.Drawing.Size(724, 118);
            this.Kasjer_SprawdzDostepnosc_DanePolaczenia_box.TabIndex = 4;
            this.Kasjer_SprawdzDostepnosc_DanePolaczenia_box.TabStop = false;
            this.Kasjer_SprawdzDostepnosc_DanePolaczenia_box.Text = "Dane połączenia";
            this.Kasjer_SprawdzDostepnosc_DanePolaczenia_box.Enter += new System.EventHandler(this.Kasjer_SprawdzDostepnosc_DanePolaczenia_box_Enter);
            // 
            // Log_kom
            // 
            this.Log_kom.AutoSize = true;
            this.Log_kom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Log_kom.Location = new System.Drawing.Point(400, 213);
            this.Log_kom.Name = "Log_kom";
            this.Log_kom.Size = new System.Drawing.Size(0, 25);
            this.Log_kom.TabIndex = 6;
            // 
            // Kasjer_sprawdzDostepnosc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ilosc_miejsc);
            this.Controls.Add(this.Log_kom);
            this.Controls.Add(this.Kasjer_SprawdzDostepnosc_Zatwierdz_pushButton);
            this.Controls.Add(this.Kasjer_SprawdzDostepnosc_DanePolaczenia_box);
            this.Controls.Add(this.Kasjer_sprawdzDostepnosc_powitanie);
            this.Name = "Kasjer_sprawdzDostepnosc";
            this.Text = "Kasjer_sprawdzDostepnosc";
            this.Kasjer_SprawdzDostepnosc_DanePolaczenia_box.ResumeLayout(false);
            this.Kasjer_SprawdzDostepnosc_DanePolaczenia_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Kasjer_SprawdzDostepnosc_Zatwierdz_pushButton;
        private System.Windows.Forms.Label ilosc_miejsc;
        private System.Windows.Forms.Label Kasjer_sprawdzDostepnosc_powitanie;
        private System.Windows.Forms.TextBox Kasjer_SprawdzDostepnosc_StacjaOdjazdu_textBox;
        private System.Windows.Forms.TextBox Kasjer_SprawdzDostepnosc_StacjaPrzyjazdu_textBox;
        private System.Windows.Forms.TextBox Kasjer_SprawdzDostepnosc_data_textBox;
        private System.Windows.Forms.GroupBox Kasjer_SprawdzDostepnosc_DanePolaczenia_box;
        private System.Windows.Forms.Label Log_kom;
    }
}