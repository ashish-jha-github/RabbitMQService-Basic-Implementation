using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useractivityservice.common.events
{
    public interface IAuthenticatedEvent : IEvent
    {
        Guid UserId { get; set; }


    }
}
