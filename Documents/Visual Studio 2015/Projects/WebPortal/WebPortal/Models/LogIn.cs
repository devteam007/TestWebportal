using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebPortal.Models
{
    public class LogIn
    {
        [Display(Name ="UserName")]
        [Required(ErrorMessage ="Please enter User Name")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }

        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "Please enter First Name")]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        [Required(ErrorMessage = "Please enter Last Name")]
        public string LastName { get; set; }

        [Display(Name = "EmailId")]
        [Required(ErrorMessage = "Please enter Email Id")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email")]
        public string EmailId { get; set; }

        [Display(Name = "ContactNumber")]
        [Required(ErrorMessage = "Please enter Contact Number")]
        public int ContactNumber { get; set; }
        public string Address { get; set; }
    }
}