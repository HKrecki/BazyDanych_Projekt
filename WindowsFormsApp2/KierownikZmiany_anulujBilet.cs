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
    public partial class KierownikZmiany_anulujBilet : Form
    {
        public KierownikZmiany_anulujBilet()
        {
            InitializeComponent();
        }

        private void Anuluj_bilet()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=bd2";

                string Query = "delete FROM Transakcja WHERE idTransakcja = " + numerBiletu_TextBox.Text + ";";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show(Query);
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nazwisko_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zatwierdź_Click(object sender, EventArgs e)
        {
            Anuluj_bilet();
        }
    }
}
