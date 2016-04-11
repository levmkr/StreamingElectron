using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Participant
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Email { get; set; }
    }
}
