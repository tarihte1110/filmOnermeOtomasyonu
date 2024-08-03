using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace WinFormsPratik1
{
    public class sifreYenile
    {
        public void SifreYenile1(string userEmail,string newPassword)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=dbLogin.accdb");
            try
            {
                conn.Open();
                OleDbCommand kmt = new OleDbCommand("UPDATE Tablo1 SET sifre=@YeniSifre WHERE mail=@KullaniciMail", conn);
                kmt.Parameters.AddWithValue("@YeniSifre", newPassword);
                kmt.Parameters.AddWithValue("@KullaniciMail", userEmail);
                int rowsaffected = kmt.ExecuteNonQuery();
                if (rowsaffected > 0)
                {
                    MessageBox.Show("Şifre güncellendi");
                }
                else
                {
                    MessageBox.Show("Şifre güncellenemedi.");
                }
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show("Şifre güncelleme hatası: "+ex.Message);
            }
            
        }
    }
}
