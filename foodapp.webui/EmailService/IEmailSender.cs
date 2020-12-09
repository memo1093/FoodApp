using System.Threading.Tasks;

namespace foodapp.webui.EmailService
{
    public interface IEmailSender
    {
        //smtp => gmail, hotmail
        //api => sendgrid

        Task SendEmailAsync(string email,string subject,string htmlMessage);
    }
}