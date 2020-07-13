using MVC_CompetencyProject.Infrastructure.Abstract;
using MVC_Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_CompetencyProject.Infrastructure.Respository
{
    public class Registration : IUserActions
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conString"]);
        public string RegistrationPage(UserDetail ud)
        {
            //Insert new user Detail
            SqlCommand com = new SqlCommand("dbo.[uspAddUser]", con);
            com.CommandType = CommandType.StoredProcedure;
            string result = string.Empty;


            try
            {
                con.Open();
                com.Parameters.AddWithValue("@pLogin", ud.LoginName);
                com.Parameters.AddWithValue ("@pPassword", ud.PasswordHash);
                com.Parameters.AddWithValue("@pEmail", ud.Email);
                com.Parameters.AddWithValue("@pFirstName", ud.FirstName);
                com.Parameters.AddWithValue("@pCountryID", ud.CountryID);
                com.Parameters.AddWithValue("@pLanguages", ud.Languages);
                com.Parameters.AddWithValue("@pGender", ud.Gender);
                com.Parameters.AddWithValue("@pAddress", ud.Address);

                SqlParameter p = com.Parameters.Add("@responseMessage", SqlDbType.VarChar,50);
                p.Direction = ParameterDirection.Output;
                

                com.ExecuteNonQuery();
                result = p.Value.ToString();

                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }
    }
}