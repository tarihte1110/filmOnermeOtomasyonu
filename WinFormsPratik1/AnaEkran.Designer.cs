namespace FilmOnerme
{
    partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            AraBtn = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            label6 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            adminButonu = new Button();
            ayarLinkLabel = new LinkLabel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            panel2 = new Panel();
            favEkleButon3 = new Button();
            favEkleButon2 = new Button();
            favEkleButon1 = new Button();
            pictureBox3 = new PictureBox();
            favButonu = new Button();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(76, 42);
            label1.Name = "label1";
            label1.Size = new Size(142, 28);
            label1.TabIndex = 0;
            label1.Text = "Film Türü ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Korku", "Aksiyon", "Biyograf" });
            listBox1.Location = new Point(406, 100);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(155, 24);
            listBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 148);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 0;
            label2.Text = "Film Türü";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Aksiyon", "Animasyon", "Belgesel", "Bilim-Kurgu", "Biyografi", "Drama", "Komedi", "Korku", "Romantik" });
            comboBox1.Location = new Point(12, 176);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 239);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 2;
            label3.Text = "Üretimi";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(21, 274);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 27);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Yerli";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(99, 271);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(89, 27);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Yabancı";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(813, 536);
            button1.Name = "button1";
            button1.Size = new Size(64, 28);
            button1.TabIndex = 5;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // AraBtn
            // 
            AraBtn.BackColor = Color.Maroon;
            AraBtn.Dock = DockStyle.Bottom;
            AraBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AraBtn.ForeColor = SystemColors.Control;
            AraBtn.Location = new Point(0, 527);
            AraBtn.Name = "AraBtn";
            AraBtn.Size = new Size(206, 40);
            AraBtn.TabIndex = 6;
            AraBtn.Text = "ARA";
            AraBtn.UseVisualStyleBackColor = false;
            AraBtn.Click += AraBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(AraBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(radioButton2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 567);
            panel1.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Controls.Add(radioButton3);
            panel4.Controls.Add(radioButton4);
            panel4.Controls.Add(radioButton5);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(11, 329);
            panel4.Name = "panel4";
            panel4.Size = new Size(195, 78);
            panel4.TabIndex = 6;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(18, 49);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(40, 29);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "1";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton4.Location = new Point(77, 49);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(43, 29);
            radioButton4.TabIndex = 7;
            radioButton4.TabStop = true;
            radioButton4.Text = "2";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton5.Location = new Point(140, 50);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(43, 29);
            radioButton5.TabIndex = 8;
            radioButton5.TabStop = true;
            radioButton5.Text = "3";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(186, 23);
            label6.TabIndex = 6;
            label6.Text = "Listelenecek Film Sayısı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 92);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 6;
            label4.Text = "* FİLTRELER ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(adminButonu);
            panel3.Controls.Add(ayarLinkLabel);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 89);
            panel3.TabIndex = 6;
            // 
            // adminButonu
            // 
            adminButonu.BackColor = Color.LightCoral;
            adminButonu.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            adminButonu.Location = new Point(107, 55);
            adminButonu.Name = "adminButonu";
            adminButonu.Size = new Size(96, 31);
            adminButonu.TabIndex = 11;
            adminButonu.Text = "Admin Mod";
            adminButonu.UseVisualStyleBackColor = false;
            adminButonu.Click += AdminButonu_Click;
            // 
            // ayarLinkLabel
            // 
            ayarLinkLabel.AutoSize = true;
            ayarLinkLabel.LinkColor = Color.Black;
            ayarLinkLabel.Location = new Point(38, 55);
            ayarLinkLabel.Name = "ayarLinkLabel";
            ayarLinkLabel.Size = new Size(56, 20);
            ayarLinkLabel.TabIndex = 9;
            ayarLinkLabel.TabStop = true;
            ayarLinkLabel.Text = "Ayarlar";
            ayarLinkLabel.VisitedLinkColor = Color.FromArgb(192, 0, 0);
            ayarLinkLabel.LinkClicked += ayarLinkLabel_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(56, 9);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.GhostWhite;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 49);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(9, 458);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(185, 27);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "IMDB'ye Göre Sırala";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(favEkleButon3);
            panel2.Controls.Add(favEkleButon2);
            panel2.Controls.Add(favEkleButon1);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(favButonu);
            panel2.Controls.Add(linkLabel3);
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(206, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(880, 567);
            panel2.TabIndex = 8;
            // 
            // favEkleButon3
            // 
            favEkleButon3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            favEkleButon3.Location = new Point(175, 307);
            favEkleButon3.Name = "favEkleButon3";
            favEkleButon3.Size = new Size(32, 34);
            favEkleButon3.TabIndex = 13;
            favEkleButon3.Text = "+";
            favEkleButon3.UseVisualStyleBackColor = true;
            favEkleButon3.Click += favEkleButon3_Click;
            // 
            // favEkleButon2
            // 
            favEkleButon2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            favEkleButon2.Location = new Point(175, 268);
            favEkleButon2.Name = "favEkleButon2";
            favEkleButon2.Size = new Size(32, 33);
            favEkleButon2.TabIndex = 12;
            favEkleButon2.Text = "+";
            favEkleButon2.UseVisualStyleBackColor = true;
            favEkleButon2.Click += favEkleButon2_Click;
            // 
            // favEkleButon1
            // 
            favEkleButon1.BackColor = Color.White;
            favEkleButon1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            favEkleButon1.Location = new Point(175, 226);
            favEkleButon1.Name = "favEkleButon1";
            favEkleButon1.Size = new Size(32, 36);
            favEkleButon1.TabIndex = 11;
            favEkleButon1.Text = "+";
            favEkleButon1.UseVisualStyleBackColor = false;
            favEkleButon1.Click += favEkleButon1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.RoyalBlue;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(730, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // favButonu
            // 
            favButonu.BackColor = Color.RoyalBlue;
            favButonu.BackgroundImageLayout = ImageLayout.Stretch;
            favButonu.FlatAppearance.BorderColor = Color.Blue;
            favButonu.FlatStyle = FlatStyle.Flat;
            favButonu.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            favButonu.ForeColor = SystemColors.ButtonHighlight;
            favButonu.Location = new Point(757, 12);
            favButonu.Name = "favButonu";
            favButonu.Size = new Size(111, 37);
            favButonu.TabIndex = 9;
            favButonu.Text = "FAVORİLER";
            favButonu.UseVisualStyleBackColor = false;
            favButonu.Click += favButonu_Click;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.Transparent;
            linkLabel3.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(235, 313);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(0, 23);
            linkLabel3.TabIndex = 8;
            linkLabel3.Click += linkLabel3_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(235, 276);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(0, 23);
            linkLabel2.TabIndex = 7;
            linkLabel2.Click += linkLabel2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.ForeColor = SystemColors.ActiveCaptionText;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(235, 233);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 23);
            linkLabel1.TabIndex = 6;
            linkLabel1.Click += linkLabel1_Click;
            // 
            // AnaEkran
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1086, 567);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AnaEkran";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AnaEkran_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Button AraBtn;
        private Panel panel1;
        private Panel panel2;
        private CheckBox checkBox1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Label label6;
        private Panel panel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
        private LinkLabel ayarLinkLabel;
        private Button favButonu;
        private PictureBox pictureBox3;
        private Button adminButonu;
        private Button favEkleButon3;
        private Button favEkleButon2;
        private Button favEkleButon1;
    }
}