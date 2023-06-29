namespace FlowerMail
{
    partial class PrzesyłkiKwiatowe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrzesyłkiKwiatowe));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            panel6 = new Panel();
            Usun = new Bunifu.Framework.UI.BunifuThinButton2();
            Edytuj = new Bunifu.Framework.UI.BunifuThinButton2();
            Zapisz = new Bunifu.Framework.UI.BunifuThinButton2();
            panel3 = new Panel();
            id_wys = new ComboBox();
            label9 = new Label();
            imie_odb = new TextBox();
            label8 = new Label();
            imie_wys = new TextBox();
            label5 = new Label();
            punkt_nadania = new ComboBox();
            label4 = new Label();
            data_nadania = new DateTimePicker();
            label3 = new Label();
            tel_odb = new TextBox();
            label2 = new Label();
            adres = new TextBox();
            label1 = new Label();
            label10 = new Label();
            tel_wys = new TextBox();
            label12 = new Label();
            label13 = new Label();
            rodzaj = new ComboBox();
            label11 = new Label();
            status = new ComboBox();
            pokaz_przesylki = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2 = new Panel();
            rozmiar = new ComboBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pokaz_przesylki).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.YellowGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 100);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cancel_button;
            pictureBox1.Location = new Point(1110, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(313, 38);
            label6.Name = "label6";
            label6.Size = new Size(538, 30);
            label6.TabIndex = 10;
            label6.Text = "System do zarządzania pocztą kwiatową dla kwiaciarni";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(488, 103);
            label7.Name = "label7";
            label7.Size = new Size(193, 30);
            label7.TabIndex = 12;
            label7.Text = "Przesyłki kwiatowe";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(Usun);
            panel6.Controls.Add(Edytuj);
            panel6.Controls.Add(Zapisz);
            panel6.Location = new Point(922, 527);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 123);
            panel6.TabIndex = 15;
            // 
            // Usun
            // 
            Usun.ActiveBorderThickness = 1;
            Usun.ActiveCornerRadius = 20;
            Usun.ActiveFillColor = Color.SeaGreen;
            Usun.ActiveForecolor = Color.White;
            Usun.ActiveLineColor = Color.SeaGreen;
            Usun.BackColor = Color.White;
            Usun.BackgroundImage = (Image)resources.GetObject("Usun.BackgroundImage");
            Usun.ButtonText = "Usuń";
            Usun.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Usun.ForeColor = Color.SeaGreen;
            Usun.IdleBorderThickness = 1;
            Usun.IdleCornerRadius = 20;
            Usun.IdleFillColor = Color.GreenYellow;
            Usun.IdleForecolor = Color.Black;
            Usun.IdleLineColor = Color.DarkGreen;
            Usun.Location = new Point(18, 80);
            Usun.Margin = new Padding(5);
            Usun.Name = "Usun";
            Usun.Size = new Size(164, 35);
            Usun.TabIndex = 2;
            Usun.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Edytuj
            // 
            Edytuj.ActiveBorderThickness = 1;
            Edytuj.ActiveCornerRadius = 20;
            Edytuj.ActiveFillColor = Color.SeaGreen;
            Edytuj.ActiveForecolor = Color.White;
            Edytuj.ActiveLineColor = Color.SeaGreen;
            Edytuj.BackColor = Color.White;
            Edytuj.BackgroundImage = (Image)resources.GetObject("Edytuj.BackgroundImage");
            Edytuj.ButtonText = "Edytuj";
            Edytuj.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Edytuj.ForeColor = Color.SeaGreen;
            Edytuj.IdleBorderThickness = 1;
            Edytuj.IdleCornerRadius = 20;
            Edytuj.IdleFillColor = Color.GreenYellow;
            Edytuj.IdleForecolor = Color.Black;
            Edytuj.IdleLineColor = Color.DarkGreen;
            Edytuj.Location = new Point(18, 44);
            Edytuj.Margin = new Padding(5);
            Edytuj.Name = "Edytuj";
            Edytuj.Size = new Size(164, 35);
            Edytuj.TabIndex = 1;
            Edytuj.TextAlign = ContentAlignment.MiddleCenter;
            Edytuj.Click += Edytuj_Click;
            // 
            // Zapisz
            // 
            Zapisz.ActiveBorderThickness = 1;
            Zapisz.ActiveCornerRadius = 20;
            Zapisz.ActiveFillColor = Color.SeaGreen;
            Zapisz.ActiveForecolor = Color.White;
            Zapisz.ActiveLineColor = Color.SeaGreen;
            Zapisz.BackColor = Color.White;
            Zapisz.BackgroundImage = (Image)resources.GetObject("Zapisz.BackgroundImage");
            Zapisz.ButtonText = "Zapisz";
            Zapisz.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Zapisz.ForeColor = Color.SeaGreen;
            Zapisz.IdleBorderThickness = 1;
            Zapisz.IdleCornerRadius = 20;
            Zapisz.IdleFillColor = Color.GreenYellow;
            Zapisz.IdleForecolor = Color.Black;
            Zapisz.IdleLineColor = Color.DarkGreen;
            Zapisz.Location = new Point(17, 8);
            Zapisz.Margin = new Padding(5);
            Zapisz.Name = "Zapisz";
            Zapisz.Size = new Size(164, 35);
            Zapisz.TabIndex = 0;
            Zapisz.TextAlign = ContentAlignment.MiddleCenter;
            Zapisz.Click += Zapisz_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(id_wys);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(imie_odb);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(imie_wys);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(punkt_nadania);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(data_nadania);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(tel_odb);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(adres);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 527);
            panel3.Name = "panel3";
            panel3.Size = new Size(915, 123);
            panel3.TabIndex = 16;
            // 
            // id_wys
            // 
            id_wys.FormattingEnabled = true;
            id_wys.Items.AddRange(new object[] { "kobieta", "mężczyzna" });
            id_wys.Location = new Point(27, 27);
            id_wys.Name = "id_wys";
            id_wys.Size = new Size(179, 23);
            id_wys.TabIndex = 14;
            id_wys.SelectionChangeCommitted += id_wys_SelectionChangeCommitted;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(488, 8);
            label9.Name = "label9";
            label9.Size = new Size(111, 18);
            label9.TabIndex = 13;
            label9.Text = "Imię odbiorcy";
            // 
            // imie_odb
            // 
            imie_odb.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            imie_odb.Location = new Point(488, 29);
            imie_odb.Name = "imie_odb";
            imie_odb.Size = new Size(187, 27);
            imie_odb.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(241, 63);
            label8.Name = "label8";
            label8.Size = new Size(148, 18);
            label8.TabIndex = 11;
            label8.Text = "Imię wysyłającego";
            // 
            // imie_wys
            // 
            imie_wys.Enabled = false;
            imie_wys.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            imie_wys.Location = new Point(241, 84);
            imie_wys.Name = "imie_wys";
            imie_wys.Size = new Size(179, 27);
            imie_wys.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(241, 6);
            label5.Name = "label5";
            label5.Size = new Size(97, 18);
            label5.TabIndex = 9;
            label5.Text = "Kwiaciarnia";
            label5.Click += label5_Click;
            // 
            // punkt_nadania
            // 
            punkt_nadania.FormattingEnabled = true;
            punkt_nadania.Items.AddRange(new object[] { "ul.Dębicka 4", "ul.Krakowska 31", "ul.Rzeszowska 25a" });
            punkt_nadania.Location = new Point(241, 27);
            punkt_nadania.Name = "punkt_nadania";
            punkt_nadania.Size = new Size(179, 23);
            punkt_nadania.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 63);
            label4.Name = "label4";
            label4.Size = new Size(179, 18);
            label4.TabIndex = 7;
            label4.Text = "Data nadania przesyłki";
            // 
            // data_nadania
            // 
            data_nadania.Location = new Point(27, 84);
            data_nadania.Name = "data_nadania";
            data_nadania.Size = new Size(200, 23);
            data_nadania.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(494, 59);
            label3.Name = "label3";
            label3.Size = new Size(130, 18);
            label3.TabIndex = 5;
            label3.Text = "telefon odbiorcy";
            // 
            // tel_odb
            // 
            tel_odb.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tel_odb.Location = new Point(494, 80);
            tel_odb.Name = "tel_odb";
            tel_odb.Size = new Size(187, 27);
            tel_odb.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(690, 6);
            label2.Name = "label2";
            label2.Size = new Size(51, 18);
            label2.TabIndex = 3;
            label2.Text = "Adres";
            // 
            // adres
            // 
            adres.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            adres.Location = new Point(690, 27);
            adres.Multiline = true;
            adres.Name = "adres";
            adres.Size = new Size(187, 80);
            adres.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 6);
            label1.Name = "label1";
            label1.Size = new Size(130, 18);
            label1.TabIndex = 1;
            label1.Text = "Id wysyłającego";
            label1.Click += label1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(985, 156);
            label10.Name = "label10";
            label10.Size = new Size(131, 18);
            label10.TabIndex = 18;
            label10.Text = "telefon nadawcy";
            // 
            // tel_wys
            // 
            tel_wys.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tel_wys.Location = new Point(985, 177);
            tel_wys.Name = "tel_wys";
            tel_wys.Size = new Size(187, 27);
            tel_wys.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(985, 228);
            label12.Name = "label12";
            label12.Size = new Size(143, 18);
            label12.TabIndex = 22;
            label12.Text = "Rozmiar przesyłki";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(985, 311);
            label13.Name = "label13";
            label13.Size = new Size(132, 18);
            label13.TabIndex = 15;
            label13.Text = "Rodzaj przesyłki";
            // 
            // rodzaj
            // 
            rodzaj.FormattingEnabled = true;
            rodzaj.Items.AddRange(new object[] { "bukiet", "flower box", "kosz z kwiatami", "zestaw prezentowy" });
            rodzaj.Location = new Point(985, 332);
            rodzaj.Name = "rodzaj";
            rodzaj.Size = new Size(179, 23);
            rodzaj.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(985, 379);
            label11.Name = "label11";
            label11.Size = new Size(56, 18);
            label11.TabIndex = 24;
            label11.Text = "Status";
            // 
            // status
            // 
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "przesyłka w trakcie doręczania", "przesyłka doręczona" });
            status.Location = new Point(985, 400);
            status.Name = "status";
            status.Size = new Size(179, 23);
            status.TabIndex = 23;
            // 
            // pokaz_przesylki
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            pokaz_przesylki.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            pokaz_przesylki.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            pokaz_przesylki.ColumnHeadersHeight = 25;
            pokaz_przesylki.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            pokaz_przesylki.Cursor = Cursors.IBeam;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            pokaz_przesylki.DefaultCellStyle = dataGridViewCellStyle3;
            pokaz_przesylki.GridColor = Color.FromArgb(231, 229, 255);
            pokaz_przesylki.Location = new Point(46, 45);
            pokaz_przesylki.Name = "pokaz_przesylki";
            pokaz_przesylki.RowHeadersVisible = false;
            pokaz_przesylki.RowTemplate.Height = 25;
            pokaz_przesylki.Size = new Size(823, 270);
            pokaz_przesylki.TabIndex = 14;
            pokaz_przesylki.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            pokaz_przesylki.ThemeStyle.AlternatingRowsStyle.Font = null;
            pokaz_przesylki.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            pokaz_przesylki.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            pokaz_przesylki.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            pokaz_przesylki.ThemeStyle.BackColor = Color.White;
            pokaz_przesylki.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            pokaz_przesylki.ThemeStyle.HeaderStyle.BackColor = Color.GreenYellow;
            pokaz_przesylki.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            pokaz_przesylki.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pokaz_przesylki.ThemeStyle.HeaderStyle.ForeColor = Color.Black;
            pokaz_przesylki.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            pokaz_przesylki.ThemeStyle.HeaderStyle.Height = 25;
            pokaz_przesylki.ThemeStyle.ReadOnly = false;
            pokaz_przesylki.ThemeStyle.RowsStyle.BackColor = Color.White;
            pokaz_przesylki.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            pokaz_przesylki.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pokaz_przesylki.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            pokaz_przesylki.ThemeStyle.RowsStyle.Height = 25;
            pokaz_przesylki.ThemeStyle.RowsStyle.SelectionBackColor = Color.Green;
            pokaz_przesylki.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            pokaz_przesylki.CellContentClick += pokaz_przesylki_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pokaz_przesylki);
            panel2.Location = new Point(27, 147);
            panel2.Name = "panel2";
            panel2.Size = new Size(915, 361);
            panel2.TabIndex = 25;
            // 
            // rozmiar
            // 
            rozmiar.FormattingEnabled = true;
            rozmiar.Items.AddRange(new object[] { "mała", "średnia", "duża" });
            rozmiar.Location = new Point(985, 249);
            rozmiar.Name = "rozmiar";
            rozmiar.Size = new Size(179, 23);
            rozmiar.TabIndex = 26;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(985, 448);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // PrzesyłkiKwiatowe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 733);
            Controls.Add(pictureBox2);
            Controls.Add(rozmiar);
            Controls.Add(panel2);
            Controls.Add(label11);
            Controls.Add(status);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(rodzaj);
            Controls.Add(label10);
            Controls.Add(tel_wys);
            Controls.Add(panel3);
            Controls.Add(panel6);
            Controls.Add(label7);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PrzesyłkiKwiatowe";
            Text = "PrzesyłkiKwiatowe";
            Load += PrzesyłkiKwiatowe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pokaz_przesylki).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
        private Panel panel6;
        private Bunifu.Framework.UI.BunifuThinButton2 Usun;
        private Bunifu.Framework.UI.BunifuThinButton2 Edytuj;
        private Bunifu.Framework.UI.BunifuThinButton2 Zapisz;
        private Panel panel3;
        private Label label5;
        private ComboBox punkt_nadania;
        private Label label4;
        private DateTimePicker data_nadania;
        private Label label3;
        private TextBox tel_odb;
        private Label label2;
        private TextBox adres;
        private Label label1;
        private Label label8;
        private TextBox imie_wys;
        private Label label9;
        private TextBox imie_odb;
        private Label label10;
        private TextBox tel_wys;
        private Label label12;
        private Label label13;
        private ComboBox rodzaj;
        private Label label11;
        private ComboBox status;
        private Guna.UI2.WinForms.Guna2DataGridView pokaz_przesylki;
        private Panel panel2;
        private ComboBox id_wys;
        private ComboBox rozmiar;
        private PictureBox pictureBox2;
    }
}