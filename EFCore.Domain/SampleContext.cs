using Microsoft.EntityFrameworkCore;
namespace EFCore.Domain
{
    public class SampleContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }

        public SampleContext(DbContextOptions<SampleContext> options) : base (options)
        {
            //this.Countries.Add(new Country { Name = "Portugal" });
            //this.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
