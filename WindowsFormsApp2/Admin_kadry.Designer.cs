namespace WindowsFormsApp2
{
    partial class Admin_kadry
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
            this.kadry_text1 = new System.Windows.Forms.TextBox();
            this.kadry_text2 = new System.Windows.Forms.TextBox();
            this.kadry_combo = new System.Windows.Forms.ComboBox();
            this.kadry_text3 = new System.Windows.Forms.TextBox();
            this.kadry_text4 = new System.Windows.Forms.TextBox();
            this.kadry_text5 = new System.Windows.Forms.TextBox();
            this.kadry_text6 = new System.Windows.Forms.TextBox();
            this.kadry_text7 = new System.Windows.Forms.TextBox();
            this.kadry_text8 = new System.Windows.Forms.TextBox();
            this.kadry_text9 = new System.Windows.Forms.TextBox();
            this.kadry_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kadry_text1
            // 
            this.kadry_text1.Location = new System.Drawing.Point(343, 28);
            this.kadry_text1.Name = "kadry_text1";
            this.kadry_text1.Size = new System.Drawing.Size(100, 20);
            this.kadry_text1.TabIndex = 0;
            // 
            // kadry_text2
            // 
            this.kadry_text2.Location = new System.Drawing.Point(343, 70);
            this.kadry_text2.Name = "kadry_text2";
            this.kadry_text2.Size = new System.Drawing.Size(100, 20);
            this.kadry_text2.TabIndex = 1;
            // 
            // kadry_combo
            // 
            this.kadry_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kadry_combo.FormattingEnabled = true;
            this.kadry_combo.Items.AddRange(new object[] {
            "Dodaj pracownika",
            "Usun pracownika"});
            this.kadry_combo.Location = new System.Drawing.Point(32, 161);
            this.kadry_combo.Name = "kadry_combo";
            this.kadry_combo.Size = new System.Drawing.Size(191, 33);
            this.kadry_combo.TabIndex = 2;
            this.kadry_combo.SelectedIndexChanged += new System.EventHandler(this.kadry_combo_SelectedIndexChanged);
            // 
            // kadry_text3
            // 
            this.kadry_text3.Location = new System.Drawing.Point(343, 115);
            this.kadry_text3.Name = "kadry_text3";
            this.kadry_text3.Size = new System.Drawing.Size(100, 20);
            this.kadry_text3.TabIndex = 3;
            // 
            // kadry_text4
            // 
            this.kadry_text4.Location = new System.Drawing.Point(343, 161);
            this.kadry_text4.Name = "kadry_text4";
            this.kadry_text4.Size = new System.Drawing.Size(100, 20);
            this.kadry_text4.TabIndex = 4;
            this.kadry_text4.TextChanged += new System.EventHandler(this.kadry_text4_TextChanged);
            // 
            // kadry_text5
            // 
            this.kadry_text5.Location = new System.Drawing.Point(343, 200);
            this.kadry_text5.Name = "kadry_text5";
            this.kadry_text5.Size = new System.Drawing.Size(100, 20);
            this.kadry_text5.TabIndex = 5;
            // 
            // kadry_text6
            // 
            this.kadry_text6.Location = new System.Drawing.Point(343, 242);
            this.kadry_text6.Name = "kadry_text6";
            this.kadry_text6.Size = new System.Drawing.Size(100, 20);
            this.kadry_text6.TabIndex = 6;
            // 
            // kadry_text7
            // 
            this.kadry_text7.Location = new System.Drawing.Point(343, 286);
            this.kadry_text7.Name = "kadry_text7";
            this.kadry_text7.Size = new System.Drawing.Size(100, 20);
            this.kadry_text7.TabIndex = 7;
            // 
            // kadry_text8
            // 
            this.kadry_text8.Location = new System.Drawing.Point(343, 329);
            this.kadry_text8.Name = "kadry_text8";
            this.kadry_text8.Size = new System.Drawing.Size(100, 20);
            this.kadry_text8.TabIndex = 8;
            // 
            // kadry_text9
            // 
            this.kadry_text9.Location = new System.Drawing.Point(343, 369);
            this.kadry_text9.Name = "kadry_text9";
            this.kadry_text9.Size = new System.Drawing.Size(100, 20);
            this.kadry_text9.TabIndex = 9;
            // 
            // kadry_OK
            // 
            this.kadry_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kadry_OK.Location = new System.Drawing.Point(615, 369);
            this.kadry_OK.Name = "kadry_OK";
            this.kadry_OK.Size = new System.Drawing.Size(140, 49);
            this.kadry_OK.TabIndex = 10;
            this.kadry_OK.Text = "Zatwierdz";
            this.kadry_OK.UseVisualStyleBackColor = true;
            this.kadry_OK.Click += new System.EventHandler(this.kadry_OK_Click);
            // 
            // Admin_kadry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kadry_OK);
            this.Controls.Add(this.kadry_text9);
            this.Controls.Add(this.kadry_text8);
            this.Controls.Add(this.kadry_text7);
            this.Controls.Add(this.kadry_text6);
            this.Controls.Add(this.kadry_text5);
            this.Controls.Add(this.kadry_text4);
            this.Controls.Add(this.kadry_text3);
            this.Controls.Add(this.kadry_combo);
            this.Controls.Add(this.kadry_text2);
            this.Controls.Add(this.kadry_text1);
            this.Name = "Admin_kadry";
            this.Text = "Admin_kadry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kadry_text1;
        private System.Windows.Forms.TextBox kadry_text2;
        private System.Windows.Forms.ComboBox kadry_combo;
        private System.Windows.Forms.TextBox kadry_text3;
        private System.Windows.Forms.TextBox kadry_text4;
        private System.Windows.Forms.TextBox kadry_text5;
        private System.Windows.Forms.TextBox kadry_text6;
        private System.Windows.Forms.TextBox kadry_text7;
        private System.Windows.Forms.TextBox kadry_text8;
        private System.Windows.Forms.TextBox kadry_text9;
        private System.Windows.Forms.Button kadry_OK;
    }
}