namespace WindowsFormsApp2
{
    partial class Logowanie
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login = new System.Windows.Forms.TextBox();
            this.Haslo = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Log_kom = new System.Windows.Forms.Label();
            this.Powitanie_logowanie = new System.Windows.Forms.Label();
            this.Powitanie_logowanie2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login.Location = new System.Drawing.Point(271, 148);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(140, 28);
            this.Login.TabIndex = 0;
            this.Login.Tag = "";
            this.Login.Text = "Login";
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // Haslo
            // 
            this.Haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Haslo.Location = new System.Drawing.Point(271, 217);
            this.Haslo.Name = "Haslo";
            this.Haslo.Size = new System.Drawing.Size(140, 28);
            this.Haslo.TabIndex = 1;
            this.Haslo.Text = "Haslo";
            this.Haslo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(271, 289);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(140, 43);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Log_kom
            // 
            this.Log_kom.AutoSize = true;
            this.Log_kom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Log_kom.Location = new System.Drawing.Point(191, 363);
            this.Log_kom.Name = "Log_kom";
            this.Log_kom.Size = new System.Drawing.Size(0, 25);
            this.Log_kom.TabIndex = 3;
            this.Log_kom.Click += new System.EventHandler(this.label1_Click);
            // 
            // Powitanie_logowanie
            // 
            this.Powitanie_logowanie.AutoSize = true;
            this.Powitanie_logowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Powitanie_logowanie.Location = new System.Drawing.Point(253, 27);
            this.Powitanie_logowanie.Name = "Powitanie_logowanie";
            this.Powitanie_logowanie.Size = new System.Drawing.Size(163, 24);
            this.Powitanie_logowanie.TabIndex = 4;
            this.Powitanie_logowanie.Text = "Witaj w aplikacji!";
            // 
            // Powitanie_logowanie2
            // 
            this.Powitanie_logowanie2.AutoSize = true;
            this.Powitanie_logowanie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Powitanie_logowanie2.Location = new System.Drawing.Point(138, 81);
            this.Powitanie_logowanie2.Name = "Powitanie_logowanie2";
            this.Powitanie_logowanie2.Size = new System.Drawing.Size(365, 20);
            this.Powitanie_logowanie2.TabIndex = 5;
            this.Powitanie_logowanie2.Text = "Aby przejsc do swojego ekranu wpisz Login i Haslo";
            // 
            // Logowanie
            // 
            this.ClientSize = new System.Drawing.Size(697, 425);
            this.Controls.Add(this.Powitanie_logowanie2);
            this.Controls.Add(this.Powitanie_logowanie);
            this.Controls.Add(this.Log_kom);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Haslo);
            this.Controls.Add(this.Login);
            this.Name = "Logowanie";
            this.Load += new System.EventHandler(this.Logowanie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Haslo;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label Log_kom;
        private System.Windows.Forms.Label Powitanie_logowanie;
        private System.Windows.Forms.Label Powitanie_logowanie2;
    }
}

