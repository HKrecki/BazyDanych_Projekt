using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    
    public partial class Logowanie : Form
    {
       
        // Inicjujemy zmienne globalne
        bool Poprawne = false;
        String haslo = "dd";
        String stanowisko = "ddd";
        public Logowanie()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        

            private void Sprawdz_haslo()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=bd2";




                string Query = "select Haslo from pracownicy where LOGIN = '" +Login.Text+"' ;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataReader reader = MyCommand2.ExecuteReader();
                while (reader.Read())
                {
                    haslo = reader.GetString(0);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Sprawdz_stanowisko()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=bd2";

                string Query = "select Stanowisko from pracownicy where LOGIN = '" + Login.Text + "' ;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataReader reader = MyCommand2.ExecuteReader();
                while (reader.Read())
                {
                    stanowisko = reader.GetString(0);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            Sprawdz_haslo();
            Sprawdz_stanowisko();
            if (Haslo.Text == haslo)
            {
                Log_kom.Text = "Haslo poprawne";
                Poprawne = true;
            }
            else Log_kom.Text = "Bledne haslo";

            if (stanowisko == "Administrator" && Poprawne == true)  // Tu trzeba bedzie zmienic zeby patrzyl na stanowisko a nie na login
            {
                Admin admin = new Admin();
                admin.Region = this.Region;
                this.Hide();
                admin.ShowDialog();
                this.Close();
               
            }
            else if(stanowisko == "Dyrektor" && Poprawne == true) // Tutaj tak samo
            {
                this.Hide();
                Dyrektor dyrektor = new Dyrektor();
                dyrektor.Region = this.Region;
                this.Close();
            }
            else if (stanowisko == "Kierownik" && Poprawne == true) // Tutaj tak samo
            {
                KierownikZmiany admin = new KierownikZmiany();
                admin.Region = this.Region;
                this.Hide();
                admin.ShowDialog();
                this.Close();
            }
            else
            {
                Log_kom.Text = "Podano błędny format danych";
            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Logowanie_Load(object sender, EventArgs e)
        {

        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
