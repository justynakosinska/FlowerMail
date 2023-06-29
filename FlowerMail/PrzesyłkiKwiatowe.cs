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
    public partial class PrzesyłkiKwiatowe : Form
    {
        public PrzesyłkiKwiatowe()
        {
            InitializeComponent();
            ShowParcels();
            GetId();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Justyna\Documents\PocztaKwiatowaBD.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowParcels()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from przesylki", Con);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            pokaz_przesylki.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void GetName()
        {
            Con.Open();
            string Query = "select * from klienci where id_klienta=" + id_wys.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                imie_wys.Text = dr["imie_klienta"].ToString();
            }
            Con.Close();
        }
        private void GetId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from klienci", Con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_klienta", typeof(int));
            dt.Load(dr);
            id_wys.ValueMember = "id_klienta";
            id_wys.DataSource = dt;
            Con.Close();
        }
        private void PrzesyłkiKwiatowe_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            if (adres.Text == "" || imie_wys.Text == "" || imie_odb.Text == "" || tel_odb.Text == "" || punkt_nadania.SelectedIndex == -1 || rodzaj.SelectedIndex == -1 || status.SelectedIndex == -1 || rozmiar.SelectedIndex == -1)
            {
                MessageBox.Show("Brakujące informacje");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into przesylki(data,punkt_nadania,imie_wys,imie_odb,adres,tel_wys,tel_odb,rozmiar,rodzaj,status) values(@DN,@PN,@IW,@IO,@A,@TW,@TO,@R,@RO,@S)", Con);
                    cmd.Parameters.AddWithValue("@DN", data_nadania.Value.Date);
                    cmd.Parameters.AddWithValue("@PN", punkt_nadania.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@IW", imie_wys.Text);
                    cmd.Parameters.AddWithValue("@IO", imie_odb.Text);
                    cmd.Parameters.AddWithValue("@A", adres.Text);
                    cmd.Parameters.AddWithValue("@TW", tel_wys.Text);
                    cmd.Parameters.AddWithValue("@TO", tel_odb.Text);
                    cmd.Parameters.AddWithValue("@R", rozmiar.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@RO", rodzaj.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@S", status.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Przesyłka kwiatowa zarejestrowana");
                    Con.Close();
                    ShowParcels();
                    //Reset();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }



        private void id_wys_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetName();
        }

        private void Edytuj_Click(object sender, EventArgs e)
        {
            if (adres.Text == "" || imie_wys.Text == "" || imie_odb.Text == "" || tel_odb.Text == "" || punkt_nadania.SelectedIndex == -1 || rodzaj.SelectedIndex == -1 || status.SelectedIndex == -1 || rozmiar.SelectedIndex == -1)
            {
                MessageBox.Show("Brakujące informacje");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update przesylki set data=@DN,punkt_nadania=@PN,imie_wys=@IW,imie_odb=@IO,adres=@A,tel_wys=@TW,tel_odb=@TO,rozmiar=@R,rodzaj=@RO,status=@S where id_przesylki=@PKey", Con);
                    cmd.Parameters.AddWithValue("@DN", data_nadania.Value.Date);
                    cmd.Parameters.AddWithValue("@PN", punkt_nadania.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@IW", imie_wys.Text);
                    cmd.Parameters.AddWithValue("@IO", imie_odb.Text);
                    cmd.Parameters.AddWithValue("@A", adres.Text);
                    cmd.Parameters.AddWithValue("@TW", tel_wys.Text);
                    cmd.Parameters.AddWithValue("@TO", tel_odb.Text);
                    cmd.Parameters.AddWithValue("@R", rozmiar.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@RO", rodzaj.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@S", status.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dane przesyłki zaktualizowane");
                    Con.Close();
                    ShowParcels();
                    //Reset();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void pokaz_przesylki_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            data_nadania.Text = pokaz_przesylki.SelectedRows[0].Cells[1].Value.ToString();
            punkt_nadania.SelectedItem = pokaz_przesylki.SelectedRows[0].Cells[2].Value.ToString();
            imie_wys.Text = pokaz_przesylki.SelectedRows[0].Cells[3].Value.ToString();
            imie_odb.Text = pokaz_przesylki.SelectedRows[0].Cells[4].Value.ToString();
            adres.Text = pokaz_przesylki.SelectedRows[0].Cells[5].Value.ToString();
            tel_wys.Text = pokaz_przesylki.SelectedRows[0].Cells[6].Value.ToString();
            tel_odb.Text = pokaz_przesylki.SelectedRows[0].Cells[7].Value.ToString();
            rozmiar.SelectedItem = pokaz_przesylki.SelectedRows[0].Cells[8].Value.ToString();
            rodzaj.SelectedItem = pokaz_przesylki.SelectedRows[0].Cells[9].Value.ToString();
            status.SelectedItem = pokaz_przesylki.SelectedRows[0].Cells[10].Value.ToString();
            if (imie_wys.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(pokaz_przesylki.SelectedRows[0].Cells[0].Value.ToString());
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
