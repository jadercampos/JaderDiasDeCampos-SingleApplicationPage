using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace JaderDiasDeCampos.MVC.Models
{
    public class EmailSender
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }
        public void Enviar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("<p><b>Nome:</b> {0}</p>", this.Nome));
            sb.AppendLine(string.Format("<p><b>E-mail:</b> {0}</p>", this.Email));
            sb.AppendLine(string.Format("<p><b>Assunto:</b> {0}</p>", this.Assunto));
            sb.AppendLine(string.Format("<p><b>Mensagem:</b> {0}</p>", this.Mensagem));
            string smtpAddress = "smtp.gmail.com";
            int portNumber = 587;
            bool enableSSL = true;
            string emailFrom = "jadercampos@gmail.com";
            string password = "C#@V0D3L8";
            string emailTo = "jadercampos@gmail.com";
            string subject = string.Format("E-mail do Site: {0}", this.Assunto);
            string body = sb.ToString();
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFrom);
                mail.To.Add(emailTo);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFrom, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }
            }

        }
    }
}