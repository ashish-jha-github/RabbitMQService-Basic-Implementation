using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useractivityservice.common.events
{
    public class UserCreated : IEvent
    {
        public string Email { get;  }
        public string Username { get;  }
        public string Usermobileno { get; }

        protected UserCreated() { }

        public  UserCreated(string email, string username, string usermobileno)
        {
            Email = email;
            Username = username;
            Usermobileno = usermobileno;
        }

    }
}
