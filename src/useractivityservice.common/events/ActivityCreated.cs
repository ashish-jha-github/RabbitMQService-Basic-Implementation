using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useractivityservice.common.events
{
    public class ActivityCreated : IAuthenticatedEvent
    {
        public Guid id { get; set; }
        public Guid UserId { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime createdAt { get; set; }

        protected ActivityCreated() { } 

        public ActivityCreated(Guid id, Guid userId, string category, string name, string description, DateTime createdAt)
        {
            this.id = id;
            UserId = userId;
            Category = category;
            Name = name;
            Description = description;
            this.createdAt = createdAt;
        }
    }
}
