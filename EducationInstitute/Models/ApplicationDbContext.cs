using Microsoft.EntityFrameworkCore;

namespace EducationInstitute.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=EducationDb;Trusted_Connection=True;Encrypt=False");
        }
    }
}
