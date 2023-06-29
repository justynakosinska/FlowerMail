namespace FlowerMail
{
    partial class LogowanieAdministratora
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogowanieAdministratora));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label6 = new Label();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            label4 = new Label();
            Zapisz = new Bunifu.Framework.UI.BunifuThinButton2();
            label3 = new Label();
            haslo = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.GreenYellow;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 100);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cancel_button;
            pictureBox1.Location = new Point(306, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(85, 30);
            label1.Name = "label1";
            label1.Size = new Size(174, 30);
            label1.TabIndex = 12;
            label1.Text = "Poczta kwiatowa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(107, 60);
            label6.Name = "label6";
            label6.Size = new Size(117, 30);
            label6.TabIndex = 11;
            label6.Text = "Logowanie";
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 40;
            bunifuElipse1.TargetControl = this;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(152, 265);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 19;
            label4.Text = "Wróć";
            label4.Click += label4_Click;
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
            Zapisz.ButtonText = "Zaloguj się";
            Zapisz.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Zapisz.ForeColor = Color.SeaGreen;
            Zapisz.IdleBorderThickness = 1;
            Zapisz.IdleCornerRadius = 20;
            Zapisz.IdleFillColor = Color.GreenYellow;
            Zapisz.IdleForecolor = Color.Black;
            Zapisz.IdleLineColor = Color.DarkGreen;
            Zapisz.Location = new Point(98, 225);
            Zapisz.Margin = new Padding(5);
            Zapisz.Name = "Zapisz";
            Zapisz.Size = new Size(164, 35);
            Zapisz.TabIndex = 18;
            Zapisz.TextAlign = ContentAlignment.MiddleCenter;
            Zapisz.Click += Zapisz_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(85, 169);
            label3.Name = "label3";
            label3.Size = new Size(48, 18);
            label3.TabIndex = 17;
            label3.Text = "hasło";
            // 
            // haslo
            // 
            haslo.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            haslo.Location = new Point(85, 190);
            haslo.Name = "haslo";
            haslo.PasswordChar = '*';
            haslo.Size = new Size(187, 27);
            haslo.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(107, 139);
            label2.Name = "label2";
            label2.Size = new Size(146, 30);
            label2.TabIndex = 14;
            label2.Text = "Administrator";
            // 
            // LogowanieAdministratora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(350, 371);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(Zapisz);
            Controls.Add(label3);
            Controls.Add(haslo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogowanieAdministratora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogowanieAdministratora";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Label label2;
        private Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 Zapisz;
        private Label label3;
        private TextBox haslo;
    }
}