namespace FlowerMail
{
    partial class Dostawa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dostawa));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            label9 = new Label();
            numer_p = new ComboBox();
            label5 = new Label();
            nr_paczki = new ComboBox();
            label4 = new Label();
            data_d = new DateTimePicker();
            label2 = new Label();
            oplata = new TextBox();
            label1 = new Label();
            imie_prac = new TextBox();
            panel6 = new Panel();
            Zapisz = new Bunifu.Framework.UI.BunifuThinButton2();
            pokaz_dostawy = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pokaz_dostawy).BeginInit();
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
            label7.Location = new Point(509, 103);
            label7.Name = "label7";
            label7.Size = new Size(96, 30);
            label7.TabIndex = 12;
            label7.Text = "Dostawa";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(numer_p);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(nr_paczki);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(data_d);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(oplata);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(imie_prac);
            panel3.Location = new Point(36, 530);
            panel3.Name = "panel3";
            panel3.Size = new Size(915, 123);
            panel3.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(27, 61);
            label9.Name = "label9";
            label9.Size = new Size(149, 18);
            label9.TabIndex = 13;
            label9.Text = "Numer pracownika";
            // 
            // numer_p
            // 
            numer_p.FormattingEnabled = true;
            numer_p.Location = new Point(27, 82);
            numer_p.Name = "numer_p";
            numer_p.Size = new Size(179, 23);
            numer_p.TabIndex = 12;
            numer_p.SelectionChangeCommitted += numer_p_SelectionChangeCommitted;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(484, 8);
            label5.Name = "label5";
            label5.Size = new Size(131, 18);
            label5.TabIndex = 9;
            label5.Text = "Numer przesyłki";
            // 
            // nr_paczki
            // 
            nr_paczki.FormattingEnabled = true;
            nr_paczki.Location = new Point(484, 29);
            nr_paczki.Name = "nr_paczki";
            nr_paczki.Size = new Size(179, 23);
            nr_paczki.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(263, 7);
            label4.Name = "label4";
            label4.Size = new Size(143, 18);
            label4.TabIndex = 7;
            label4.Text = "Data dostarczenia";
            // 
            // data_d
            // 
            data_d.Location = new Point(263, 28);
            data_d.Name = "data_d";
            data_d.Size = new Size(200, 23);
            data_d.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(690, 6);
            label2.Name = "label2";
            label2.Size = new Size(58, 18);
            label2.TabIndex = 3;
            label2.Text = "Opłata";
            // 
            // oplata
            // 
            oplata.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            oplata.Location = new Point(690, 27);
            oplata.Name = "oplata";
            oplata.Size = new Size(187, 27);
            oplata.TabIndex = 2;
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
            // 
            // imie_prac
            // 
            imie_prac.Enabled = false;
            imie_prac.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            imie_prac.Location = new Point(27, 27);
            imie_prac.Name = "imie_prac";
            imie_prac.Size = new Size(187, 27);
            imie_prac.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(Zapisz);
            panel6.Location = new Point(957, 530);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 123);
            panel6.TabIndex = 12;
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
            // pokaz_dostawy
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            pokaz_dostawy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            pokaz_dostawy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            pokaz_dostawy.ColumnHeadersHeight = 25;
            pokaz_dostawy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            pokaz_dostawy.Cursor = Cursors.IBeam;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            pokaz_dostawy.DefaultCellStyle = dataGridViewCellStyle3;
            pokaz_dostawy.GridColor = Color.FromArgb(231, 229, 255);
            pokaz_dostawy.Location = new Point(46, 45);
            pokaz_dostawy.Name = "pokaz_dostawy";
            pokaz_dostawy.RowHeadersVisible = false;
            pokaz_dostawy.RowTemplate.Height = 25;
            pokaz_dostawy.Size = new Size(823, 270);
            pokaz_dostawy.TabIndex = 14;
            pokaz_dostawy.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            pokaz_dostawy.ThemeStyle.AlternatingRowsStyle.Font = null;
            pokaz_dostawy.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            pokaz_dostawy.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            pokaz_dostawy.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            pokaz_dostawy.ThemeStyle.BackColor = Color.White;
            pokaz_dostawy.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            pokaz_dostawy.ThemeStyle.HeaderStyle.BackColor = Color.GreenYellow;
            pokaz_dostawy.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            pokaz_dostawy.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pokaz_dostawy.ThemeStyle.HeaderStyle.ForeColor = Color.Black;
            pokaz_dostawy.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            pokaz_dostawy.ThemeStyle.HeaderStyle.Height = 25;
            pokaz_dostawy.ThemeStyle.ReadOnly = false;
            pokaz_dostawy.ThemeStyle.RowsStyle.BackColor = Color.White;
            pokaz_dostawy.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            pokaz_dostawy.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pokaz_dostawy.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            pokaz_dostawy.ThemeStyle.RowsStyle.Height = 25;
            pokaz_dostawy.ThemeStyle.RowsStyle.SelectionBackColor = Color.Green;
            pokaz_dostawy.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pokaz_dostawy);
            panel2.Location = new Point(36, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 357);
            panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1107, 463);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Dostawa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 733);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(label7);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dostawa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dostawa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pokaz_dostawy).EndInit();
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
        private Panel panel3;
        private Label label5;
        private ComboBox nr_paczki;
        private Label label4;
        private DateTimePicker data_d;
        private Label label2;
        private TextBox oplata;
        private Label label1;
        private TextBox imie_prac;
        private Panel panel6;
        private Bunifu.Framework.UI.BunifuThinButton2 Zapisz;
        private Label label9;
        private ComboBox numer_p;
        private Guna.UI2.WinForms.Guna2DataGridView pokaz_dostawy;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}