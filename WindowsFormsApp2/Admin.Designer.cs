namespace WindowsFormsApp2
{
    partial class Admin
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
            this.Powitanie_admin = new System.Windows.Forms.Label();
            this.Przycisk_kadry = new System.Windows.Forms.Button();
            this.Przycisk_pociagi = new System.Windows.Forms.Button();
            this.Przycisk_wyczysc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Powitanie_admin
            // 
            this.Powitanie_admin.AutoSize = true;
            this.Powitanie_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Powitanie_admin.Location = new System.Drawing.Point(257, 76);
            this.Powitanie_admin.Name = "Powitanie_admin";
            this.Powitanie_admin.Size = new System.Drawing.Size(244, 24);
            this.Powitanie_admin.TabIndex = 0;
            this.Powitanie_admin.Text = "Witaj na pulpicie admina!";
            this.Powitanie_admin.Click += new System.EventHandler(this.label1_Click);
            // 
            // Przycisk_kadry
            // 
            this.Przycisk_kadry.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Przycisk_kadry.Location = new System.Drawing.Point(94, 243);
            this.Przycisk_kadry.Name = "Przycisk_kadry";
            this.Przycisk_kadry.Size = new System.Drawing.Size(124, 52);
            this.Przycisk_kadry.TabIndex = 1;
            this.Przycisk_kadry.Text = "Kadry";
            this.Przycisk_kadry.UseVisualStyleBackColor = true;
            this.Przycisk_kadry.Click += new System.EventHandler(this.Przycisk_kadry_Click);
            // 
            // Przycisk_pociagi
            // 
            this.Przycisk_pociagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Przycisk_pociagi.Location = new System.Drawing.Point(320, 242);
            this.Przycisk_pociagi.Name = "Przycisk_pociagi";
            this.Przycisk_pociagi.Size = new System.Drawing.Size(125, 53);
            this.Przycisk_pociagi.TabIndex = 2;
            this.Przycisk_pociagi.Text = "Pociagi";
            this.Przycisk_pociagi.UseVisualStyleBackColor = true;
            this.Przycisk_pociagi.Click += new System.EventHandler(this.Przycisk_pociagi_Click);
            // 
            // Przycisk_wyczysc
            // 
            this.Przycisk_wyczysc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Przycisk_wyczysc.Location = new System.Drawing.Point(557, 243);
            this.Przycisk_wyczysc.Name = "Przycisk_wyczysc";
            this.Przycisk_wyczysc.Size = new System.Drawing.Size(128, 53);
            this.Przycisk_wyczysc.TabIndex = 3;
            this.Przycisk_wyczysc.Text = "Wyczysc";
            this.Przycisk_wyczysc.UseVisualStyleBackColor = true;
            this.Przycisk_wyczysc.Click += new System.EventHandler(this.Przycisk_wyczysc_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Przycisk_wyczysc);
            this.Controls.Add(this.Przycisk_pociagi);
            this.Controls.Add(this.Przycisk_kadry);
            this.Controls.Add(this.Powitanie_admin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Powitanie_admin;
        private System.Windows.Forms.Button Przycisk_kadry;
        private System.Windows.Forms.Button Przycisk_pociagi;
        private System.Windows.Forms.Button Przycisk_wyczysc;
    }
}