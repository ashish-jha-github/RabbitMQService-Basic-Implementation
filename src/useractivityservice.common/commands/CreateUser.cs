using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useractivityservice.common.commands
{
    public class CreateUser : ICommand
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Usermobileno { get; set; }

    }
}
