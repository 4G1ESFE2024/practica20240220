using MailKit.Security;
using MimeKit.Text;
using MimeKit;
using MailKit.Net.Smtp;

namespace Practica20240220.Models
{
    public class SendEmail
    {
        private readonly IConfiguration configuration;
        public SendEmail(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public Task Send(string to,string subject, string body)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(configuration["Email:from"]));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = body };

            // send email
            using var smtp = new SmtpClient();
            smtp.Connect(configuration["Email:smtpHost"], int.Parse(configuration["Email:smtpPort"]), SecureSocketOptions.StartTls);
            smtp.Authenticate(configuration["Email:user"], configuration["Email:pass"]);
            smtp.Send(email);
            smtp.Disconnect(true);
            return Task.CompletedTask;
        }
    }
}
