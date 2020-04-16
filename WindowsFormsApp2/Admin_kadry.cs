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
    public partial class Admin_kadry : Form
    {
        public Admin_kadry()
        {
            InitializeComponent();
        }

        private void Dodaj_pracownika()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=bd2";

                string Query = "INSERT INTO pracownicy VALUES ('" + kadry_text1.Text + "','" + kadry_text2.Text + "','" + kadry_text3.Text + "'," + kadry_text4.Text + ",'" + kadry_text5.Text + "','" + kadry_text6.Text + "'," + kadry_text7.Text + "," + kadry_text8.Text + "," + kadry_text9.Text + ");";

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

        private void Usun_pracownika()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=bd2";

                string Query = "UPDATE pracownicy SET stanowisko = 'zwolniony' WHERE PESEL = " + kadry_text1.Text + ";";

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

        private void kadry_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kadry_combo.SelectedIndex == 0)
            {
                kadry_text1.Text = "Login";
                kadry_text2.Text = "Imie";
                kadry_text3.Text = "Nazwisko";
                kadry_text4.Text = "PESEL";
                kadry_text5.Text = "Haslo";
                kadry_text6.Text = "Stanowisko";
                kadry_text7.Text = "Ilosc transakcji";
                kadry_text8.Text = "Pensja";
                kadry_text9.Text = "Premia";
                kadry_OK.Text = "DODAJ!";
                kadry_text3.Visible = true;
                kadry_text4.Visible = true;
                kadry_text5.Visible = true;
                kadry_text6.Visible = true;
                kadry_text7.Visible = true;
                kadry_text8.Visible = true;
                kadry_text9.Visible = true;

            }
            else if(kadry_combo.SelectedIndex == 1)
            {
                kadry_text1.Text = "PESEL";
                kadry_text2.Text = "Nazwisko";
                kadry_text3.Visible = false;
                kadry_text4.Visible = false;
                kadry_text5.Visible = false;
                kadry_text6.Visible = false;
                kadry_text7.Visible = false;
                kadry_text8.Visible = false;
                kadry_text9.Visible = false;
                kadry_OK.Text = "USUN!";
            }
        }

        private void kadry_OK_Click(object sender, EventArgs e)
        {
            if (kadry_combo.SelectedIndex == 0)
            {
                Dodaj_pracownika();
            }
            else if (kadry_combo.SelectedIndex == 1)
            {
                Usun_pracownika();
            }
        }

        private void kadry_text4_TextChanged(object sender, EventArgs e)
        {
            // Tutaj zmieniamy status pracownika jezeli istnieje juz w bazie ale byl zwolniony
           
        }
    }
}
