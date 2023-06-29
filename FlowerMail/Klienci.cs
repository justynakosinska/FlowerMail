using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FlowerMail
{
    public partial class Klienci : Form
    {
        public Klienci()
        {
            InitializeComponent();
            ShowCustomers();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Justyna\Documents\PocztaKwiatowaBD.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowCustomers()
        {
            Conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from klienci", Conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            pokaz_klientow.DataSource = ds.Tables[0];
            Conn.Close();
        }
        private void Zapisz_Click(object sender, EventArgs e)
        {
            if (adres_klienta.Text == "" || imie_klienta.Text == "" || tel_klienta.Text == "")
            {
                MessageBox.Show("Brakujące informacje");
            }
            else
            {
                try
                {
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into klienci(imie_klienta,data_ur,tel_klienta,adres_klienta) values(@IK,@DK,@TK,@AK)", Conn);
                    cmd.Parameters.AddWithValue("@IK", imie_klienta.Text);
                    cmd.Parameters.AddWithValue("@DK", data_ur.Value.Date);
                    cmd.Parameters.AddWithValue("@TK", tel_klienta.Text);
                    cmd.Parameters.AddWithValue("@AK", adres_klienta.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dane klienta wprowadzone");
                    Conn.Close();
                    ShowCustomers();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Edytuj_Click(object sender, EventArgs e)
        {
            if (adres_klienta.Text == "" || imie_klienta.Text == "" || tel_klienta.Text == "")
            {
                MessageBox.Show("Brakujące informacje");
            }
            else
            {
                try
                {
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("update klienci set imie_klienta=@IK ,data_ur=@DK ,tel_klienta=@TK ,adres_klienta=@AK where id_klienta=@KKey", Conn);
                    cmd.Parameters.AddWithValue("@IK", imie_klienta.Text);
                    cmd.Parameters.AddWithValue("@DK", data_ur.Value.Date);
                    cmd.Parameters.AddWithValue("@TK", tel_klienta.Text);
                    cmd.Parameters.AddWithValue("@AK", adres_klienta.Text);
                    cmd.Parameters.AddWithValue("@KKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dane klienta zaktualizowane");
                    Conn.Close();
                    ShowCustomers();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void pokaz_klientow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            imie_klienta.Text = pokaz_klientow.SelectedRows[0].Cells[1].Value.ToString();
            data_ur.Text = pokaz_klientow.SelectedRows[0].Cells[2].Value.ToString();
            tel_klienta.Text = pokaz_klientow.SelectedRows[0].Cells[3].Value.ToString();
            adres_klienta.Text = pokaz_klientow.SelectedRows[0].Cells[4].Value.ToString();
            if (imie_klienta.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(pokaz_klientow.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void Reset()
        {
            imie_klienta.Text = "";
            tel_klienta.Text = "";
            adres_klienta.Text = "";
        }
        private void Usun_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Wybierz Klienta");
            }
            else
            {
                try
                {
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from klienci where id_klienta=@KKey", Conn);
                    cmd.Parameters.AddWithValue("@KKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dane klienta usunięte");
                    Conn.Close();
                    ShowCustomers();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StronaGłówna Obj = new StronaGłówna();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
