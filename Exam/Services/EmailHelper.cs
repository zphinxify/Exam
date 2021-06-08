using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Services
{
    public static class EmailHelper
    {
        public static void SendEmailVerification(string encodedCallBackUrl, string toEmail)
        {  
            string from = "fromaddress@gmail.com"; //From address    
            MailMessage message = new MailMessage(from, toEmail);

            string mailbody = $"Please confirm your account by <a href = ' {encodedCallBackUrl} ' > clicking here </a>";
            message.Subject = "Please verify your email";
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            client.UseDefaultCredentials = false;
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("benjamiiiin94@gmail.com", "pghowuczoiqvtcwu");
            client.EnableSsl = true;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SendEmailResetLink(string encodedCallBackUrl, string toEmail)
        {    
            string from = " SupportBoiler@gmail.com"; //From address    
            MailMessage message = new MailMessage(from, toEmail);

            string mailbody = $"Please confirm your account by <a href = ' {encodedCallBackUrl} ' > clicking here </a>";
            message.Subject = "Link to reset your password";
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            client.UseDefaultCredentials = false;
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("benjamiiiin94@gmail.com", "pghowuczoiqvtcwu");
            client.EnableSsl = true;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
