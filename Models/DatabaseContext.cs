using Microsoft.EntityFrameworkCore;

namespace GraphQl_HotChochlete.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public virtual DbSet<StakeholderInfo> StakeholderInfo { get; set; }
        public virtual DbSet<StakeholderPosition> StakeholderPosition { get; set; }
        public virtual DbSet<StakeholderVisit> StakeholderVisit { get; set; }
        public virtual DbSet<Title> Title { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<EducationalInstitute> EducationalInstitute { get; set; }
        public virtual DbSet<StakeholderEducationalHistory> StakeholderEducationalHistory { get; set; }
        public virtual DbSet<BusinessCard> BusinessCard { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }

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
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            foreach (var item in ChangeTracker.Entries<BaseModel>())
            {
                switch (item.State)
                {
                    case EntityState.Added:
                        item.Entity.DateCreated = DateTime.Now;
                        item.Entity.LastUpdated = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        item.Entity.LastUpdated = DateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
