using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Model
{
    public class UtilityHelper
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

            }
            catch (Exception ex)
            {
                Console.WriteLine("Mail not sent, due to : " + ex.Message);
                result = "Failure";
            }

            return result;
        }

        public static List<string> GetCountries()
        {
            return new List<string>
            {
            "India",
            "Pakistan",
            "Australia",
            "New Zealand",
            "Russia",
            "Canada",
            "France"
            };
        }

        public static List<string> GetGender()
        {
            return new List<string>
            {
            "Male",
            "Female",
            "Unknown"
            };
        }

        public static List<Languages> GetLanguages()
        {
            List<Languages> LangList = new List<Languages>();

            LangList.Add(new Languages { ID = 1, Language = "Telugu", IsSelected = false });
            LangList.Add(new Languages { ID = 2, Language = "English", IsSelected = false });
            LangList.Add(new Languages { ID = 3, Language = "French", IsSelected = false });
            LangList.Add(new Languages { ID = 4, Language = "German", IsSelected = false });
            LangList.Add(new Languages { ID = 5, Language = "Spanish", IsSelected = false });

             return LangList;

        }

    }
}
