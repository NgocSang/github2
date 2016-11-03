using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThemUser.Areas.Admin.Models
{
    public class SignupModel
    {
        [Required]
        public string UserName { set; get; }

        public string Password { set; get; }
    }
}