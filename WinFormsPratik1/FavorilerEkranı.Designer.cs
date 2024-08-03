namespace FilmOnerme
{
    partial class FavorilerEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavorilerEkranı));
            button1 = new Button();
            favorilerListBox = new ListBox();
            silButonu = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(804, 512);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // favorilerListBox
            // 
            favorilerListBox.BackColor = Color.Black;
            favorilerListBox.ForeColor = SystemColors.InactiveBorder;
            favorilerListBox.FormattingEnabled = true;
            favorilerListBox.ItemHeight = 20;
            favorilerListBox.Location = new Point(59, 35);
            favorilerListBox.Name = "favorilerListBox";
            favorilerListBox.Size = new Size(355, 464);
            favorilerListBox.TabIndex = 1;
            // 
            // silButonu
            // 
            silButonu.BackColor = Color.Maroon;
            silButonu.ForeColor = Color.WhiteSmoke;
            silButonu.Location = new Point(567, 364);
            silButonu.Name = "silButonu";
            silButonu.Size = new Size(191, 35);
            silButonu.TabIndex = 2;
            silButonu.Text = "Seçili Filmi Sil";
            silButonu.UseVisualStyleBackColor = false;
            silButonu.Click += silButonu_Click;
            // 
            // FavorilerEkranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(910, 553);
            Controls.Add(silButonu);
            Controls.Add(favorilerListBox);
            Controls.Add(button1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlLightLight;
            Name = "FavorilerEkranı";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FavorilerEkranı";
            Load += FavorilerEkranı_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox favorilerListBox;
        private Button silButonu;
    }
}