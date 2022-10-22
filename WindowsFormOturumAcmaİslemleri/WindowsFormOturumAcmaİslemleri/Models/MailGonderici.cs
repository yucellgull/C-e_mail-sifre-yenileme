using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WindowsFormOturumAcmaİslemleri.Models;

namespace WindowsFormOturumAcmaİslemleri.Models
{
    public class MailGonderici
    {
        WindowsFormOturumAcmaİslemleriEntitiesConnectionDB dB = WindowsFormOturumAcmaİslemleriEntitiesConnectionDB();

        private static WindowsFormOturumAcmaİslemleriEntitiesConnectionDB WindowsFormOturumAcmaİslemleriEntitiesConnectionDB() => throw new NotImplementedException();

        public void Microsoft(string GondericiAdSoyad, string GondericiMail, string GondericiPass, string AliciMail, string Baslik, string icerik, string ek)
        {
            PersonelGisisTablosu p = dB.PersonelGisisTablosu.FirstOrDefault(x => x.MailAdress == GondericiMail);
            Random rnd = new Random();
            p.Password= rnd.Next(1000,10000).ToString();
            p.SaveChanges();
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.outlook.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential(GondericiMail, GondericiPass);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(GondericiMail,"Oturum Acma Örnek Projesi");
            mail.To.Add(AliciMail);
            mail.Subject = "Şifre Sıfırlama Talebinde Bulundunuz";
            mail.IsBodyHtml = true;
            mail.Body = string.Format(@"{0} Tarihinde Şifre Sıfırlama Talebinde Bulundunuz.Yeni Şifreniz{1}", DateTime.Now.ToString(), p.Password);
            if (ek != null)
            {
                mail.Attachments.Add(new Attachment(ek));
            }
            sc.Timeout = 100;
            sc.Send(mail);
        }

        internal void Microsoft(string text1, string text2)
        {
            throw new NotImplementedException();
        }
    }
}
