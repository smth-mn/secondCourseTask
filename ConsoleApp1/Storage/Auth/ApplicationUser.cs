using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyInvites.Core.Storage.Auth
{
    public class ApplicationUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public byte[] Photo { get; set; }
        public bool ReceivesNotifications { get; set; }
    }
}
