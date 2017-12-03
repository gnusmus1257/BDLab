using System.Data.Entity;

namespace BDLab26
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            :base("DbConnection")
        { }
        public DbSet<Service> Service { get; set; }
        public DbSet<Visitors> Visitor { get; set; }
        public DbSet<Visits> Visit { get; set; }
    }
}