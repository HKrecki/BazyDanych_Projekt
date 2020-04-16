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
    public partial class Admin_pociagi : Form
    {
       int liczba_stacji = 0;
        public Admin_pociagi()
        {
            InitializeComponent();
        }
       // string Query = "select count(*) from trasy where idTrasy like '" + pociagi_text1.Text + "';";
        private void Sprawdz_liczbe_stacji()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=bd2";

                string Query = "select count(*) from trasy where idTrasy like '" + pociagi_text1.Text + "%';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataReader reader = MyCommand2.ExecuteReader();
                while (reader.Read())
                {
                    liczba_stacji = reader.GetInt32(0);
                  
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Dodaj_stacje()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=bd2";

                string Query = "INSERT INTO Trasy VALUES ('" + pociagi_text1.Text + pociagi_text4.Text + "','" + pociagi_text2.Text + "','" + pociagi_text3.Text + "');";

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

        private void Dodaj_polaczenie()
        {

            Sprawdz_liczbe_stacji();
            for (int i = 1; i <= liczba_stacji; i++)
            {
                try
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=bd2";

                    string Query = "INSERT INTO Polaczenia (Trasy_idTrasy,Data,Ilosc_miejsc) VALUES ('" + pociagi_text1.Text + i + "','" + pociagi_text2.Text + "'," + pociagi_text3.Text + ");";

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
        }
        private void pociagi_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pociagi_combo.SelectedIndex == 0)
            {
                pociagi_text1.Text = "Nazwa";
                pociagi_text2.Text = "Stacja";
                pociagi_text3.Text = "Godzina";
                pociagi_text4.Text = "Kolejnosc";
                pociagi_text4.Visible = true;

            }
            else if (pociagi_combo.SelectedIndex == 1)
            {
                pociagi_text1.Text = "Trasa";
                pociagi_text2.Text = "Data";
                pociagi_text3.Text = "Miejsca";
                pociagi_text4.Visible = false;

            }
        }

        private void pociagi_OK_Click(object sender, EventArgs e)
        {
            if (pociagi_combo.SelectedIndex == 0)
            {
                Dodaj_stacje();

            }
            else if (pociagi_combo.SelectedIndex == 1)
            {
                Dodaj_polaczenie();
            }
        }
    }
}
