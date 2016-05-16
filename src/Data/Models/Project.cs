using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Participant> Participants { get; set; } 
    }
}
