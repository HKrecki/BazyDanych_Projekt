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
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(288, 155);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 20);
            this.Login.TabIndex = 0;
            this.Login.Tag = "";
            this.Login.Text = "Login";
            // 
            // Haslo
            // 
            this.Haslo.Location = new System.Drawing.Point(288, 224);
            this.Haslo.Name = "Haslo";
            this.Haslo.Size = new System.Drawing.Size(100, 20);
            this.Haslo.TabIndex = 1;
            this.Haslo.Text = "Haslo";
            this.Haslo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(302, 300);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
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
            this.Log_kom.Size = new System.Drawing.Size(0, 29);
            this.Log_kom.TabIndex = 3;
            this.Log_kom.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(697, 425);
            this.Controls.Add(this.Log_kom);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Haslo);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Haslo;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label Log_kom;
    }
}

