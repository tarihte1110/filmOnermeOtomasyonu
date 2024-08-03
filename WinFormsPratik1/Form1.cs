using FilmOnerme;
using System.Data.OleDb;


namespace WinFormsPratik1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader dr;
        int id;
        private void button1_Click(object sender, EventArgs e)
        {
            string mail = textBox1.Text;
            string sifre = textBox2.Text;


            conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=dbLogin.accdb");
            cmd = new OleDbCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Tablo1 where k_ad='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                 id = (int)dr["kimlik"];
                string k_ad = dr["k_ad"].ToString();

                MessageBox.Show("Hoþgeldiniz " + k_ad);
                AnaEkran a1 = new AnaEkran();
                a1.idAl(id);
                a1.Label5Text = k_ad;
                a1.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("Kullanýcý Adýnýz Veya Þifre Yanlýþ.");
            }

            conn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form4 = new Form4();
            Hide();
            form4.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else textBox2.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            Hide();
            form3.Show();

        }

    }
}