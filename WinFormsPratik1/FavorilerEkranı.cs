using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FilmOnerme
{
    public partial class FavorilerEkranı : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader dr;

        public FavorilerEkranı()
        {
            InitializeComponent();
        }

        AnaEkran anaEkran = new AnaEkran();
        public void formAl(AnaEkran anaEkran)
        {
            this.anaEkran = anaEkran;
        }

        public int id;
        public void idAl(int id)
        {
            this.id = id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            anaEkran.Show();
            Close();
        }
        private void FavorilerEkranı_Load(object sender, EventArgs e)
        {

            if (favorilerListBox.SelectedItem != null)
            {
                // Seçili bir eleman varsa butonu görünür yap
                silButonu.Visible = true;
            }
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=FavoriFilmler.accdb");
                string sorgu = $"SELECT * FROM FavoriFilmler WHERE id= {id}";
                conn.Open();
                cmd = new OleDbCommand(sorgu, conn);
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string favFilmAdi = dr["FavFilmler"].ToString();

                        // Aynı film daha önce eklenmemişse ekleyin
                        if (!favorilerListBox.Items.Contains(favFilmAdi))
                        {
                            favorilerListBox.Items.Add(favFilmAdi);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Favorilere eklenmiş film bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }

        }

        private void silButonu_Click(object sender, EventArgs e)
        {
            if (favorilerListBox.SelectedItem != null)
            {
                string secilenFilmAdi = favorilerListBox.SelectedItem.ToString();

                try
                {
                    using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=FavoriFilmler.accdb"))
                    {
                        con.Open();

                        // Seçilen filmi veritabanından silen SQL sorgusu
                        string sorgu = $"DELETE FROM FavoriFilmler WHERE FavFilmler = '{secilenFilmAdi}' AND id = {id}";

                        using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                        {
                            int etkilenenSatir = cmd.ExecuteNonQuery();

                            if (etkilenenSatir > 0)
                            {
                                // Silme işlemi başarılı olduysa listboxtan da kaldır
                                favorilerListBox.Items.Remove(secilenFilmAdi);
                                MessageBox.Show("Film başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Film silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir film seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
