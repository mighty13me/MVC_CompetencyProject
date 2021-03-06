﻿using System;
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
        [Display(Name = "Password")]
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CountryID { get; set; }
        public string Languages { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.DateTime)]
        public DateTime DOB { get; set; }

        public List<Languages> languages = UtilityHelper.GetLanguages();

    }
}
