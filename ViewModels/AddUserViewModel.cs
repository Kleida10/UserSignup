using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup1.ViewModels
{
    public class AddUserViewModel
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [StringLength(15, MinimumLength = 6)]
        public string Password { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Verify Password")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string Verify { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
    }
}
