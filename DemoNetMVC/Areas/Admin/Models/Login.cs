using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoNetMVC.Areas.Admin.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Email not be null")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password not be null")]
        public string Password { get; set; }
    }
}
