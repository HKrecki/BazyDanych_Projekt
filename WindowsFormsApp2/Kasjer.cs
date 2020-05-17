using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp2
{
    public partial class Kasjer : Form
    {
        public Kasjer()
        {
            InitializeComponent();
        }

        private void Przycisk_kasjer_sprawdzDostepnosc_Click(object sender, EventArgs e)
        {
            Kasjer_sprawdzDostepnosc sprawdzDostepnosc = new Kasjer_sprawdzDostepnosc();
            sprawdzDostepnosc.Region = this.Region;
            this.Hide();
            sprawdzDostepnosc.ShowDialog();
            this.Show();
        }
    }
}
