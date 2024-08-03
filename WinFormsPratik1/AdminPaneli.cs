using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FilmOnerme
{
    public partial class AdminPaneli : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=fillmOneri.accdb");
        OleDbCommand cmd;
        OleDbDataReader dr;

        private string tablo = "";
        private string FilmAd = "";


        AnaEkran ana = new AnaEkran();
        public AdminPaneli()
        {
            InitializeComponent();
        }
        public void formAl(AnaEkran ana)
        {
            this.ana = ana;
        }

        private void adminGeri_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Admin panelinden çıkmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ana.Show();
                this.Hide();
            }

        }

        private void adminGeri2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Admin panelinden çıkmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ana.Show();
                this.Hide();
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string filmAd = filmTextBox.Text;
                string uretim = uretimComboBox.Text;
                string imdb = imdbTextBox.Text;
                string aciklama = aciklamaRichTextBox.Text;
                string fragman=fragmanTextBox.Text;
                tablo = türComboBox.Text;

                string sorgu = $"INSERT INTO {tablo} (Film, Uretim, IMDB, Aciklama,Fragman) VALUES (@Film, @Uretim, @IMDB, @Aciklama,@Fragman)";


                conn.Open();

                cmd = new OleDbCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@Film", filmAd);
                cmd.Parameters.AddWithValue("@Uretim", uretim);
                cmd.Parameters.AddWithValue("@IMDB", imdb);
                cmd.Parameters.AddWithValue("@Aciklama", aciklama);
                cmd.Parameters.AddWithValue("@Fragman", fragman);

                ekleProgressBar.Value = 0;
                ekleProgressBar.Maximum = 3;

                timer1.Interval = 1000;
                timer1.Start(); // Timer'ı başlat

                cmd.ExecuteNonQuery();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }
        string tabloAdi = "";
        private void türComboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                tabloAdi = türComboBox2.Text;

                if (!string.IsNullOrEmpty(tabloAdi))
                {
                    string sorgu = $"SELECT * FROM {tabloAdi}";
                    conn.Open();
                    cmd = new OleDbCommand(sorgu, conn);
                    dr = cmd.ExecuteReader();

                    filmlerListBox.Items.Clear();
                    while (dr.Read())
                    {
                        filmlerListBox.Items.Add((string)dr["Film"]);
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void filmlerListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (filmlerListBox.SelectedItems.Count > 0)
            {
                FilmAd = filmlerListBox.SelectedItems[0].ToString();
            }
            else
            {
                FilmAd = "";
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(FilmAd))
                {
                    if (MessageBox.Show("Seçilen filmi silmek istediğinizden emin misiniz?", "Film Silme", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        conn.Close();
                        string sorgu = $"DELETE FROM {tabloAdi} WHERE Film = @Film";
                        conn.Open();
                        cmd = new OleDbCommand(sorgu, conn);
                        cmd.Parameters.AddWithValue("@Film", FilmAd);
                        silProgressBar.Value = 0;
                        silProgressBar.Maximum = 3;

                        timer2.Interval = 1000;
                        timer2.Start();

                        cmd.ExecuteNonQuery();

                        conn.Close();


                        // ListBox'ı güncellemek için
                        filmlerListBox.Items.Clear();

                        // ListBox'ı tekrar doldurmak için
                        türComboBox2_SelectedIndexChanged_1(this, EventArgs.Empty);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ekleProgressBar.Value++;

            // ProgressBar dolarsa timer'ı durdur ve MessageBox göster
            if (ekleProgressBar.Value == ekleProgressBar.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("Film eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ekleProgressBar.Value = 0; // ProgressBar'ı sıfırla
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            silProgressBar.Value++;

            // ProgressBar dolarsa timer'ı durdur ve MessageBox göster
            if (silProgressBar.Value == silProgressBar.Maximum)
            {
                timer2.Stop();
                MessageBox.Show("Film silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                silProgressBar.Value = 0; // ProgressBar'ı sıfırla
            }
        }

    }
}
