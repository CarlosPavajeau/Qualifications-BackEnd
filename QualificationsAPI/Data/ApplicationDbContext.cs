using Microsoft.EntityFrameworkCore;
using QualificationsAPI.Model;

namespace QualificationsAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}
