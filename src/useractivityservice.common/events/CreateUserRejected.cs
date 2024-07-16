using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useractivityservice.common.events
{
    public class CreateUserRejected : IEventRejected
    {
        public string Reason { get;  }
        public string Code { get;  }

        protected CreateUserRejected() { }
        public CreateUserRejected( string reason, string code)
        {
            Reason= reason;
            Code= code;

        }
    }
}
