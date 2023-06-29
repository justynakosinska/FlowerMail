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
    public partial class Dostawa : Form
    {
        public Dostawa()
        {
            InitializeComponent();
            ShowDelivery();
            GetId();
            GetParcel();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Justyna\Documents\PocztaKwiatowaBD.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowDelivery()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from dostawa", Con);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            pokaz_dostawy.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void GetName()
        {
            Con.Open();
            string Query = "select * from pracownicy where id_prac=" + numer_p.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                imie_prac.Text = dr["imie_prac"].ToString();
            }
            Con.Close();
        }
        private void GetId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from pracownicy", Con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_prac", typeof(int));
            dt.Load(dr);
            numer_p.ValueMember = "id_prac";
            numer_p.DataSource = dt;
            Con.Close();
        }
        private void GetParcel()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from przesylki", Con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_przesylki", typeof(int));
            dt.Load(dr);
            nr_paczki.ValueMember = "id_przesylki";
            nr_paczki.DataSource = dt;
            Con.Close();
        }
        private void Reset()
        {
            oplata.Text = "";
            imie_prac.Text = "";
            numer_p.SelectedIndex = -1;
            nr_paczki.SelectedIndex = -1;
        }
        private void Zapisz_Click(object sender, EventArgs e)
        {
            if (numer_p.SelectedIndex == -1 || imie_prac.Text == "" || oplata.Text == "")
            {
                MessageBox.Show("Brakujące informacje");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into dostawa(nr_paczki,data_d,numer_p,imie_p,oplata) values(@NP,@DD,@NRP,@IP,@O)", Con);
                    cmd.Parameters.AddWithValue("@NP", numer_p.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DD", data_d.Value.Date);
                    cmd.Parameters.AddWithValue("@NRP", nr_paczki.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@IP", imie_prac.Text);
                    cmd.Parameters.AddWithValue("@O", oplata.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dane dostawy wprowadzone");
                    Con.Close();
                    ShowDelivery();
                    //Reset();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void numer_p_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetName();
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
