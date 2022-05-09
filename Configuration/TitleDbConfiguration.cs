using GraphQl_HotChochlete.Constant;
using GraphQl_HotChochlete.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQl_HotChochlete.Configuration
{
    public class TitleDbConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable(TableNames.Title);
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Name)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(p => p.CreatedBy)
                .IsRequired();
            builder.Property(p => p.DateCreated)
                .HasColumnType(DbDataType.DateTime);
            builder.Property(p => p.LastUpdated)
                .HasColumnType(DbDataType.DateTime);
            builder.Property(p => p.UpdatedBy);

            builder.HasOne(p => p.CreatedUserInfo)
                .WithMany(p => p.CreatedTitle)
                .HasForeignKey(p => p.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.UpdatedUserInfo)
                .WithMany(p => p.UpdatedCreatedTitle)
                .HasForeignKey(p => p.UpdatedBy);
        }
    }
}
