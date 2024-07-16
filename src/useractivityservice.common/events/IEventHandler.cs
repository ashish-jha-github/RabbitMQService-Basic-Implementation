using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useractivityservice.common.events
{
    internal interface IEventHandler <in T> where T : IEvent
    {

        Task HandleEventAsync(T Tevent);
    }
}
