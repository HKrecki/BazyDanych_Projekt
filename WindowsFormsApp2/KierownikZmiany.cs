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
    public partial class KierownikZmiany : Form
    {
        public KierownikZmiany()
        {
            InitializeComponent();
        }

        private void Powitanie_admin_Click(object sender, EventArgs e)
        {

        }

        private void Przycisk_anulujBilet_Click(object sender, EventArgs e)
        {
            KierownikZmiany_anulujBilet anulujBilet = new KierownikZmiany_anulujBilet();
            anulujBilet.Region = this.Region;
            this.Hide();
            anulujBilet.ShowDialog();
            this.Show();
        }

        private void Przycisk_zmienTerminPrzejazdu_Click(object sender, EventArgs e)
        {
            KierownikZmiany_zmienTerminPrzejazdu zmienTerminPrzejazdu = new KierownikZmiany_zmienTerminPrzejazdu();
            zmienTerminPrzejazdu.Region = this.Region;
            this.Hide();
            zmienTerminPrzejazdu.ShowDialog();
            this.Show();
        }
    }
}
