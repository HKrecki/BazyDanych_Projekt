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
    public partial class Kasjer_sprawdzDostepnosc : Form
    {
        int iloscMiejsc = -1;




        public Kasjer_sprawdzDostepnosc()
        {
            InitializeComponent();
        }


        private void Sprawdz_dostepnosc()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=bd2";


                string Query = "SELECT polaczenia.Ilosc_miejsc FROM polaczenia, trasy WHERE(trasy.Stacje = " + Kasjer_SprawdzDostepnosc_StacjaOdjazdu_textBox.Text + ") AND(trasy.idTrasy = polaczenia.trasy_idTrasy) AND polaczenia.Data = '" + Kasjer_SprawdzDostepnosc_data_textBox.Text + "' ;";


                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataReader reader = MyCommand2.ExecuteReader();
                while (reader.Read())
                {
                    // Tutaj zmienic jesli rozmiar int w bazie jest inny np. GetInt32.
                    iloscMiejsc = reader.GetInt16(0); 
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




        private void Kasjer_SprawdzDostepnosc_Zatwierdz_pushButton_Click(object sender, EventArgs e)
        {
            Sprawdz_dostepnosc();

            if(iloscMiejsc > 0)
            {
                ilosc_miejsc.Text = "Dostepne: " + iloscMiejsc.ToString() + " miejsc ";
            }
            else
            {
                ilosc_miejsc.Text = "Brak wolnych miejsc ";
            }
        }

        private void Kasjer_SprawdzDostepnosc_data_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kasjer_SprawdzDostepnosc_DanePolaczenia_box_Enter(object sender, EventArgs e)
        {

        }
    }
}
