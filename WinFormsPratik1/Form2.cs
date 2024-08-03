using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPratik1
{
    public partial class Form2 : Form
    {
        public string eMAİL;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SifreGuncel(eMAİL);
        }
        public void emailAl(string mail)
        {
            eMAİL = mail;
        }
        public void SifreGuncel(string mail)
        {
            if (textBox1.Text == textBox2.Text)
            {

                sifreYenile s1 = new sifreYenile();
                s1.SifreYenile1(eMAİL, textBox1.Text);
                Form1 form = new Form1();
                form.Show();
                Close();

            }
            else
            {
                MessageBox.Show("Şifreler uyuşmamakta");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Close();
        }
    }
}
