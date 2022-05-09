using GraphQl_HotChochlete.Constant;
using GraphQl_HotChochlete.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQl_HotChochlete.Configuration
{
    public class StakeholderVisitDbConfiguration : IEntityTypeConfiguration<StakeholderVisit>
    {
        public void Configure(EntityTypeBuilder<StakeholderVisit> builder)
        {
            builder.ToTable(TableNames.StakeholderVisit);
            builder.HasKey(t => t.Id);
            builder.Property(p => p.VisitedDate)
                .HasColumnType(DbDataType.DateTime)
                .IsRequired();
            builder.Property(p => p.VisitedBy)
                .IsRequired();
            builder.Property(p => p.VisitedLocation)
                .HasMaxLength(250);
            builder.Property(p => p.Duration);
            builder.Property(p => p.NoOfGifts);
            builder.Property(p => p.RelationType)
                .HasMaxLength(250);
            builder.Property(p => p.Remarks);
            builder.Property(p => p.Subject)
                .HasMaxLength(250);
            builder.Property(p => p.KeyOutcomes)
                .HasMaxLength(250);
            builder.Property(p => p.NextSteps)
                .HasMaxLength(250);
            builder.Property(p => p.AdvocacyTool)
                .HasMaxLength(250);
            builder.Property(p => p.IsPrivate)
                .HasDefaultValue(false);

            builder.Property(p => p.EngagementCategory)
                .HasConversion<int>()
                .IsRequired();
            builder.Property(p => p.OtherIndustryCategory)
                .HasConversion<int>()
                .IsRequired(true);
            builder.Property(p => p.StakeholderCategory)
                .HasConversion<int>()
                .IsRequired();

            builder.Property(p => p.CreatedBy)
                .IsRequired();
            builder.Property(p => p.DateCreated)
                .HasColumnType(DbDataType.DateTime);
            builder.Property(p => p.LastUpdated)
                .HasColumnType(DbDataType.DateTime);
            builder.Property(p => p.UpdatedBy);


            builder.HasOne(p => p.VisitedByUserInfo)
                .WithMany(p => p.VisitedByStakeholderVisit)
                .HasForeignKey(p => p.VisitedBy)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.CreatedUserInfo)
                .WithMany(p => p.CreatedStakeholderVisit)
                .HasForeignKey(p => p.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.UpdatedUserInfo)
                .WithMany(p => p.UpdatedStakeholderVisit)
                .HasForeignKey(p => p.UpdatedBy);
        }
    }
}
