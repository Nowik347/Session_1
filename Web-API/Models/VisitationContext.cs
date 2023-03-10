using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Web_API.Models
{
    public class VisitationContext : DbContext
    {
        public VisitationContext(DbContextOptions<VisitationContext> options) : base(options)
        { 
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; } = null;
        public DbSet<Visitor> Visitors { get; set; } = null;
        public DbSet<GroupVisitor> Groups { get; set; } = null;
        public DbSet<File> Files { get; set; } = null;
    }
}
