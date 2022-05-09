using GraphQl_HotChochlete.Constant;
using GraphQl_HotChochlete.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQl_HotChochlete.Configuration
{
    public class StakeholderPositionDbConfiguration : IEntityTypeConfiguration<StakeholderPosition>
    {
        public void Configure(EntityTypeBuilder<StakeholderPosition> builder)
        {
            builder.ToTable(TableNames.StakeholderPosition);
            builder.HasKey(t => t.Id);
            builder.Property(p => p.StakeholderInfoId)
                .HasMaxLength(450)
                .IsRequired();
            builder.Property(p => p.TitleId)
                .HasMaxLength(450)
                .IsRequired();
            builder.Property(p => p.OrganizationId)
                .HasMaxLength(450)
                .IsRequired();
            builder.Property(p => p.DistrictId)
                .IsRequired();
            builder.Property(p => p.OfficeNumber)
                .HasMaxLength(50);
            builder.Property(p => p.Fax)
                .HasMaxLength(50);
            builder.Property(p => p.Email)
                .HasMaxLength(50);
            builder.Property(p => p.StartDate)
                .HasColumnType(DbDataType.Date)
                .IsRequired();
            builder.Property(p => p.LastDate)
                .HasColumnType(DbDataType.Date);

            builder.Property(p => p.EngagementCategory).HasConversion<int>().IsRequired();
            builder.Property(p => p.OtherIndustryCategory).HasConversion<int>().IsRequired(true);
            builder.Property(p => p.StakeholderCategory).HasConversion<int>();


            builder.Property(p => p.CreatedBy)
                .IsRequired();
            builder.Property(p => p.DateCreated)
                .HasColumnType(DbDataType.DateTime);
            builder.Property(p => p.LastUpdated)
                .HasColumnType(DbDataType.DateTime);
            builder.Property(p => p.UpdatedBy);

            builder.HasOne(p => p.CreatedUserInfo)
                .WithMany(p => p.CreatedStakeholderPosition)
                .HasForeignKey(p => p.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.UpdatedUserInfo)
                .WithMany(p => p.UpdatedStakeholderPosition)
                .HasForeignKey(p => p.UpdatedBy);
        }
    }
}

