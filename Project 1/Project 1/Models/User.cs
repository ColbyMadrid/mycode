using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Project_1.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public bool IsAdmin { get; set; }

    }
}
