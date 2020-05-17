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
    public partial class Kasjer_kupBilet : Form
    {
        int idTrasy = 0;
        int idPolaczenia = 0;


        public Kasjer_kupBilet()
        {
            InitializeComponent();
        }

        private void Dodaj_klienta()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=bd2";

                string Query = "INSERT INTO klient VALUES (" + ZakupBiletu_Pesel_textBox.Text + ",'" + ZakupBiletu_Imie_textBox.Text + "','" + ZakupBiletu_Nazwisko_textBox + "'," + ZakupBiletu_Znizka_textBox.Text + "," + ZakupBiletu_Telefon_textBox.Text + ",'" + ZakupBiletu_adres_textBox.Text + ");";

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

        // Zwraca idTrasy. Jesli rowne 0, to trasa nie istnieje
        private void CzyIstniejeTrasa()
        {

            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=bd2";


                string Query = "SELECT idTrasy FROM Trasy WHERE EXISTS (SELECT Stacje, Godzina_odj FROM trasy WHERE Stacje='" + ZakupBiletu_stacjaOdjazdu.Text + "' AND Godzina_odj='" + ZakupBiletu_godzina.Text + "')";


                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataReader reader = MyCommand2.ExecuteReader();
                while (reader.Read())
                {
                    // Tutaj zmienic jesli rozmiar int w bazie jest inny np. GetInt32.
                    idTrasy = reader.GetInt16(0);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CzyIstniejePolaczenie()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=bd2";


                string Query = "SELECT idPolaczenia FROM polaczenia WHERE polaczenia.trasy_idTrasy=" + idTrasy + " AND polaczenia.Data='" + ZakupBiletu_data.Text + "'";


                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataReader reader = MyCommand2.ExecuteReader();
                while (reader.Read())
                {
                    // Tutaj zmienic jesli rozmiar int w bazie jest inny np. GetInt32.
                    idPolaczenia = reader.GetInt16(0);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void KupBilet()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=bd2";

                string Query = "INSERT INTO transakcja(idKlient - PESEL, idPolaczenia) VALUES("+ ZakupBiletu_Pesel_textBox.Text +", " + idPolaczenia + ");";

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


        private void Powitanie_kasjer_Click(object sender, EventArgs e)
        {

        }

        private void Zatwierdź_Click(object sender, EventArgs e)
        {
            Dodaj_klienta();
            CzyIstniejeTrasa();
            CzyIstniejePolaczenie();

            // Jesli istnieje polaczenie
            if(idTrasy != 0 && idPolaczenia != 0)
            {
                // Utworz transakcje

            }
        }
    }
}
