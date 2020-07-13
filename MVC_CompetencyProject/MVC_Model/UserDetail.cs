using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Model
{
    public class UserDetail
    {
        [Key]
        public int UserID { get; set; }
        public string LoginName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CountryID { get; set; }
        public string Languages { get; set; }
        public string Gender { get; set; }
        public int Address { get; set; }


    }
}
