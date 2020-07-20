using MVC_CompetencyProject.Infrastructure.Abstract;
using MVC_CompetencyProject.Infrastructure.Respository;
using MVC_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CompetencyProject.Controllers
{
    public class RegistrationController : Controller
    {
        IUserActions obj = new Registration();
        // GET: Registration
        [HttpGet]
        public ActionResult Registration()
        {
            var countries = UtilityHelper.GetCountries();
            ViewBag.Countries = countries;

            var gender = UtilityHelper.GetGender();
            ViewBag.Gender = gender;

            var languages = UtilityHelper.GetLanguages();
            ViewBag.Languages = languages;

            return View();
        }

        [HttpPost]
        public ActionResult Registration(UserDetail ud, FormCollection col)
        {

            if (!string.IsNullOrEmpty(col["languages"]))
            {
                string checkResp = col["languages"];
                ud.Languages = checkResp;
            }

            var res = obj.RegistrationPage(ud);

            if (res.Equals("Success"))
            {
                var rs = UtilityHelper.SendEmail(ud.Email, ud.LoginName, ud.PasswordHash);
            }
            return View();
        }

    }
}