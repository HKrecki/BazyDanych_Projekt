using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Przycisk_kadry_Click(object sender, EventArgs e)
        {
            Admin_kadry kadry = new Admin_kadry();
            kadry.Region = this.Region;
            this.Hide();
            kadry.ShowDialog();
            this.Show();
        }

        private void Przycisk_pociagi_Click(object sender, EventArgs e)
        {
            Admin_pociagi pociagi = new Admin_pociagi();
            pociagi.Region = this.Region;
            this.Hide();
            pociagi.ShowDialog();
            this.Show();
           
        }

        private void Przycisk_wyczysc_Click(object sender, EventArgs e)
        {
            Admin_wyczysc wyczysc = new Admin_wyczysc();
            wyczysc.Region = this.Region;
            this.Hide();
            wyczysc.ShowDialog();
            this.Show();
            

        }
    }
}
