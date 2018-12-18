using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PartyInvites.Core.Storage.Auth;

namespace PartyInvites.Core.Storage
{
    public class Context : DbContext
    {
        public Context() : base("AppUsers") { }

        public DbSet<ApplicationUser> Users { get; set; }
    }
}
