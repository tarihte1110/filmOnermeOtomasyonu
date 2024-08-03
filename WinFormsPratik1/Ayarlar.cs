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
using WinFormsPratik1;

namespace FilmOnerme
{
    public partial class Ayarlar : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader dr;

        public Ayarlar()
        {
            InitializeComponent();
        }
        public int id;
        AnaEkran ana = new AnaEkran();
        sifreYenile sifreYenileme = new sifreYenile();
        public void idAl(int id)
        {
            this.id = id;
        }
        public void formAl(AnaEkran ana)
        {
            this.ana = ana;
        }
        private void geriButonu_Click(object sender, EventArgs e)
        {
            ana.Show();
            this.Hide();
        }

        private void parolaButton_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=dbLogin.accdb");
            conn.Open();
            string eskiSifre = "";
            MessageBox.Show(id.ToString());
            cmd = new OleDbCommand($"SELECT * FROM Tablo1 WHERE kimlik={id} ", conn);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                eskiSifre = (string)dr["sifre"];

            }
            conn.Close();
            if (eskiPTextBox.Text.Trim() == eskiSifre && yeniPTextBox1.Text.Trim() == yeniPTextBox2.Text.Trim())
            {
                conn.Open();
                cmd.CommandText = $"UPDATE  Tablo1 SET sifre='{yeniPTextBox1.Text}' WHERE kimlik={id}";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Şifre başarıyla oluşturuldu. ");

            }
            else MessageBox.Show("Beklenmeyen bir hata oluştu", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        bool panelVisible = false;

        private void TogglePanelVisibility()
        {
            panel1.Visible = panelVisible;
            panelVisible = !panelVisible;
        }
        private void TogglePanelVisibility2()
        {
            panel2.Visible = panelVisible;
            panelVisible = !panelVisible;
        }
        private void pDegistirButton_Click(object sender, EventArgs e)
        {
            TogglePanelVisibility2();
        }

        private void kDegistirButton_Click(object sender, EventArgs e)
        {
            TogglePanelVisibility();
        }

        private void kAdiButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=dbLogin.accdb");
                cmd = new OleDbCommand();
                conn.Open();
                cmd.CommandText = $"UPDATE Tablo1 SET k_ad='{kAditextBox.Text.Trim()}' WHERE kimlik={id} ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu");
            }

        }

        private void hesapSilButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seçilen hesabı silmek istediğinizden emin misiniz?", "Hesap Silme", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbLogin.accdb"))
                {
                    conn.Open();

                    using (OleDbCommand cmd = new OleDbCommand($"DELETE FROM Tablo1 WHERE kimlik = {id}", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Hesabınız silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.Show();

                    conn.Close();
                }
            }

        }
    }
}
