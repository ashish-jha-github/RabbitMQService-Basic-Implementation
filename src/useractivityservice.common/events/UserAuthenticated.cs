using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useractivityservice.common.events
{
    public class UserAuthenticated : IEvent
    {
       
        public string UserEmail { get;  }
       
        public UserAuthenticated(string UserEmail)
        {

            this.UserEmail = UserEmail;
        }
        protected UserAuthenticated() { }
    }
}
