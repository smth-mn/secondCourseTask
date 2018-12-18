using PartyInvites.Core.Storage;
using PartyInvites.Core.Storage.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyInvites.Core.Services.Db
{
    public class StorageManager
    {
        public static void StoreUser(ApplicationUser user)
        {
            var context = new Context();
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
