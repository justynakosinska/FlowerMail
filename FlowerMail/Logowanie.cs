using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerMail
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Justyna\source\repos\FlowerMail\FlowerMail\PocztaKwiatowaBD.mdf;Integrated Security=True");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LogowanieAdministratora Obj = new LogowanieAdministratora();
            Obj.Show();
            this.Hide();
        }
        public static string PName = "";
        private void Zaloguj_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda= new SqlDataAdapter("Select Count(*) from pracownicy where imie_prac='"+login.Text+"' and haslo_prac='"+haslo.Text+"'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                PName = login.Text;
                StronaGłówna Obj = new StronaGłówna();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło");
            }
            Con.Close();
        }
    }
}
