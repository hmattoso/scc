using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Model;
using System.Net.Mail;
using System.Net;
using ComprasColetivas.Infrastructure.SendMail.EnvioEmail.Interfaces;

namespace ComprasColetivas.Infrastructure.SendMail.EnvioEmail
{
    class EnviarEmailMalaDireta : IEnviarEmailMalaDireta
    {
        MailMessage mailMessage;
        public void EnviarEmail(Oferta oferta, List<Comprador> compradores)
        {
            foreach (var item in compradores)
            {
                this.mailMessage = new MailMessage();
                this.mailMessage.From = new MailAddress("comprascoletivas@gmail.com", "Compras Coletivas");
                this.mailMessage.To.Add(item.Contato.Email);
                this.mailMessage.Subject = "Nova Oferta No Compras Coletivas";
                string body = "";
                this.mailMessage.Body = body;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("comprascoletivas@gmail.com", "comprascoletivas");
                try
                {
                    smtp.Send(this.mailMessage);
                }
                catch (Exception)
                {
                    throw;
                }
            }


        }
    }
}
