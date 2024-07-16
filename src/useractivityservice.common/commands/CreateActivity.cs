using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useractivityservice.common.commands
{
    public class CreateActivity : IAuthenticatedCommand
    {
        public Guid id {  get; set; }
        public Guid UserId { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime createdAt  {  get; set; }
        
    }
}
