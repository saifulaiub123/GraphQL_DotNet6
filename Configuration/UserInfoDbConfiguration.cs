using GraphQl_HotChochlete.Constant;
using GraphQl_HotChochlete.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQl_HotChochlete.Configuration
{
    public class UserInfoDbConfiguration : IEntityTypeConfiguration<UserInfo>
    {
        public void Configure(EntityTypeBuilder<UserInfo> builder)
        {
            builder.ToTable(TableNames.UserInfo);
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Name)
                .HasMaxLength(300)
                .IsRequired();
            builder.Property(p => p.Email)
                .HasMaxLength(300)
                .IsRequired();
            builder.Property(p => p.EmployeeId)
                .HasMaxLength(100);
            builder.Property(p => p.Designation)
                .HasMaxLength(300);
            builder.Property(p => p.Department)
                .HasMaxLength(300);
            builder.Property(p => p.Function)
                .HasMaxLength(500);
        }
    }
}