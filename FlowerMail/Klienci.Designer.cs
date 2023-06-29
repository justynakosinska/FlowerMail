namespace FlowerMail
{
    partial class Klienci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Klienci));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            tel_klienta = new TextBox();
            label7 = new Label();
            panel6 = new Panel();
            Usun = new Bunifu.Framework.UI.BunifuThinButton2();
            Edytuj = new Bunifu.Framework.UI.BunifuThinButton2();
            Zapisz = new Bunifu.Framework.UI.BunifuThinButton2();
            label4 = new Label();
            data_ur = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            imie_klienta = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            adres_klienta = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            pokaz_klientow = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pokaz_klientow).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cancel_button;
            pictureBox1.Location = new Point(1096, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tel_klienta
            // 
            tel_klienta.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tel_klienta.Location = new Point(27, 80);
            tel_klienta.Name = "tel_klienta";
            tel_klienta.Size = new Size(187, 27);
            tel_klienta.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(496, 103);
            label7.Name = "label7";
            label7.Size = new Size(74, 30);
            label7.TabIndex = 18;
            label7.Text = "Klienci";
            label7.Click += label7_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(Usun);
            panel6.Controls.Add(Edytuj);
            panel6.Controls.Add(Zapisz);
            panel6.Location = new Point(946, 533);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 123);
            panel6.TabIndex = 17;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(263, 7);
            label4.Name = "label4";
            label4.Size = new Size(121, 18);
            label4.TabIndex = 7;
            label4.Text = "Data urodzenia";
            // 
            // data_ur
            // 
            data_ur.Location = new Point(263, 28);
            data_ur.Name = "data_ur";
            data_ur.Size = new Size(200, 23);
            data_ur.TabIndex = 6;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 6);
            label1.Name = "label1";
            label1.Size = new Size(98, 18);
            label1.TabIndex = 1;
            label1.Text = "Imię klienta";
            // 
            // imie_klienta
            // 
            imie_klienta.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            imie_klienta.Location = new Point(27, 27);
            imie_klienta.Name = "imie_klienta";
            imie_klienta.Size = new Size(187, 27);
            imie_klienta.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(data_ur);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(tel_klienta);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(adres_klienta);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(imie_klienta);
            panel3.Location = new Point(12, 533);
            panel3.Name = "panel3";
            panel3.Size = new Size(915, 123);
            panel3.TabIndex = 14;
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
            // adres_klienta
            // 
            adres_klienta.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            adres_klienta.Location = new Point(690, 27);
            adres_klienta.Multiline = true;
            adres_klienta.Name = "adres_klienta";
            adres_klienta.Size = new Size(187, 80);
            adres_klienta.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(301, 36);
            label6.Name = "label6";
            label6.Size = new Size(538, 30);
            label6.TabIndex = 10;
            label6.Text = "System do zarządzania pocztą kwiatową dla kwiaciarni";
            // 
            // panel1
            // 
            panel1.BackColor = Color.YellowGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1168, 100);
            panel1.TabIndex = 12;
            // 
            // pokaz_klientow
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            pokaz_klientow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            pokaz_klientow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            pokaz_klientow.ColumnHeadersHeight = 25;
            pokaz_klientow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            pokaz_klientow.Cursor = Cursors.IBeam;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            pokaz_klientow.DefaultCellStyle = dataGridViewCellStyle3;
            pokaz_klientow.GridColor = Color.FromArgb(231, 229, 255);
            pokaz_klientow.Location = new Point(21, 20);
            pokaz_klientow.Name = "pokaz_klientow";
            pokaz_klientow.RowHeadersVisible = false;
            pokaz_klientow.RowTemplate.Height = 25;
            pokaz_klientow.Size = new Size(823, 270);
            pokaz_klientow.TabIndex = 13;
            pokaz_klientow.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            pokaz_klientow.ThemeStyle.AlternatingRowsStyle.Font = null;
            pokaz_klientow.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            pokaz_klientow.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            pokaz_klientow.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            pokaz_klientow.ThemeStyle.BackColor = Color.White;
            pokaz_klientow.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            pokaz_klientow.ThemeStyle.HeaderStyle.BackColor = Color.GreenYellow;
            pokaz_klientow.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            pokaz_klientow.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pokaz_klientow.ThemeStyle.HeaderStyle.ForeColor = Color.Black;
            pokaz_klientow.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            pokaz_klientow.ThemeStyle.HeaderStyle.Height = 25;
            pokaz_klientow.ThemeStyle.ReadOnly = false;
            pokaz_klientow.ThemeStyle.RowsStyle.BackColor = Color.White;
            pokaz_klientow.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            pokaz_klientow.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pokaz_klientow.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            pokaz_klientow.ThemeStyle.RowsStyle.Height = 25;
            pokaz_klientow.ThemeStyle.RowsStyle.SelectionBackColor = Color.Green;
            pokaz_klientow.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            pokaz_klientow.CellContentClick += pokaz_klientow_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(pokaz_klientow);
            panel2.Location = new Point(60, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 315);
            panel2.TabIndex = 19;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1096, 465);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Klienci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 694);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Klienci";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Klienci";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pokaz_klientow).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tel_klienta;
        private Label label7;
        private Panel panel6;
        private Bunifu.Framework.UI.BunifuThinButton2 Usun;
        private Bunifu.Framework.UI.BunifuThinButton2 Edytuj;
        private Bunifu.Framework.UI.BunifuThinButton2 Zapisz;
        private Label label4;
        private DateTimePicker data_ur;
        private Label label3;
        private Label label1;
        private TextBox imie_klienta;
        private Panel panel3;
        private Label label2;
        private TextBox adres_klienta;
        private Label label6;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView pokaz_klientow;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}