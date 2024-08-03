using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Data.OleDb;

namespace WinFormsPratik1
{
     public class EMailAt
    {
        public void eMailAt(string aliciEPosta,string sifirlamaKod)
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("yusufuygur345@gmail.com", "urme ffon ppft okjb");
                MailMessage eMail = new MailMessage();
                eMail.From = new MailAddress("yusufuygur345@gmail.com");
                eMail.To.Add(aliciEPosta);
                eMail.Subject = "Parola Sıfırlama Kod";
                eMail.Body = "Doğrulama kodunuz: " + sifirlamaKod;
                smtp.Send(eMail);
            }catch (Exception ex)
            {
                MessageBox.Show("E mail gönderme hatası: "+ex.Message);
            }
        }
    }
}
