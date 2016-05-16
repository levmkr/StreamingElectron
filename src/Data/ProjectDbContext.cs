using Data.Models;
using Microsoft.Data.Entity;

namespace Data
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Participant> Participants { get; set; }
    }
}
