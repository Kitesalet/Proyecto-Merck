using Microsoft.Extensions.Configuration;
using ProyectoMerck.DataAccess.Interfaces;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Utilities
{
    public class EmailSender : IEmailSendeer
    {
        private string? SendGridSecret { get; set; }
        private string? FromEmail { get; set; }
        private string? ToEmail { get; set; }

        public EmailSender(IConfiguration _config)
        {
            SendGridSecret = _config["Sendgrid:SecretKey"];
            FromEmail = _config["Sendgrid:FromEmail"];
            ToEmail = _config["Sendgrid:ToEmail"];
        }

        public async Task<bool> EmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SendGridClient(SendGridSecret);
            var from = new EmailAddress(FromEmail);
            //Si queremos hacer pruebas, se cambia el mail del to;
            var to = new EmailAddress(ToEmail); //mariocoria025@gmail.com
            var msg = MailHelper.CreateSingleEmail(from, to, subject, "", htmlMessage);

            try
            {
                var response = await client.SendEmailAsync(msg);

                if (response.IsSuccessStatusCode == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return false;

            }
        }

    }
}