using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Participant
    {
        [Key]
        public Guid Id { get; set; }

        public string ParticipantId { get; set; }

        public string Email { get; set; }
    }
}
