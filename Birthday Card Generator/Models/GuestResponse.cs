using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter who this card is from")]
        public string From { get; set; }

        [Required(ErrorMessage = "Please enter who the message is to")]
        public string To { get; set; }

        [Required(ErrorMessage = "Please enter your message")]
        // Exercise 1 - Models
        public string Message { get; set; }
    }
}
