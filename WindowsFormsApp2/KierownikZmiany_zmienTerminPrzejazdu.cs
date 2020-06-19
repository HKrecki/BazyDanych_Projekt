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
    public partial class KierownikZmiany_zmienTerminPrzejazdu : Form
    {
        public KierownikZmiany_zmienTerminPrzejazdu()
        {
            InitializeComponent();
        }

        private void Zmien_date()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=bd2";


                foreach (char c in nowaData_ZmianaTerminu.Text)
                {
                    if (!char.IsDigit(c))
                        MessageBox.Show("Podano bledny format danych");
                }

                foreach (char c in NumerBiletu_TextBox.Text)
                {
                    if (!char.IsDigit(c))
                        MessageBox.Show("Podano bledny format danych");
                }


                string Query = "UPDATE Polaczenia SET Data = '" + nowaData_ZmianaTerminu.Text + "' WHERE idPolaczenia = " + NumerBiletu_TextBox.Text;

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



        private void Zatwierdź_Click(object sender, EventArgs e)
        {
            Zmien_date();
        }
    }
}
