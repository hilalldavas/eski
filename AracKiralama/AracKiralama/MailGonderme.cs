using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracKiralama.Models;

namespace AracKiralama
{
    class MailGonderme
    {
        AracSQLEntities db = new AracSQLEntities();
        
        public void Microsoft( string GondericiMail, string AliciMail)
        {
            KayitBilgileri bilgiler = db.KayitBilgileri.FirstOrDefault(x => x.mail == GondericiMail);
            Random rnd = new Random();
            //bilgiler.sifre = rnd.Next(1000, 10000).ToString();
            string newPassword = rnd.Next(1000, 10000).ToString();
            string mailBody = "Yeni Şifreniz: "+newPassword;
            db.SaveChanges();
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("hilaldavas1905@gmail.com", "xjrx wznm eghv azxb");

            MailMessage Mail = new MailMessage();
            Mail.From = new MailAddress("hilaldavas1905@gmail.com");
            Mail.To.Add(AliciMail);
            Mail.Subject = "Şifre Değiştirme Talebi";
            //Mail.IsBodyHtml = true;
            Mail.Body = mailBody;
            //sc.Timeout = 60;
            sc.Send(Mail);
        }

       
        }
    }

 