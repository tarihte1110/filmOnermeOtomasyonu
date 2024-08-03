using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsPratik1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace FilmOnerme
{
    public partial class AnaEkran : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader dr;

        public string Label5Text
        {
            get { return label5.Text; }
            set { label5.Text = value; }
        }

        public string tabloAd;
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes) { Application.Exit(); }

        }

        private void AraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                linkLabel1.Text = "";
                linkLabel2.Text = "";
                linkLabel3.Text = "";

                string order = "ASC", top = "0";
                Random rnd = new Random();

                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=fillmOneri.accdb");
                conn.Open();

                cmd = new OleDbCommand();
                cmd.Connection = conn;

                string uretim = " ";
                if (radioButton1.Checked)
                {
                    uretim = "Yerli";
                }
                else if (radioButton2.Checked)
                {
                    uretim = "Yabanci";
                }

                int secilenFilmSayisi = 1;
                if (radioButton3.Checked)
                {
                    secilenFilmSayisi = 1;
                }
                else if (radioButton4.Checked)
                {
                    secilenFilmSayisi = 2;
                }
                else if (radioButton5.Checked)
                {
                    secilenFilmSayisi = 3;
                }

                if (checkBox1.Checked)
                {
                    order = "DESC";
                }

                if (radioButton5.Checked)
                {
                    top = "3";
                }
                else if (radioButton4.Checked)
                {
                    top = "2";
                }
                else if (radioButton3.Checked)
                {
                    top = "1";
                }

                for (int i = 1; i <= 3; i++)
                {
                    // Her butonu gizle
                    Control favButton = this.Controls.Find("favEkleButon" + i, true).FirstOrDefault();
                    if (favButton != null && favButton is Button)
                    {
                        ((Button)favButton).Visible = false;
                    }
                }

                if (radioButton3.Checked)
                {
                    // radioButton3 işaretli ise sadece favEkleButon1'i göster
                    favEkleButon1.Visible = true;
                }
                else if (radioButton4.Checked)
                {
                    // radioButton4 işaretli ise favEkleButon1 ve favEkleButon2'yi göster
                    favEkleButon1.Visible = true;
                    favEkleButon2.Visible = true;
                }
                else if (radioButton5.Checked)
                {
                    // radioButton5 işaretli ise hepsini göster
                    favEkleButon1.Visible = true;
                    favEkleButon2.Visible = true;
                    favEkleButon3.Visible = true;
                }

                string tablo = comboBox1.Text;

                string sorgu = checkBox1.Checked
                ? $"SELECT TOP {top} * FROM {tablo} WHERE Uretim = '{uretim}' ORDER BY rnd(Kimlik), Val(IMDB) {order}"
                : $"SELECT TOP {top} * FROM {tablo} WHERE Uretim = '{uretim}' ORDER BY rnd(Kimlik)";

                cmd.CommandText = sorgu;
                dr = cmd.ExecuteReader();

                DataTable filmTable = new DataTable();
                filmTable.Load(dr);

                var sıralıFilmler = checkBox1.Checked
                    ? filmTable.AsEnumerable().OrderByDescending(row => Convert.ToDouble(row["IMDB"]))
                    : filmTable.AsEnumerable().OrderBy(row => rnd.Next());

                // Bu liste her bir linkLabel için seçilen filmlerin Kimlik değerlerini tutar
                List<int> secilenFilmKimlikleri = new List<int>();

                for (int i = 0; i < secilenFilmSayisi && i < sıralıFilmler.Count(); i++)
                {
                    int secilenKimlik = sıralıFilmler.ElementAt(i).Field<int>("Kimlik");

                    // Eğer bu Kimlik daha önce seçildiyse farklı bir Kimlik seçer
                    while (secilenFilmKimlikleri.Contains(secilenKimlik))
                    {
                        secilenKimlik = sıralıFilmler.ElementAt(rnd.Next(sıralıFilmler.Count())).Field<int>("Kimlik");
                    }

                    secilenFilmKimlikleri.Add(secilenKimlik);

                    string secilenFilm = sıralıFilmler
                        .FirstOrDefault(row => row.Field<int>("Kimlik") == secilenKimlik)?
                        .Field<string>("Film");

                    if (i == 0)
                        linkLabel1.Text = secilenFilm;
                    else if (i == 1)
                        linkLabel2.Text = secilenFilm;
                    else if (i == 2)
                        linkLabel3.Text = secilenFilm;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            if (comboBox1.SelectedItem == null)
            {
                errorProvider1.SetError(comboBox1, "Lütfen bir seçim yapınız.");
            }
            else { errorProvider1.Clear(); }

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                errorProvider2.SetError(radioButton1, "Lütfen bir seçim yapınız.");
                errorProvider2.SetError(radioButton2, "Lütfen bir seçim yapınız.");
            }
            else
            {
                errorProvider2.Clear();
            }
        }
        public int id;
        public void idAl(int id)
        {
            this.id = id;
        }
        private void AnaEkran_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;

            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;

            favEkleButon1.Visible = false;
            favEkleButon2.Visible = false;
            favEkleButon3.Visible = false;

            adminButonu.Visible = false;

            if (id == 12)
            {
                adminButonu.Visible = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                radioButton3.Enabled = false;
            }
            else
            {
                radioButton3.Enabled = true;
            }
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            AciklamaEkranı aciklamaEkranı = new AciklamaEkranı();
            aciklamaEkranı.TabloAl(tabloAd);
            aciklamaEkranı.FilmAl(linkLabel2.Text);
            aciklamaEkranı.formAl(this);
            aciklamaEkranı.OpenTabPage(1);
            aciklamaEkranı.Show();
            this.Hide();
        }

        private void linkLabel3_Click(object sender, EventArgs e)
        {
            AciklamaEkranı aciklamaEkranı = new AciklamaEkranı();
            aciklamaEkranı.TabloAl(tabloAd);
            aciklamaEkranı.FilmAl(linkLabel3.Text);
            aciklamaEkranı.formAl(this);
            aciklamaEkranı.OpenTabPage(2);
            aciklamaEkranı.Show();
            this.Hide();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            AciklamaEkranı aciklamaEkranı = new AciklamaEkranı();
            aciklamaEkranı.TabloAl(tabloAd);
            aciklamaEkranı.FilmAl(linkLabel1.Text);
            aciklamaEkranı.formAl(this);
            aciklamaEkranı.Show();
            aciklamaEkranı.OpenTabPage(0);
            this.Hide();
        }

        private void ayarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
            ayarlar.formAl(this);
            ayarlar.idAl(id);
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabloAd = comboBox1.Text;
        }

        public string GetLinkLabel1Text()
        {
            return linkLabel1.Text;
        }

        public string GetLinkLabel2Text()
        {
            return linkLabel2.Text;
        }

        public string GetLinkLabel3Text()
        {
            return linkLabel3.Text;
        }

        public bool IsRadioButton3Checked()
        {
            return radioButton3.Checked;
        }

        public bool IsRadioButton4Checked()
        {
            return radioButton4.Checked;
        }

        public bool IsRadioButton5Checked()
        {
            return radioButton5.Checked;
        }

        private void favButonu_Click(object sender, EventArgs e)
        {
            FavorilerEkranı favEkranı = new FavorilerEkranı();
            favEkranı.idAl(id);
            favEkranı.Show();
            favEkranı.formAl(this);
            this.Hide();
        }

        private void AdminButonu_Click(object sender, EventArgs e)
        {
            AdminPaneli adminPaneli = new AdminPaneli();
            adminPaneli.Show();
            adminPaneli.formAl(this);
            this.Hide();
        }

        private void FavEkle(string filmAdi, Button favEkleButon)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=FavoriFilmler.accdb"))
            {
                con.Open();

                // Film daha önce eklenmiş mi kontrol et
                using (OleDbCommand kontrolCmd = new OleDbCommand($"SELECT COUNT(*) FROM FavoriFilmler WHERE FavFilmler = '{filmAdi}' AND id = {id}", con))
                {
                    int filmSayisi = (int)kontrolCmd.ExecuteScalar();

                    if (filmSayisi == 0)
                    {
                        // Eğer film daha önce eklenmemişse favorilere ekle
                        using (OleDbCommand cmd = new OleDbCommand($"INSERT INTO FavoriFilmler (FavFilmler, id) VALUES ('{filmAdi}', {id})", con))
                        {
                            cmd.ExecuteNonQuery();

                            // Favori eklendiğinde butonu görünmez yap
                            favEkleButon.Visible = false;

                            // Kullanıcıya bilgi mesajı göster
                            MessageBox.Show("Film favorilere başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        // Eğer film daha önce eklenmişse kullanıcıya uyarı mesajı göster
                        MessageBox.Show("Film zaten favorilerinizde ekli!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                con.Close();
            }
        }

        private void favEkleButon1_Click(object sender, EventArgs e)
        {
            FavEkle(linkLabel1.Text, favEkleButon1);
        }

        private void favEkleButon2_Click(object sender, EventArgs e)
        {
            FavEkle(linkLabel2.Text, favEkleButon2);
        }

        private void favEkleButon3_Click(object sender, EventArgs e)
        {
            FavEkle(linkLabel3.Text, favEkleButon3);
        }


    }
}
