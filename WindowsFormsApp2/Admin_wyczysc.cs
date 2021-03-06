﻿using MySql.Data.MySqlClient;
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
    public partial class Admin_wyczysc : Form
    {
        bool czyPoprawne = true;

        public Admin_wyczysc()
        {
            InitializeComponent();
        }

      
        private void Usun_dane_polaczenia()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=bd2";

                foreach (char c in wyczysc_text1.Text)
                {
                    if (!char.IsDigit(c))
                        MessageBox.Show("Podano bledny format danych");
                        czyPoprawne = false;
                }

                string Query = "delete FROM polaczenia WHERE Data < DATE_SUB(NOW(), INTERVAL " + wyczysc_text1.Text + " DAY);";
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

        private void wyczysc_OK_Click(object sender, EventArgs e)
        {
            if(czyPoprawne = true)
            {
                Usun_dane_polaczenia();
            }
            else
            {
                Admin_wyczysc wyczysc = new Admin_wyczysc();
                wyczysc.Region = this.Region;
                this.Hide();
                wyczysc.ShowDialog();
                this.Show();
            }

            
        }
    }
}
