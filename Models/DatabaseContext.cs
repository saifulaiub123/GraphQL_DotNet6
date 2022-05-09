using Microsoft.EntityFrameworkCore;

namespace GraphQl_HotChochlete.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee()
                {
                    Id = 1,
                    Name = "Saiful",
                    Designation = "Software Engineer"
                },
                new Employee()
                {
                    Id = 2,
                    Name = "Akhter",
                    Designation = "Jr. Software Engineer"
                },
                new Employee()
                {
                    Id = 3,
                    Name = "Eathen",
                    Designation = "System Developer"
                }
                ,
                new Employee()
                {
                    Id = 4,
                    Name = "Razy",
                    Designation = "UX Engineer"
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
