using Eticaret.Core.Entities;
using System.Net;
using System.Net.Mail;
namespace Eticaret.WebUI.araclar
{
    public class MailHelper
    {
        public static async Task SendMailAsync(Iletisim contact)
        {
            SmtpClient smtpClient = new SmtpClient("mail.siteadi.com",587);
            smtpClient.Credentials = new NetworkCredential("info@siteadi.com","mailşifresi");
            smtpClient.EnableSsl = false;
            MailMessage message = new MailMessage();
            message.From = new MailAddress("info@siteadi.com");
            message.To.Add("bilgi@siteadi.com");
            message.Subject = "Siteden atılan mesaj ";
            message.Body = $"İsim: {contact.İsim}- Soyisim: {contact.Soyisim} - Email: {contact.Email} - Telefon: {contact.Telefon} - Mesaj: {contact.Mesaj}";
            message.IsBodyHtml = true;
            await smtpClient.SendMailAsync(message);
            smtpClient.Dispose();

        }
    }
}
