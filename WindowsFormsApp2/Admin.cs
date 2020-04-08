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
       private void Dodaj()
        {
            if(Lista_akcji.SelectedIndex == 0)
            {
                Admin_text1.Text = "Login";
                Admin_text2.Text = "Imie";
                Admin_text3.Text = "Nazwisko";
                Admin_text4.Text = "PESEL";
                Admin_text5.Text = "Haslo";
                Admin_text6.Text = "Stanowisko";
                Admin_text7.Text = "Ilosc transakcji";
                Admin_text8.Text = "Pensja";
                Admin_text9.Text = "Premia";

             
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void Dodaj_pracownika(object sender, EventArgs e)
        {
           if (Lista_akcji.Text == "Dodaj pracownika")
                {
                try
                {
                    
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=bd";
                 
                    string Query = "INSERT INTO pracownicy VALUES ('" + Admin_text1.Text + "','" + Admin_text2.Text + "','" + Admin_text3.Text + "'," + Admin_text4.Text + ",'" + Admin_text5.Text +"','"+ Admin_text6.Text + "'," + Admin_text7.Text + "," + Admin_text8.Text + "," + Admin_text9.Text + ");";
            
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

        private void Lista_akcji_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dodaj();
        }

        private void Admin_text8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
