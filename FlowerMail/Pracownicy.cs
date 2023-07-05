using System.Data;
using System.Data.SqlClient;

namespace FlowerMail
{
    public partial class Pracownicy : Form
    {
        public Pracownicy()
        {
            InitializeComponent();
            ShowWorkers();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Justyna\source\repos\FlowerMail\FlowerMail\PocztaKwiatowaBD.mdf;Integrated Security=True");
        private void ShowWorkers()
        {
            Conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from pracownicy", Conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            pokaz_pracownikow.DataSource = ds.Tables[0];
            Conn.Close();
        }
        private void Reset()
        {
            imie_prac.Text = "";
            tel_prac.Text = "";
            adres_prac.Text = "";
            haslo_prac.Text = "";
        }
        private void Zapisz_Click(object sender, EventArgs e)
        {
            if (adres_prac.Text == "" || imie_prac.Text == "" || haslo_prac.Text == "" || tel_prac.Text == "" || plec_prac.SelectedIndex == -1)
            {
                MessageBox.Show("Brakuj¹ce informacje");
            }
            else
            {
                try
                {
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into pracownicy(imie_prac,data_ur,tel_prac,adres_prac,plec_prac,haslo_prac) values(@IP,@DP,@TP,@AP,@PP,@HP)", Conn);
                    cmd.Parameters.AddWithValue("@IP", imie_prac.Text);
                    cmd.Parameters.AddWithValue("@DP", data_ur.Value.Date);
                    cmd.Parameters.AddWithValue("@TP", tel_prac.Text);
                    cmd.Parameters.AddWithValue("@AP", adres_prac.Text);
                    cmd.Parameters.AddWithValue("@PP", plec_prac.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@HP", haslo_prac.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dane klienta wprowadzone");
                    Conn.Close();
                    ShowWorkers();
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
            if (adres_prac.Text == "" || imie_prac.Text == "" || haslo_prac.Text == "" || tel_prac.Text == "" || plec_prac.SelectedIndex == -1)
            {
                MessageBox.Show("Brakuj¹ce informacje");
            }
            else
            {
                try
                {
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("update pracownicy set imie_prac=@IP ,data_ur=@DP ,tel_prac=@TP ,adres_prac=@AP ,plec_prac=@PP ,haslo_prac=@HP where id_prac=@PKey", Conn);
                    cmd.Parameters.AddWithValue("@IP", imie_prac.Text);
                    cmd.Parameters.AddWithValue("@DP", data_ur.Value.Date);
                    cmd.Parameters.AddWithValue("@TP", tel_prac.Text);
                    cmd.Parameters.AddWithValue("@AP", adres_prac.Text);
                    cmd.Parameters.AddWithValue("@PP", plec_prac.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@HP", haslo_prac.Text);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dane klienta zaktualizowane");
                    Conn.Close();
                    ShowWorkers();
                    Reset();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Usun_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Wybierz Pracownika");
            }
            else
            {
                try
                {
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from pracownicy where id_prac=@PKey", Conn);
                    cmd.Parameters.AddWithValue("@PKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dane pracownika usuniête");
                    Conn.Close();
                    ShowWorkers();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void Pracownicy_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int Key = 0;
        private void pokaz_pracownikow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            imie_prac.Text = pokaz_pracownikow.SelectedRows[0].Cells[1].Value.ToString();
            data_ur.Value = Convert.ToDateTime(pokaz_pracownikow.SelectedRows[0].Cells[2].Value.ToString());
            adres_prac.Text = pokaz_pracownikow.SelectedRows[0].Cells[3].Value.ToString();
            tel_prac.Text = pokaz_pracownikow.SelectedRows[0].Cells[4].Value.ToString();
            plec_prac.SelectedItem = pokaz_pracownikow.SelectedRows[0].Cells[5].Value.ToString();
            haslo_prac.Text = pokaz_pracownikow.SelectedRows[0].Cells[6].Value.ToString();
            if (imie_prac.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(pokaz_pracownikow.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Logowanie Obj = new Logowanie();
            Obj.Show();
            this.Hide();
        }
    }
}