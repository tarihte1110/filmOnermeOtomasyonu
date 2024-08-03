namespace FilmOnerme
{
    partial class AdminPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPaneli));
            adminGeri = new Button();
            filmLabel = new Label();
            uretimLabel = new Label();
            ımdbLabel = new Label();
            aciklamaLabel = new Label();
            uretimComboBox = new ComboBox();
            imdbTextBox = new TextBox();
            filmTextBox = new TextBox();
            aciklamaRichTextBox = new RichTextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ekleProgressBar = new ProgressBar();
            türLabel = new Label();
            türComboBox = new ComboBox();
            btnEkle = new Button();
            tabPage2 = new TabPage();
            silProgressBar = new ProgressBar();
            filmlerListBox = new ListBox();
            turLabel = new Label();
            türComboBox2 = new ComboBox();
            btnSil = new Button();
            adminGeri2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            fragmanLabel = new Label();
            fragmanTextBox = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // adminGeri
            // 
            adminGeri.BackColor = Color.Firebrick;
            adminGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            adminGeri.ForeColor = SystemColors.ControlLightLight;
            adminGeri.Location = new Point(683, 384);
            adminGeri.Name = "adminGeri";
            adminGeri.Size = new Size(94, 29);
            adminGeri.TabIndex = 0;
            adminGeri.Text = "Çıkış";
            adminGeri.UseVisualStyleBackColor = false;
            adminGeri.Click += adminGeri_Click;
            // 
            // filmLabel
            // 
            filmLabel.AutoSize = true;
            filmLabel.ForeColor = SystemColors.ButtonHighlight;
            filmLabel.Location = new Point(57, 35);
            filmLabel.Name = "filmLabel";
            filmLabel.Size = new Size(64, 20);
            filmLabel.TabIndex = 1;
            filmLabel.Text = "Film Adı";
            // 
            // uretimLabel
            // 
            uretimLabel.AutoSize = true;
            uretimLabel.ForeColor = SystemColors.ButtonHighlight;
            uretimLabel.Location = new Point(31, 96);
            uretimLabel.Name = "uretimLabel";
            uretimLabel.Size = new Size(90, 20);
            uretimLabel.TabIndex = 2;
            uretimLabel.Text = "Film Üretimi";
            // 
            // ımdbLabel
            // 
            ımdbLabel.AutoSize = true;
            ımdbLabel.ForeColor = SystemColors.ButtonHighlight;
            ımdbLabel.Location = new Point(328, 35);
            ımdbLabel.Name = "ımdbLabel";
            ımdbLabel.Size = new Size(86, 20);
            ımdbLabel.TabIndex = 3;
            ımdbLabel.Text = "IMDB Puanı";
            // 
            // aciklamaLabel
            // 
            aciklamaLabel.AutoSize = true;
            aciklamaLabel.ForeColor = SystemColors.ButtonHighlight;
            aciklamaLabel.Location = new Point(328, 125);
            aciklamaLabel.Name = "aciklamaLabel";
            aciklamaLabel.Size = new Size(112, 20);
            aciklamaLabel.TabIndex = 4;
            aciklamaLabel.Text = "Film Açıklaması";
            // 
            // uretimComboBox
            // 
            uretimComboBox.FormattingEnabled = true;
            uretimComboBox.Items.AddRange(new object[] { "Yerli", "Yabancı" });
            uretimComboBox.Location = new Point(135, 88);
            uretimComboBox.Name = "uretimComboBox";
            uretimComboBox.Size = new Size(151, 28);
            uretimComboBox.TabIndex = 5;
            // 
            // imdbTextBox
            // 
            imdbTextBox.Location = new Point(435, 32);
            imdbTextBox.Name = "imdbTextBox";
            imdbTextBox.Size = new Size(135, 27);
            imdbTextBox.TabIndex = 6;
            // 
            // filmTextBox
            // 
            filmTextBox.Location = new Point(135, 32);
            filmTextBox.Name = "filmTextBox";
            filmTextBox.Size = new Size(151, 27);
            filmTextBox.TabIndex = 7;
            // 
            // aciklamaRichTextBox
            // 
            aciklamaRichTextBox.Location = new Point(328, 157);
            aciklamaRichTextBox.Name = "aciklamaRichTextBox";
            aciklamaRichTextBox.Size = new Size(324, 147);
            aciklamaRichTextBox.TabIndex = 8;
            aciklamaRichTextBox.Text = "";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(793, 463);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(fragmanTextBox);
            tabPage1.Controls.Add(fragmanLabel);
            tabPage1.Controls.Add(ekleProgressBar);
            tabPage1.Controls.Add(türLabel);
            tabPage1.Controls.Add(türComboBox);
            tabPage1.Controls.Add(btnEkle);
            tabPage1.Controls.Add(aciklamaRichTextBox);
            tabPage1.Controls.Add(adminGeri);
            tabPage1.Controls.Add(uretimLabel);
            tabPage1.Controls.Add(uretimComboBox);
            tabPage1.Controls.Add(filmTextBox);
            tabPage1.Controls.Add(imdbTextBox);
            tabPage1.Controls.Add(ımdbLabel);
            tabPage1.Controls.Add(aciklamaLabel);
            tabPage1.Controls.Add(filmLabel);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(785, 430);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "FİLM EKLE";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ekleProgressBar
            // 
            ekleProgressBar.Location = new Point(103, 289);
            ekleProgressBar.Name = "ekleProgressBar";
            ekleProgressBar.Size = new Size(125, 25);
            ekleProgressBar.TabIndex = 12;
            // 
            // türLabel
            // 
            türLabel.AutoSize = true;
            türLabel.ForeColor = SystemColors.ButtonHighlight;
            türLabel.Location = new Point(42, 181);
            türLabel.Name = "türLabel";
            türLabel.Size = new Size(70, 20);
            türLabel.TabIndex = 11;
            türLabel.Text = "Film Türü";
            // 
            // türComboBox
            // 
            türComboBox.FormattingEnabled = true;
            türComboBox.Items.AddRange(new object[] { "Aksiyon", "Animasyon", "Belgesel", "Bilim-Kurgu", "Biyografi", "Drama", "Komedi", "Korku", "Romantik" });
            türComboBox.Location = new Point(135, 173);
            türComboBox.Name = "türComboBox";
            türComboBox.Size = new Size(151, 28);
            türComboBox.TabIndex = 10;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Black;
            btnEkle.ForeColor = SystemColors.ButtonHighlight;
            btnEkle.Location = new Point(309, 371);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 9;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(silProgressBar);
            tabPage2.Controls.Add(filmlerListBox);
            tabPage2.Controls.Add(turLabel);
            tabPage2.Controls.Add(türComboBox2);
            tabPage2.Controls.Add(btnSil);
            tabPage2.Controls.Add(adminGeri2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(785, 430);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "FİLM SİL";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // silProgressBar
            // 
            silProgressBar.Location = new Point(101, 276);
            silProgressBar.Name = "silProgressBar";
            silProgressBar.Size = new Size(119, 26);
            silProgressBar.TabIndex = 6;
            // 
            // filmlerListBox
            // 
            filmlerListBox.ForeColor = SystemColors.InactiveCaptionText;
            filmlerListBox.FormattingEnabled = true;
            filmlerListBox.ItemHeight = 20;
            filmlerListBox.Location = new Point(357, 54);
            filmlerListBox.Name = "filmlerListBox";
            filmlerListBox.Size = new Size(408, 264);
            filmlerListBox.TabIndex = 5;
            filmlerListBox.SelectedIndexChanged += filmlerListBox_SelectedIndexChanged_1;
            // 
            // turLabel
            // 
            turLabel.AutoSize = true;
            turLabel.ForeColor = SystemColors.ButtonHighlight;
            turLabel.Location = new Point(47, 72);
            turLabel.Name = "turLabel";
            turLabel.Size = new Size(70, 20);
            turLabel.TabIndex = 4;
            turLabel.Text = "Film Türü";
            // 
            // türComboBox2
            // 
            türComboBox2.FormattingEnabled = true;
            türComboBox2.Items.AddRange(new object[] { "Aksiyon", "Animasyon", "Belgesel", "Bilim-Kurgu", "Biyografi", "Drama", "Fantastik", "Komedi", "Korku", "Macera", "Romantik" });
            türComboBox2.Location = new Point(134, 64);
            türComboBox2.Name = "türComboBox2";
            türComboBox2.Size = new Size(161, 28);
            türComboBox2.TabIndex = 3;
            türComboBox2.SelectedIndexChanged += türComboBox2_SelectedIndexChanged_1;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Black;
            btnSil.ForeColor = SystemColors.ButtonHighlight;
            btnSil.Location = new Point(345, 372);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 2;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // adminGeri2
            // 
            adminGeri2.BackColor = Color.Firebrick;
            adminGeri2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            adminGeri2.ForeColor = SystemColors.ControlLightLight;
            adminGeri2.Location = new Point(683, 393);
            adminGeri2.Name = "adminGeri2";
            adminGeri2.Size = new Size(94, 29);
            adminGeri2.TabIndex = 1;
            adminGeri2.Text = "Çıkış";
            adminGeri2.UseVisualStyleBackColor = false;
            adminGeri2.Click += adminGeri2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // fragmanLabel
            // 
            fragmanLabel.AutoSize = true;
            fragmanLabel.ForeColor = SystemColors.ButtonHighlight;
            fragmanLabel.Location = new Point(328, 79);
            fragmanLabel.Name = "fragmanLabel";
            fragmanLabel.Size = new Size(101, 20);
            fragmanLabel.TabIndex = 13;
            fragmanLabel.Text = "Fragman Linki";
            // 
            // fragmanTextBox
            // 
            fragmanTextBox.Location = new Point(435, 76);
            fragmanTextBox.Name = "fragmanTextBox";
            fragmanTextBox.Size = new Size(184, 27);
            fragmanTextBox.TabIndex = 14;
            // 
            // AdminPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(793, 463);
            Controls.Add(tabControl1);
            DoubleBuffered = true;
            Name = "AdminPaneli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPaneli";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button adminGeri;
        private Label filmLabel;
        private Label uretimLabel;
        private Label ımdbLabel;
        private Label aciklamaLabel;
        private ComboBox uretimComboBox;
        private TextBox imdbTextBox;
        private TextBox filmTextBox;
        private RichTextBox aciklamaRichTextBox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button adminGeri2;
        private Button btnEkle;
        private ComboBox türComboBox;
        private Label türLabel;
        private Button btnSil;
        private ListBox filmlerListBox;
        private Label turLabel;
        private ComboBox türComboBox2;
        private ProgressBar ekleProgressBar;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar silProgressBar;
        private System.Windows.Forms.Timer timer2;
        private TextBox fragmanTextBox;
        private Label fragmanLabel;
    }
}