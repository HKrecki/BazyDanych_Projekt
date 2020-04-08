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
            this.label1 = new System.Windows.Forms.Label();
            this.Admin_OK = new System.Windows.Forms.Button();
            this.Lista_akcji = new System.Windows.Forms.ComboBox();
            this.Admin_text1 = new System.Windows.Forms.TextBox();
            this.Admin_text2 = new System.Windows.Forms.TextBox();
            this.Admin_text3 = new System.Windows.Forms.TextBox();
            this.Admin_text7 = new System.Windows.Forms.TextBox();
            this.Admin_text6 = new System.Windows.Forms.TextBox();
            this.Admin_text4 = new System.Windows.Forms.TextBox();
            this.Admin_text8 = new System.Windows.Forms.TextBox();
            this.Admin_text9 = new System.Windows.Forms.TextBox();
            this.Admin_text5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(279, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "To jest ekran admina";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Admin_OK
            // 
            this.Admin_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Admin_OK.Location = new System.Drawing.Point(594, 340);
            this.Admin_OK.Name = "Admin_OK";
            this.Admin_OK.Size = new System.Drawing.Size(147, 60);
            this.Admin_OK.TabIndex = 1;
            this.Admin_OK.Text = "Zatwierdz";
            this.Admin_OK.UseVisualStyleBackColor = true;
            this.Admin_OK.Click += new System.EventHandler(this.Dodaj_pracownika);
            // 
            // Lista_akcji
            // 
            this.Lista_akcji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lista_akcji.FormattingEnabled = true;
            this.Lista_akcji.Items.AddRange(new object[] {
            "Dodaj pracownika",
            "Usuń pracownika"});
            this.Lista_akcji.Location = new System.Drawing.Point(63, 102);
            this.Lista_akcji.Name = "Lista_akcji";
            this.Lista_akcji.Size = new System.Drawing.Size(157, 26);
            this.Lista_akcji.TabIndex = 2;
            this.Lista_akcji.SelectedIndexChanged += new System.EventHandler(this.Lista_akcji_SelectedIndexChanged);
            // 
            // Admin_text1
            // 
            this.Admin_text1.Location = new System.Drawing.Point(324, 75);
            this.Admin_text1.Name = "Admin_text1";
            this.Admin_text1.Size = new System.Drawing.Size(100, 20);
            this.Admin_text1.TabIndex = 3;
            // 
            // Admin_text2
            // 
            this.Admin_text2.Location = new System.Drawing.Point(324, 118);
            this.Admin_text2.Name = "Admin_text2";
            this.Admin_text2.Size = new System.Drawing.Size(100, 20);
            this.Admin_text2.TabIndex = 4;
            // 
            // Admin_text3
            // 
            this.Admin_text3.Location = new System.Drawing.Point(324, 158);
            this.Admin_text3.Name = "Admin_text3";
            this.Admin_text3.Size = new System.Drawing.Size(100, 20);
            this.Admin_text3.TabIndex = 5;
            // 
            // Admin_text7
            // 
            this.Admin_text7.Location = new System.Drawing.Point(324, 315);
            this.Admin_text7.Name = "Admin_text7";
            this.Admin_text7.Size = new System.Drawing.Size(100, 20);
            this.Admin_text7.TabIndex = 8;
            // 
            // Admin_text6
            // 
            this.Admin_text6.Location = new System.Drawing.Point(324, 274);
            this.Admin_text6.Name = "Admin_text6";
            this.Admin_text6.Size = new System.Drawing.Size(100, 20);
            this.Admin_text6.TabIndex = 7;
            // 
            // Admin_text4
            // 
            this.Admin_text4.Location = new System.Drawing.Point(324, 196);
            this.Admin_text4.Name = "Admin_text4";
            this.Admin_text4.Size = new System.Drawing.Size(100, 20);
            this.Admin_text4.TabIndex = 6;
            // 
            // Admin_text8
            // 
            this.Admin_text8.Location = new System.Drawing.Point(324, 362);
            this.Admin_text8.Name = "Admin_text8";
            this.Admin_text8.Size = new System.Drawing.Size(100, 20);
            this.Admin_text8.TabIndex = 9;
            // 
            // Admin_text9
            // 
            this.Admin_text9.Location = new System.Drawing.Point(324, 404);
            this.Admin_text9.Name = "Admin_text9";
            this.Admin_text9.Size = new System.Drawing.Size(100, 20);
            this.Admin_text9.TabIndex = 10;
            this.Admin_text9.TextChanged += new System.EventHandler(this.Admin_text8_TextChanged);
            // 
            // Admin_text5
            // 
            this.Admin_text5.Location = new System.Drawing.Point(324, 237);
            this.Admin_text5.Name = "Admin_text5";
            this.Admin_text5.Size = new System.Drawing.Size(100, 20);
            this.Admin_text5.TabIndex = 11;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Admin_text5);
            this.Controls.Add(this.Admin_text9);
            this.Controls.Add(this.Admin_text8);
            this.Controls.Add(this.Admin_text7);
            this.Controls.Add(this.Admin_text6);
            this.Controls.Add(this.Admin_text4);
            this.Controls.Add(this.Admin_text3);
            this.Controls.Add(this.Admin_text2);
            this.Controls.Add(this.Admin_text1);
            this.Controls.Add(this.Lista_akcji);
            this.Controls.Add(this.Admin_OK);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Admin_OK;
        private System.Windows.Forms.ComboBox Lista_akcji;
        private System.Windows.Forms.TextBox Admin_text1;
        private System.Windows.Forms.TextBox Admin_text2;
        private System.Windows.Forms.TextBox Admin_text3;
        private System.Windows.Forms.TextBox Admin_text7;
        private System.Windows.Forms.TextBox Admin_text6;
        private System.Windows.Forms.TextBox Admin_text4;
        private System.Windows.Forms.TextBox Admin_text8;
        private System.Windows.Forms.TextBox Admin_text9;
        private System.Windows.Forms.TextBox Admin_text5;
    }
}