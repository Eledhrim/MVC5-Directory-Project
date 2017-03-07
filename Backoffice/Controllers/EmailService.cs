using Microsoft.AspNet.Identity;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Backoffice.Controllers
{
    public class EmailService
    {
        public async Task SendAsync(IdentityMessage message)
        {
            await smtpSend(message);
        }

        private static async Task smtpSend(IdentityMessage message)
        {


            var msg = new MailMessage();
            msg.To.Add(message.Destination);
            msg.Subject = message.Subject;
            msg.Body = message.Body;
            msg.IsBodyHtml = true;
            using (var smtp = new SmtpClient())
            {
                await smtp.SendMailAsync(msg);

            }


        }
    }
}