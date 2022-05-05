using Microsoft.EntityFrameworkCore;
using RepositoryAPI.Repository;

namespace RepositoryAPI.Database
{
    public class MyDBContext : DbContext
    {
        public DbSet<EndUser> EndUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EndUser>()
                .HasData(
                new EndUser()
                {
                    Id = 1,
                    Name = "test",
                    password = "test",
                    Username = "test"
                });
            base.OnModelCreating(modelBuilder);
        }

        public MyDBContext(DbContextOptions<MyDBContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
