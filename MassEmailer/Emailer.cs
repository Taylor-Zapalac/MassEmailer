

using System.Net.Mail;

namespace MassEmailer
{
    class Emailer
    {

        public void SendEmail(string emailSubject, string emailAddress, string emailBody, string relayClient, string fromEmail)
        {
            SmtpClient client = new SmtpClient(relayClient);
            MailAddress from = new MailAddress(fromEmail);
            MailAddress to = new MailAddress(emailAddress);
            MailMessage body = new MailMessage(from, to);
            body.Body = emailBody;
            body.Subject = emailSubject;
            client.Send(body);

            body.Dispose();
        }
    }
}
