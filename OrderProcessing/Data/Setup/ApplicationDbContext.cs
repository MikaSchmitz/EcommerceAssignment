using Microsoft.EntityFrameworkCore;

namespace OrderProcessing.Data.Setup
{
    /// <summary>
    /// The application context connects to our database and allows queries to go through entity framework
    /// </summary>
    public class ApplicationDbContext : DbContext
    {

        // DbSets here...

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Custom indexing here...

            base.OnModelCreating(modelBuilder);
        }
    }
}
