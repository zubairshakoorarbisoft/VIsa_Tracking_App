using VisaTracking.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace VisaTracking.ViewModels
{
    public class SignUpViewModel
    {
        public SignUpViewModel()
        {
            Claims = new List<UserClaim>();
        }

        [Required, EmailAddress, Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[!@#$%^&*])(?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage = "Passwords must have at least one non alphanumeric character, lowercase ('a'-'z') and one uppercase ('A'-'Z').")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        [Required, Display(Name = "Sign Up as")]
        public int RoleId { get; set; }
        [Display(Name = "Profile Picture")]
        public IFormFile ProfileImage { get; set; }

        #region Collections
        public IEnumerable<object> UserRoles { get; set; }
        public List<UserClaim> Claims { get; set; }
        #endregion

    }
}
