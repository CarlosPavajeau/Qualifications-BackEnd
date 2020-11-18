using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QualificationsAPI.Model;

namespace QualificationsAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ApplicationUserConfig());
            builder.ApplyConfiguration(new UserLoginConfig());
            builder.ApplyConfiguration(new IdentityUserTokenConfig());
            builder.ApplyConfiguration(new IdentityRoleConfig());
        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}
