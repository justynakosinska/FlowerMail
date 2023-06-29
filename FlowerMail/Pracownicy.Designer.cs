namespace FlowerMail
{
    partial class Pracownicy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pracownicy));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            panel2 = new Panel();
            pokaz_pracownikow = new Guna.UI2.WinForms.Guna2DataGridView();
            panel3 = new Panel();
            label8 = new Label();
            haslo_prac = new TextBox();
            label5 = new Label();
            plec_prac = new ComboBox();
            label4 = new Label();
            data_ur = new DateTimePicker();
            label3 = new Label();
            tel_prac = new TextBox();
            label2 = new Label();
            adres_prac = new TextBox();
            label1 = new Label();
            imie_prac = new TextBox();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            pictureBox2 = new PictureBox();
            panel6 = new Panel();
            Usun = new Bunifu.Framework.UI.BunifuThinButton2();
            Edytuj = new Bunifu.Framework.UI.BunifuThinButton2();
            Zapisz = new Bunifu.Framework.UI.BunifuThinButton2();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pokaz_pracownikow).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
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
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            label6.Click += label6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pokaz_pracownikow);
            panel2.Location = new Point(27, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(915, 361);
            panel2.TabIndex = 1;
            // 
            // pokaz_pracownikow
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            pokaz_pracownikow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            pokaz_pracownikow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            pokaz_pracownikow.ColumnHeadersHeight = 25;
            pokaz_pracownikow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            pokaz_pracownikow.Cursor = Cursors.IBeam;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            pokaz_pracownikow.DefaultCellStyle = dataGridViewCellStyle6;
            pokaz_pracownikow.GridColor = Color.FromArgb(231, 229, 255);
            pokaz_pracownikow.Location = new Point(46, 45);
            pokaz_pracownikow.Name = "pokaz_pracownikow";
            pokaz_pracownikow.RowHeadersVisible = false;
            pokaz_pracownikow.RowTemplate.Height = 25;
            pokaz_pracownikow.Size = new Size(823, 270);
            pokaz_pracownikow.TabIndex = 14;
            pokaz_pracownikow.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            pokaz_pracownikow.ThemeStyle.AlternatingRowsStyle.Font = null;
            pokaz_pracownikow.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            pokaz_pracownikow.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            pokaz_pracownikow.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            pokaz_pracownikow.ThemeStyle.BackColor = Color.White;
            pokaz_pracownikow.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            pokaz_pracownikow.ThemeStyle.HeaderStyle.BackColor = Color.GreenYellow;
            pokaz_pracownikow.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            pokaz_pracownikow.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pokaz_pracownikow.ThemeStyle.HeaderStyle.ForeColor = Color.Black;
            pokaz_pracownikow.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            pokaz_pracownikow.ThemeStyle.HeaderStyle.Height = 25;
            pokaz_pracownikow.ThemeStyle.ReadOnly = false;
            pokaz_pracownikow.ThemeStyle.RowsStyle.BackColor = Color.White;
            pokaz_pracownikow.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            pokaz_pracownikow.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pokaz_pracownikow.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            pokaz_pracownikow.ThemeStyle.RowsStyle.Height = 25;
            pokaz_pracownikow.ThemeStyle.RowsStyle.SelectionBackColor = Color.Green;
            pokaz_pracownikow.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            pokaz_pracownikow.CellContentClick += pokaz_pracownikow_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(haslo_prac);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(plec_prac);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(data_ur);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(tel_prac);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(adres_prac);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(imie_prac);
            panel3.Location = new Point(27, 538);
            panel3.Name = "panel3";
            panel3.Size = new Size(915, 123);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(263, 59);
            label8.Name = "label8";
            label8.Size = new Size(50, 18);
            label8.TabIndex = 11;
            label8.Text = "Hasło";
            // 
            // haslo_prac
            // 
            haslo_prac.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            haslo_prac.Location = new Point(263, 80);
            haslo_prac.Name = "haslo_prac";
            haslo_prac.Size = new Size(187, 27);
            haslo_prac.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(484, 8);
            label5.Name = "label5";
            label5.Size = new Size(40, 18);
            label5.TabIndex = 9;
            label5.Text = "Płeć";
            label5.Click += label5_Click;
            // 
            // plec_prac
            // 
            plec_prac.FormattingEnabled = true;
            plec_prac.Items.AddRange(new object[] { "kobieta", "mężczyzna" });
            plec_prac.Location = new Point(484, 29);
            plec_prac.Name = "plec_prac";
            plec_prac.Size = new Size(179, 23);
            plec_prac.TabIndex = 8;
            plec_prac.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(263, 7);
            label4.Name = "label4";
            label4.Size = new Size(121, 18);
            label4.TabIndex = 7;
            label4.Text = "Data urodzenia";
            label4.Click += label4_Click;
            // 
            // data_ur
            // 
            data_ur.Location = new Point(263, 28);
            data_ur.Name = "data_ur";
            data_ur.Size = new Size(200, 23);
            data_ur.TabIndex = 6;
            data_ur.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 59);
            label3.Name = "label3";
            label3.Size = new Size(124, 18);
            label3.TabIndex = 5;
            label3.Text = "Numer telefonu";
            label3.Click += label3_Click;
            // 
            // tel_prac
            // 
            tel_prac.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tel_prac.Location = new Point(27, 80);
            tel_prac.Name = "tel_prac";
            tel_prac.Size = new Size(187, 27);
            tel_prac.TabIndex = 4;
            tel_prac.TextChanged += textBox3_TextChanged;
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
            label2.Click += label2_Click;
            // 
            // adres_prac
            // 
            adres_prac.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            adres_prac.Location = new Point(690, 27);
            adres_prac.Multiline = true;
            adres_prac.Name = "adres_prac";
            adres_prac.Size = new Size(187, 80);
            adres_prac.TabIndex = 2;
            adres_prac.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 6);
            label1.Name = "label1";
            label1.Size = new Size(133, 18);
            label1.TabIndex = 1;
            label1.Text = "Imię pracownika";
            label1.Click += label1_Click;
            // 
            // imie_prac
            // 
            imie_prac.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            imie_prac.Location = new Point(27, 27);
            imie_prac.Name = "imie_prac";
            imie_prac.Size = new Size(187, 27);
            imie_prac.TabIndex = 0;
            imie_prac.TextChanged += textBox1_TextChanged;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 40;
            bunifuElipse1.TargetControl = this;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1110, 454);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(Usun);
            panel6.Controls.Add(Edytuj);
            panel6.Controls.Add(Zapisz);
            panel6.Location = new Point(961, 538);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 123);
            panel6.TabIndex = 5;
            panel6.Paint += panel6_Paint;
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
            Usun.Click += Usun_Click;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(511, 103);
            label7.Name = "label7";
            label7.Size = new Size(121, 30);
            label7.TabIndex = 11;
            label7.Text = "Pracownicy";
            label7.Click += label7_Click;
            // 
            // Pracownicy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 733);
            Controls.Add(pictureBox2);
            Controls.Add(label7);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pracownicy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Pracownicy_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pokaz_pracownikow).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Label label2;
        private TextBox adres_prac;
        private Label label1;
        private TextBox imie_prac;
        private DateTimePicker data_ur;
        private Label label3;
        private TextBox tel_prac;
        private Label label4;
        private Label label5;
        private ComboBox plec_prac;
        private Panel panel6;
        private Bunifu.Framework.UI.BunifuThinButton2 Zapisz;
        private Bunifu.Framework.UI.BunifuThinButton2 Edytuj;
        private Bunifu.Framework.UI.BunifuThinButton2 Usun;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label8;
        private TextBox haslo_prac;
        private Guna.UI2.WinForms.Guna2DataGridView pokaz_pracownikow;
        private PictureBox pictureBox2;
    }
}