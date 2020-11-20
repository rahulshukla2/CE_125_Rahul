using makeChange.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace makeChange.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password",
            ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        [Required]
        [MaxLength(10,ErrorMessage ="Phone number should be of 10 digits ")]
        [RegularExpression(@"^[0-9]{10}$",
            ErrorMessage="Invalid Phone number") ]
        public string PhoneNumber { get; set; }
        

        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }

        [Required]
        public Gender Gender { get; set; }

    }
}
