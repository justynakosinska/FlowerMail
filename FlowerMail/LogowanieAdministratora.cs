using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerMail
{
    public partial class LogowanieAdministratora : Form
    {
        public LogowanieAdministratora()
        {
            InitializeComponent();
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            if (haslo.Text == "")
            {
                MessageBox.Show("Wprowadź hasło");
            }
            else if (haslo.Text == "123")
            {
                Pracownicy Obj = new Pracownicy();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nieprawidłowe hasło");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Logowanie Obj = new Logowanie();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
