using MVC_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CompetencyProject.Infrastructure.Abstract
{
    interface IUserActions
    {
        string RegistrationPage(UserDetail ud);
    }
}
