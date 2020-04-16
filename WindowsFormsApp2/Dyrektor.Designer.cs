namespace WindowsFormsApp2
{
    partial class Dyrektor
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
            this.Combo_dyrektor = new System.Windows.Forms.ComboBox();
            this.Dyrektor_OK = new System.Windows.Forms.Button();
            this.Dyrektor_text1 = new System.Windows.Forms.TextBox();
            this.Dyrektor_text2 = new System.Windows.Forms.TextBox();
            this.Powitanie_dyrektor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Combo_dyrektor
            // 
            this.Combo_dyrektor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Combo_dyrektor.FormattingEnabled = true;
            this.Combo_dyrektor.Items.AddRange(new object[] {
            "Zmien wynagrodzenie",
            "Przyznaj premie"});
            this.Combo_dyrektor.Location = new System.Drawing.Point(58, 191);
            this.Combo_dyrektor.Name = "Combo_dyrektor";
            this.Combo_dyrektor.Size = new System.Drawing.Size(152, 33);
            this.Combo_dyrektor.TabIndex = 0;
            this.Combo_dyrektor.Text = "Akcja";
            this.Combo_dyrektor.SelectedIndexChanged += new System.EventHandler(this.Combo_dyrektor_SelectedIndexChanged);
            // 
            // Dyrektor_OK
            // 
            this.Dyrektor_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dyrektor_OK.Location = new System.Drawing.Point(589, 361);
            this.Dyrektor_OK.Name = "Dyrektor_OK";
            this.Dyrektor_OK.Size = new System.Drawing.Size(158, 49);
            this.Dyrektor_OK.TabIndex = 1;
            this.Dyrektor_OK.Text = "Zatwierdz";
            this.Dyrektor_OK.UseVisualStyleBackColor = true;
            this.Dyrektor_OK.Click += new System.EventHandler(this.Akcja_dyrektora);
            // 
            // Dyrektor_text1
            // 
            this.Dyrektor_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dyrektor_text1.Location = new System.Drawing.Point(323, 154);
            this.Dyrektor_text1.Name = "Dyrektor_text1";
            this.Dyrektor_text1.Size = new System.Drawing.Size(140, 31);
            this.Dyrektor_text1.TabIndex = 2;
            // 
            // Dyrektor_text2
            // 
            this.Dyrektor_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dyrektor_text2.Location = new System.Drawing.Point(323, 239);
            this.Dyrektor_text2.Name = "Dyrektor_text2";
            this.Dyrektor_text2.Size = new System.Drawing.Size(140, 31);
            this.Dyrektor_text2.TabIndex = 3;
            // 
            // Powitanie_dyrektor
            // 
            this.Powitanie_dyrektor.AutoSize = true;
            this.Powitanie_dyrektor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Powitanie_dyrektor.Location = new System.Drawing.Point(244, 30);
            this.Powitanie_dyrektor.Name = "Powitanie_dyrektor";
            this.Powitanie_dyrektor.Size = new System.Drawing.Size(300, 25);
            this.Powitanie_dyrektor.TabIndex = 4;
            this.Powitanie_dyrektor.Text = "Witaj na pulpicie dyrektora!";
            // 
            // Dyrektor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Powitanie_dyrektor);
            this.Controls.Add(this.Dyrektor_text2);
            this.Controls.Add(this.Dyrektor_text1);
            this.Controls.Add(this.Dyrektor_OK);
            this.Controls.Add(this.Combo_dyrektor);
            this.Name = "Dyrektor";
            this.Text = "Dyrektor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Combo_dyrektor;
        private System.Windows.Forms.Button Dyrektor_OK;
        private System.Windows.Forms.TextBox Dyrektor_text1;
        private System.Windows.Forms.TextBox Dyrektor_text2;
        private System.Windows.Forms.Label Powitanie_dyrektor;
    }
}