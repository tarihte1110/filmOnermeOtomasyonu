using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.OleDb;


namespace WinFormsPratik1
{
    public partial class Form4 : Form
    {
        public string userPosta;
        public string resetKod;
        public string userKod;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userPosta = textBox1.Text;
            Random rnd = new Random();
            resetKod = rnd.Next(10000, 100000).ToString();
            try
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=dbLogin.accdb");
                con.Open();
                OleDbCommand kmt = new OleDbCommand("SELECT COUNT (*) FROM Tablo1 WHERE mail=@KullaniciEposta", con);
                kmt.Parameters.AddWithValue("@KullaniciEposta", userPosta);
                int count = (int)kmt.ExecuteScalar();
                if (count > 0)
                {
                    EMailAt e1 = new EMailAt();
                    e1.eMailAt(userPosta, resetKod);
                    MessageBox.Show("Kod Gönderildi.");

                }
                else
                {
                    MessageBox.Show("Kod Gönderme Hatası!\nE-Postayı Kontrol Edin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-Posta Geçersiz: " + ex.Message);
            }




        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userKod = textBox2.Text;
            if (userKod == resetKod)
            {
                Form2 form = new Form2();
                form.emailAl(userPosta);
                form.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Kodlar uyuşmamaktadır.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
        }
    }
}
