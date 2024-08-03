namespace WinFormsPratik1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            button2 = new Button();
            label4 = new Label();
            button3 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(123, 123);
            label1.Name = "label1";
            label1.Size = new Size(149, 24);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(185, 196);
            label2.Name = "label2";
            label2.Size = new Size(87, 24);
            label2.TabIndex = 1;
            label2.Text = "Parola :";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Cursor = Cursors.Hand;
            textBox1.Location = new Point(294, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Cursor = Cursors.Hand;
            textBox2.Location = new Point(294, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(272, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(350, 248);
            button1.Name = "button1";
            button1.Size = new Size(112, 48);
            button1.TabIndex = 4;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(624, 401);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(192, 0, 0);
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.DarkGray;
            linkLabel1.DisabledLinkColor = Color.Black;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(593, 308);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(117, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Şifremi Unuttum";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.DarkGray;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(500, 226);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(135, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Parolayı Göster";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(462, 384);
            button2.Name = "button2";
            button2.Size = new Size(124, 37);
            button2.TabIndex = 8;
            button2.Text = "Kayıt Ol";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(448, 353);
            label4.Name = "label4";
            label4.Size = new Size(159, 23);
            label4.TabIndex = 9;
            label4.Text = "Hesabınız yok mu?";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(161, 325);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "ÇIKIŞ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(318, 46);
            label5.Name = "label5";
            label5.Size = new Size(218, 34);
            label5.TabIndex = 11;
            label5.Text = "HOŞGELDİNİZ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Ekranı";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
        private Button button2;
        private Label label4;
        private Button button3;
        private Label label5;
    }
}