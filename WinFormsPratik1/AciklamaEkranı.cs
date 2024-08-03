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
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace FilmOnerme
{
    public partial class AciklamaEkranı : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader dr;

        public string tablo;

        public string filmAdi;

        private WebView2 webView2;
        private string currentFragmanLink;

        public void FilmAl(string filmAdi)
        {
            this.filmAdi = filmAdi;
        }

        public void TabloAl(string tabloAdi)
        {
            tablo = tabloAdi;
        }

        public AciklamaEkranı()
        {
            InitializeComponent();

        }

        AnaEkran anaEkran = new AnaEkran();

        private void button1_Click(object sender, EventArgs e)
        {
            anaEkran.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anaEkran.Show();
            Close();
        }

        public void formAl(AnaEkran anaEkran)
        {
            this.anaEkran = anaEkran;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anaEkran.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            anaEkran.Show();
            Close();
        }

        public void OpenTabPage(int tabPageIndex)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[tabPageIndex];

            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=fillmOneri.accdb");
            conn.Open();

            //  Şu ana kadar seçilen tüm filmlerin isimlerini tutacak bir liste oluştur
            List<string> secilenFilmler = new List<string>();

            // Her bir tabPagetteki açıklamaları temizle
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                if (tabPage.Controls.Count > 0 && tabPage.Controls[0] is RichTextBox richTextBox)
                {
                    richTextBox.Clear();
                }
            }

            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                string labelXText = " ";
                if (i == 0)
                    labelXText = anaEkran.GetLinkLabel1Text();
                else if (i == 1)
                    labelXText = anaEkran.GetLinkLabel2Text();
                else if (i == 2)
                    labelXText = anaEkran.GetLinkLabel3Text();

                // Her bir tabPagetteki başlık kısmına seçilen film adını yazar
                tabControl1.TabPages[i].Text = labelXText;
                secilenFilmler.Add(labelXText); // Listeye eklenen her filmi takip et

                tabPage4.Text = "FRAGMANLAR";

                // sql sorgusunu oluşturur
                string sorgu = $"SELECT * FROM {tablo} WHERE Film = '{labelXText}' ";
                cmd = new OleDbCommand(sorgu, conn);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string aciklama = dr["Aciklama"].ToString();

                        // Her bir tabPagetteki RichTextBox'a açıklamayı yaz
                        if (tabControl1.TabPages[i].Controls.Count > 0 &&
                            tabControl1.TabPages[i].Controls[0] is RichTextBox richTextBox)
                        {
                            richTextBox.Text = aciklama;
                        }
                    }
                }

                dr.Close();
            }

            // Her bir tabPagette görüntülenen filmlerin listesini ana formdaki label'a yaz
            string label1Text = secilenFilmler.Count >= 1 ? secilenFilmler[0] : " ";
            string label2Text = secilenFilmler.Count >= 2 ? secilenFilmler[1] : " ";
            string label3Text = secilenFilmler.Count >= 3 ? secilenFilmler[2] : " ";

            conn.Close();
        }

        private void AciklamaEkranı_Load(object sender, EventArgs e)
        {
            if (anaEkran.IsRadioButton3Checked())
            {
                tabControl1.Controls.Remove(tabPage3);
                tabControl1.Controls.Remove(tabPage2);
            }
            if (anaEkran.IsRadioButton4Checked())
            {
                tabControl1.Controls.Remove(tabPage3);
            }

            // Her bir tabPagette görüntülenen filmlerin listesini ana formdaki label'a yaz
            label1.Text = anaEkran.GetLinkLabel1Text();
            label2.Text = anaEkran.GetLinkLabel2Text();
            label3.Text = anaEkran.GetLinkLabel3Text();

            linkLabel1.Text = "Fragmanı Aç";
            linkLabel2.Text = "Fragmanı Aç";
            linkLabel3.Text = "Fragmanı Aç";

        }


        private void DoldurFragmanLinkleri(string filmAdi)
        {
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=fillmOneri.accdb");
                conn.Open();

                string sorgu = $"SELECT Fragman FROM {tablo} WHERE Film = '{filmAdi}'";
                cmd = new OleDbCommand(sorgu, conn);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        currentFragmanLink = dr["Fragman"].ToString();
                    }
                }

                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoldurFragmanLinkleri(anaEkran.GetLinkLabel1Text());
            webView21.Source = new Uri(currentFragmanLink);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoldurFragmanLinkleri(anaEkran.GetLinkLabel2Text());
            webView21.Source = new Uri(currentFragmanLink);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoldurFragmanLinkleri(anaEkran.GetLinkLabel3Text());
            webView21.Source = new Uri(currentFragmanLink);
        }

    }
}

