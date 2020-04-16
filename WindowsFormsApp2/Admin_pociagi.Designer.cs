namespace WindowsFormsApp2
{
    partial class Admin_pociagi
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
            this.pociagi_combo = new System.Windows.Forms.ComboBox();
            this.pociagi_text1 = new System.Windows.Forms.TextBox();
            this.pociagi_text2 = new System.Windows.Forms.TextBox();
            this.pociagi_text3 = new System.Windows.Forms.TextBox();
            this.pociagi_OK = new System.Windows.Forms.Button();
            this.pociagi_text4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pociagi_combo
            // 
            this.pociagi_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pociagi_combo.FormattingEnabled = true;
            this.pociagi_combo.Items.AddRange(new object[] {
            "Dodaj trase",
            "Dodaj polaczenie"});
            this.pociagi_combo.Location = new System.Drawing.Point(42, 185);
            this.pociagi_combo.Name = "pociagi_combo";
            this.pociagi_combo.Size = new System.Drawing.Size(175, 33);
            this.pociagi_combo.TabIndex = 0;
            this.pociagi_combo.SelectedIndexChanged += new System.EventHandler(this.pociagi_combo_SelectedIndexChanged);
            // 
            // pociagi_text1
            // 
            this.pociagi_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pociagi_text1.Location = new System.Drawing.Point(328, 91);
            this.pociagi_text1.Name = "pociagi_text1";
            this.pociagi_text1.Size = new System.Drawing.Size(167, 28);
            this.pociagi_text1.TabIndex = 1;
            // 
            // pociagi_text2
            // 
            this.pociagi_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pociagi_text2.Location = new System.Drawing.Point(328, 161);
            this.pociagi_text2.Name = "pociagi_text2";
            this.pociagi_text2.Size = new System.Drawing.Size(167, 28);
            this.pociagi_text2.TabIndex = 2;
            // 
            // pociagi_text3
            // 
            this.pociagi_text3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pociagi_text3.Location = new System.Drawing.Point(328, 233);
            this.pociagi_text3.Name = "pociagi_text3";
            this.pociagi_text3.Size = new System.Drawing.Size(167, 28);
            this.pociagi_text3.TabIndex = 3;
            // 
            // pociagi_OK
            // 
            this.pociagi_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pociagi_OK.Location = new System.Drawing.Point(600, 343);
            this.pociagi_OK.Name = "pociagi_OK";
            this.pociagi_OK.Size = new System.Drawing.Size(144, 58);
            this.pociagi_OK.TabIndex = 4;
            this.pociagi_OK.Text = "Zatwierdz!";
            this.pociagi_OK.UseVisualStyleBackColor = true;
            this.pociagi_OK.Click += new System.EventHandler(this.pociagi_OK_Click);
            // 
            // pociagi_text4
            // 
            this.pociagi_text4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pociagi_text4.Location = new System.Drawing.Point(328, 301);
            this.pociagi_text4.Name = "pociagi_text4";
            this.pociagi_text4.Size = new System.Drawing.Size(167, 28);
            this.pociagi_text4.TabIndex = 5;
            // 
            // Admin_pociagi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pociagi_text4);
            this.Controls.Add(this.pociagi_OK);
            this.Controls.Add(this.pociagi_text3);
            this.Controls.Add(this.pociagi_text2);
            this.Controls.Add(this.pociagi_text1);
            this.Controls.Add(this.pociagi_combo);
            this.Name = "Admin_pociagi";
            this.Text = "Admin_pociagi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pociagi_combo;
        private System.Windows.Forms.TextBox pociagi_text1;
        private System.Windows.Forms.TextBox pociagi_text2;
        private System.Windows.Forms.TextBox pociagi_text3;
        private System.Windows.Forms.Button pociagi_OK;
        private System.Windows.Forms.TextBox pociagi_text4;
    }
}