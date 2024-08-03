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

namespace WinFormsPratik1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Close();
        }

        OleDbConnection conn;
        OleDbCommand cmd;


        private void button1_Click(object sender, EventArgs e)
        {



            conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=dbLogin.accdb");
            conn.Open();

            if (textBox1.Text.Trim() == string.Empty || textBox2.Text.Trim() == string.Empty || textBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Kullanıcı Bilgileriniz Boş Olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cmd = new OleDbCommand("INSERT INTO Tablo1 (k_ad, mail,sifre) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("KAYIT BAŞARILI");
                Form1 form = new Form1();
                form.Show();
                Hide();
            }


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
        }
    }
}
