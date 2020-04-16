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

// Akcje dyrektora sa skonczone!!!
 
namespace WindowsFormsApp2
{
    public partial class Dyrektor : Form
    {
        public Dyrektor()
        {
            InitializeComponent();
            this.ShowDialog();
        }
        

        private void Combo_dyrektor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combo_dyrektor.SelectedIndex == 0)
            {
                Dyrektor_text1.Text = "PESEL";
                Dyrektor_text2.Text = "Pensja";

            }
            else if (Combo_dyrektor.SelectedIndex == 1)
            {
                Dyrektor_text1.Text = "PESEL";
                Dyrektor_text2.Text = "Premia";
            }
        }

        private void Akcja_dyrektora(object sender, EventArgs e)
        {
            if (Combo_dyrektor.SelectedIndex == 0)
            {
                try
                {

                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=bd2";

                    string Query = "UPDATE pracownicy SET Pensja = " + Dyrektor_text2.Text + " WHERE PESEL = " + Dyrektor_text1.Text + ";";
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
            else if(Combo_dyrektor.SelectedIndex == 1)
            {
                try
                {

                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=bd2";

                    string Query = "UPDATE pracownicy SET Premia = " + Dyrektor_text2.Text + " WHERE PESEL = " + Dyrektor_text1.Text + ";";
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

        internal bool Visible()
        {
            throw new NotImplementedException();
        }
    }
}
