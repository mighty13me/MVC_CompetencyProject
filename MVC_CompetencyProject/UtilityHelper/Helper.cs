using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace UtilityHelper
{
    public class Helper
    {

        public static string SendEmail(string email, string userName, string pwd)
        {
            string result = string.Empty;
            try
            {
                MailMessage mm = new MailMessage("srichavali@demo.com", email);
                mm.Subject = "Welcome to Sri's Demo";
                mm.Body = $"You have successfully registered to the site. Go on ahead and access <br> Your email address {userName}; <br> Your Password {pwd}";
                mm.IsBodyHtml = true;


                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                NetworkCredential obj = new NetworkCredential("srimvcdemo@gmail.com", "PragimTech");
                smtp.Credentials = obj;

                smtp.Send(mm);
                Console.WriteLine("Mail sent successfully");
                result = "Success";


                // In case security restriction is there in account settings of GMAIL ID then access this link and enable setting after logging into your mail box
                // https://myaccount.google.com/lesssecureapps
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mail not sent, due to : " + ex.Message);
                result = "Failure";
            }

            return result;
        }

    }
}
