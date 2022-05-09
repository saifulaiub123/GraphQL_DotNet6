using GraphQl_HotChochlete.Constant;
using GraphQl_HotChochlete.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQl_HotChochlete.Configuration
{
    public class StakeholderEducationalHistoryDbConfiguration : IEntityTypeConfiguration<StakeholderEducationalHistory>
    {
        public void Configure(EntityTypeBuilder<StakeholderEducationalHistory> builder)
        {
            builder.ToTable(TableNames.StakeholderEducationalHistory);
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Title)
                .HasMaxLength(250)
                .IsRequired();
            builder.Property(p => p.StakeholderInfoId)
                .HasMaxLength(450)
                .IsRequired();
            builder.Property(p => p.Level)
                .HasMaxLength(250)
                .IsRequired();
            builder.Property(p => p.Year)
                .IsRequired();
            builder.Property(p => p.EducationalInstituteId)
                .HasMaxLength(450)
                .IsRequired();
            builder.Property(p => p.Batch)
                .HasMaxLength(250);
            builder.HasIndex(p => p.StakeholderInfoId)
                .IsUnique(false);
            builder.HasIndex(p => p.EducationalInstituteId)
                .IsUnique(false);

            builder.Property(p => p.CreatedBy)
                .IsRequired();
            builder.Property(p => p.DateCreated)
                .HasColumnType(DbDataType.DateTime);
            builder.Property(p => p.LastUpdated)
                .HasColumnType(DbDataType.DateTime);
            builder.Property(p => p.UpdatedBy);

            builder.HasOne(p => p.CreatedUserInfo)
                .WithMany(p => p.CreatedStakeholderEducationalHistory)
                .HasForeignKey(p => p.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.UpdatedUserInfo)
                .WithMany(p => p.UpdatedStakeholderEducationalHistory)
                .HasForeignKey(p => p.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}