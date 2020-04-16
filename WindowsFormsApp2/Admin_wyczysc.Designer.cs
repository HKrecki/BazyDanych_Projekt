namespace WindowsFormsApp2
{
    partial class Admin_wyczysc
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
            this.wyczysc_OK = new System.Windows.Forms.Button();
            this.Powitanie_wyczysc = new System.Windows.Forms.Label();
            this.wyczysc_text1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // wyczysc_OK
            // 
            this.wyczysc_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyczysc_OK.Location = new System.Drawing.Point(603, 350);
            this.wyczysc_OK.Name = "wyczysc_OK";
            this.wyczysc_OK.Size = new System.Drawing.Size(153, 55);
            this.wyczysc_OK.TabIndex = 0;
            this.wyczysc_OK.Text = "Wyczysc!";
            this.wyczysc_OK.UseVisualStyleBackColor = true;
            this.wyczysc_OK.Click += new System.EventHandler(this.wyczysc_OK_Click);
            // 
            // Powitanie_wyczysc
            // 
            this.Powitanie_wyczysc.AutoSize = true;
            this.Powitanie_wyczysc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Powitanie_wyczysc.Location = new System.Drawing.Point(125, 37);
            this.Powitanie_wyczysc.Name = "Powitanie_wyczysc";
            this.Powitanie_wyczysc.Size = new System.Drawing.Size(586, 25);
            this.Powitanie_wyczysc.TabIndex = 2;
            this.Powitanie_wyczysc.Text = "Wpisz liczbe dni. Starsze polaczenia zostana usuniete";
            // 
            // wyczysc_text1
            // 
            this.wyczysc_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyczysc_text1.Location = new System.Drawing.Point(301, 98);
            this.wyczysc_text1.Name = "wyczysc_text1";
            this.wyczysc_text1.Size = new System.Drawing.Size(171, 28);
            this.wyczysc_text1.TabIndex = 3;
            this.wyczysc_text1.Text = "Ilosc dni";
            // 
            // Admin_wyczysc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wyczysc_text1);
            this.Controls.Add(this.Powitanie_wyczysc);
            this.Controls.Add(this.wyczysc_OK);
            this.Name = "Admin_wyczysc";
            this.Text = "Admin_wyczysc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wyczysc_OK;
        private System.Windows.Forms.MonthCalendar wyczysc_data;
        private System.Windows.Forms.Label Powitanie_wyczysc;
        private System.Windows.Forms.TextBox wyczysc_text1;
    }
}