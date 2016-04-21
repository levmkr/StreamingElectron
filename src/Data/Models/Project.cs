using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Project
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Participant> Participants { get; set; } 
    }
}
