using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useractivityservice.common.commands
{
    public class AuthenticateUser :ICommand
    {
        public string UserEmail { get; set; }
        public string Password { get; set; }





    }
}
