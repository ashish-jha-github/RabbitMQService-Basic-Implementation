using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useractivityservice.common.commands
{
    internal interface IAuthenticatedCommand : ICommand
    {

        Guid UserId { get; set; }

    }
}
