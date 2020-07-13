using MVC_CompetencyProject.Infrastructure.Abstract;
using MVC_CompetencyProject.Infrastructure.Respository;
using MVC_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UtilityHelper;

namespace MVC_CompetencyProject.Controllers
{
    public class RegistrationController : Controller
    {
        IUserActions obj = new Registration();
        // GET: Registration
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(UserDetail ud)
        {
            var res =obj.RegistrationPage(ud);
            if (res.Equals("Success"))
            {
                var rs = Helper.SendEmail(ud.Email, ud.LoginName, ud.PasswordHash);
            }
            return View();
        }
    }
}