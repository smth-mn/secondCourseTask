using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class RegistrationResponse
    {
        [Required(ErrorMessage = "Enter your name, please")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter your e-mail, please")]
        public string Email { get; set; }
        
        public string Phone { get; set; }
        
        public bool ReceivesNotifications { get; set; }

        [Required(ErrorMessage = "Confirm your age, please")]
        public DateTime Birthday { get; set; }
    }
}